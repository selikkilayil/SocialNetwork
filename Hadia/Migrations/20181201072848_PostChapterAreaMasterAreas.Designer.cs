﻿// <auto-generated />
using System;
using Hadia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hadia.Migrations
{
    [DbContext(typeof(HadiaContext))]
    [Migration("20181201072848_PostChapterAreaMasterAreas")]
    partial class PostChapterAreaMasterAreas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_AdminPrivilage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AdminAccess");

                    b.Property<bool>("AluminiDataAccess");

                    b.Property<bool>("BlockAccess");

                    b.Property<bool>("HafAccess");

                    b.Property<int>("MemberId");

                    b.Property<bool>("MemberPosting");

                    b.HasKey("Id");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("Mem_AdminPrivilages");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_CountryCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<string>("CountryCode");

                    b.Property<string>("CountryName");

                    b.Property<string>("TimeZone");

                    b.HasKey("Id");

                    b.ToTable("Mem_CountryCodes");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_DistrictMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("CLogin");

                    b.Property<string>("DistrictName");

                    b.Property<int>("StateId");

                    b.HasKey("Id");

                    b.HasIndex("CLogin");

                    b.HasIndex("StateId");

                    b.ToTable("Mem_DistrictMasters");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_EducationalQualificationMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("CLogin");

                    b.Property<string>("DegreeName");

                    b.Property<int>("Rank");

                    b.HasKey("Id");

                    b.HasIndex("CLogin");

                    b.ToTable("Mem_EducationalQualifications");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_EducationDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("EducationQualificationId");

                    b.Property<int>("MemberId");

                    b.Property<DateTime>("PassoutYear")
                        .HasColumnType("date");

                    b.Property<string>("Specialization")
                        .HasMaxLength(125);

                    b.Property<int>("UniversityId");

                    b.HasKey("Id");

                    b.HasIndex("EducationQualificationId");

                    b.HasIndex("MemberId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Mem_EducationDetails");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_InterestedArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("InterestedAreaId");

                    b.Property<int>("MemberId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Mem_InterestedAreas");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_Kid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Age");

                    b.Property<DateTime>("CDate");

                    b.Property<byte>("Gender");

                    b.Property<string>("KidName")
                        .HasMaxLength(120);

                    b.Property<int>("MemberId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Mem_Kids");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_Master", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdNo")
                        .IsRequired();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<int?>("DistrictId");

                    b.Property<string>("Email");

                    b.Property<int?>("GroupId");

                    b.Property<bool>("IsGroupAdmin");

                    b.Property<bool>("IsVarified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("PermanentAddress");

                    b.Property<string>("PresentAddress")
                        .IsRequired();

                    b.Property<DateTime?>("SpouseAge");

                    b.Property<int?>("SpouseEducationId");

                    b.Property<string>("SpouseName");

                    b.Property<byte>("Type");

                    b.Property<int?>("UgCollageId");

                    b.Property<int?>("VarifiedBy");

                    b.Property<DateTime?>("VarifiedDate");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.HasIndex("GroupId");

                    b.HasIndex("SpouseEducationId");

                    b.HasIndex("UgCollageId");

                    b.HasIndex("VarifiedBy");

                    b.ToTable("Mem_Masters");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_MemberContanct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("ConuntryCodeId");

                    b.Property<bool>("IsVerified");

                    b.Property<int>("MemberId");

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ConuntryCodeId");

                    b.HasIndex("MemberId");

                    b.ToTable("Mem_MemberContancts");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("CLogin");

                    b.Property<DateTime>("MDate");

                    b.Property<int>("MLogin");

                    b.Property<int>("MemberId");

                    b.Property<byte>("Status");

                    b.Property<int>("YearId");

                    b.HasKey("Id");

                    b.HasIndex("CLogin");

                    b.HasIndex("MLogin");

                    b.HasIndex("MemberId");

                    b.ToTable("Mem_Memberships");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_MyNetwork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<DateTime>("DDate");

                    b.Property<int>("MemberId");

                    b.Property<int>("NetworkMemberId");

                    b.Property<byte>("Status");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("NetworkMemberId");

                    b.ToTable("Mem_MyNetworks");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<string>("Image");

                    b.Property<bool>("IsActive");

                    b.Property<int>("MemberId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Mem_Photos");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_SpouseEducationMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("CLogin");

                    b.Property<string>("QualificationName");

                    b.HasKey("Id");

                    b.HasIndex("CLogin");

                    b.ToTable("Mem_SpouseEducationMasters");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_StateMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("CLogin");

                    b.Property<string>("StateName")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("CLogin");

                    b.ToTable("Mem_StateMasters");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_UgColleges", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("CLogin");

                    b.Property<string>("UgCollegeName");

                    b.HasKey("Id");

                    b.HasIndex("CLogin");

                    b.ToTable("Mem_UgColleges");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_UniversityMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("CLogin");

                    b.Property<int>("CountryId");

                    b.Property<string>("UniversityName");

                    b.HasKey("Id");

                    b.HasIndex("CLogin");

                    b.HasIndex("CountryId");

                    b.ToTable("Mem_UniversityMasters");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_WorkDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(50);

                    b.Property<int>("CountryId");

                    b.Property<DateTime>("DateForm");

                    b.Property<DateTime>("DateUpto");

                    b.Property<string>("JobTitle")
                        .HasMaxLength(100);

                    b.Property<string>("Location")
                        .HasMaxLength(50);

                    b.Property<int>("MemberId");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("MemberId");

                    b.ToTable("Mem_WorkDetails");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Post_ChapterLeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("CLogin");

                    b.Property<DateTime>("DateFrom");

                    b.Property<int>("GroupId");

                    b.Property<int>("MemberId");

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CLogin");

                    b.HasIndex("GroupId");

                    b.HasIndex("MemberId");

                    b.ToTable("Post_ChapterLeaders");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Post_GroupMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("CLogin");

                    b.Property<string>("Description");

                    b.Property<DateTime>("FormedOn");

                    b.Property<string>("GroupImage");

                    b.Property<string>("GroupName")
                        .HasMaxLength(100);

                    b.Property<byte>("OpenOrClosed");

                    b.Property<string>("PassoutYear")
                        .HasMaxLength(125);

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CLogin");

                    b.ToTable("Post_GroupMasters");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Post_GroupMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("CDate");

                    b.Property<int>("GroupId");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsGroupAdmin");

                    b.Property<DateTime>("MDate");

                    b.Property<int>("MemberId");

                    b.Property<int>("ModifiedBy");

                    b.HasKey("Id");

                    b.HasIndex("AddedBy");

                    b.HasIndex("GroupId");

                    b.HasIndex("ModifiedBy");

                    b.ToTable("Post_GroupMembers");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Post_InterestedArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("CLogin");

                    b.Property<int>("GroupId");

                    b.Property<int>("InterestedAreaId");

                    b.HasKey("Id");

                    b.HasIndex("CLogin");

                    b.HasIndex("GroupId");

                    b.HasIndex("InterestedAreaId");

                    b.ToTable("Post_InterestedAreas");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Post_InterestedAreaMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDate");

                    b.Property<int>("CLogin");

                    b.Property<string>("InterestName");

                    b.HasKey("Id");

                    b.HasIndex("CLogin");

                    b.ToTable("Post_InterestedAreaMasters");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_AdminPrivilage", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "Member")
                        .WithOne("Privilage")
                        .HasForeignKey("Hadia.Models.DomainModels.Mem_AdminPrivilage", "MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_DistrictMaster", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "CreatedBy")
                        .WithMany("DistrictMasters")
                        .HasForeignKey("CLogin")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hadia.Models.DomainModels.Mem_StateMaster", "State")
                        .WithMany("Districts")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_EducationalQualificationMaster", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "CreatedBy")
                        .WithMany("EducationalQualificationMasters")
                        .HasForeignKey("CLogin")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_EducationDetail", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_EducationalQualificationMaster", "Qualification")
                        .WithMany("EducationDetails")
                        .HasForeignKey("EducationQualificationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "Member")
                        .WithMany("EducationDetails")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Mem_UniversityMaster", "University")
                        .WithMany("EducationDetails")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_InterestedArea", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "Member")
                        .WithMany("InterestedAreas")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_Kid", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "Member")
                        .WithMany("Kids")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_Master", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_DistrictMaster", "District")
                        .WithMany("MembersInDistrict")
                        .HasForeignKey("DistrictId");

                    b.HasOne("Hadia.Models.DomainModels.Post_GroupMaster", "MainGroup")
                        .WithMany("Members")
                        .HasForeignKey("GroupId");

                    b.HasOne("Hadia.Models.DomainModels.Mem_SpouseEducationMaster", "SpouseEducation")
                        .WithMany("MembersSpouses")
                        .HasForeignKey("SpouseEducationId");

                    b.HasOne("Hadia.Models.DomainModels.Mem_UgColleges", "UgCollege")
                        .WithMany("MembersInUg")
                        .HasForeignKey("UgCollageId");

                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "VarifiedMember")
                        .WithMany("VarifiedMembers")
                        .HasForeignKey("VarifiedBy");
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_MemberContanct", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_CountryCode", "CountryCode")
                        .WithMany("Contancts")
                        .HasForeignKey("ConuntryCodeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "Member")
                        .WithMany("Contacts")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_Membership", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "CreatedBy")
                        .WithMany("MemberShipsCreated")
                        .HasForeignKey("CLogin")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "ModifiedBy")
                        .WithMany("MemberShipsModified")
                        .HasForeignKey("MLogin")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "Member")
                        .WithMany("MemberShips")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_MyNetwork", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "Member")
                        .WithMany("Networks")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "NetworkMember")
                        .WithMany("MemberInNetworks")
                        .HasForeignKey("NetworkMemberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_Photo", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "Member")
                        .WithMany("Photos")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_SpouseEducationMaster", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "CreatedBy")
                        .WithMany("SpouseEducationMasters")
                        .HasForeignKey("CLogin")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_StateMaster", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "CreatedBy")
                        .WithMany("StateMasters")
                        .HasForeignKey("CLogin")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_UgColleges", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "CreatedBy")
                        .WithMany("UgColleges")
                        .HasForeignKey("CLogin")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_UniversityMaster", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "CreatedBy")
                        .WithMany("UniversityMasters")
                        .HasForeignKey("CLogin")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hadia.Models.DomainModels.Mem_CountryCode", "CountryCode")
                        .WithMany("UniversityMasters")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Mem_WorkDetail", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_CountryCode", "Country")
                        .WithMany("WorkersInCountry")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "Member")
                        .WithMany("WorkDetails")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Post_ChapterLeader", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "CreatedBy")
                        .WithMany("CreatedChapterLeaders")
                        .HasForeignKey("CLogin")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Post_GroupMaster", "Group")
                        .WithMany("ChapterLeaders")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "Member")
                        .WithMany("LeaderInChapters")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Post_GroupMaster", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "CreatedBy")
                        .WithMany("CreatedGroups")
                        .HasForeignKey("CLogin")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Post_GroupMember", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "AddedMember")
                        .WithMany("MembersAdded")
                        .HasForeignKey("AddedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Post_GroupMaster", "GroupMaster")
                        .WithMany("GroupMembers")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "ModifiedMember")
                        .WithMany("MembersModified")
                        .HasForeignKey("ModifiedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Post_InterestedArea", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "CreatedBy")
                        .WithMany("CreatedinterestAreas")
                        .HasForeignKey("CLogin")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Post_GroupMaster", "GroupMaster")
                        .WithMany("InterestedAreas")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hadia.Models.DomainModels.Post_InterestedAreaMaster", "InterestedAreaMaster")
                        .WithMany("InterestedAreas")
                        .HasForeignKey("InterestedAreaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hadia.Models.DomainModels.Post_InterestedAreaMaster", b =>
                {
                    b.HasOne("Hadia.Models.DomainModels.Mem_Master", "CreatedBy")
                        .WithMany("InterestedAreaMasterCreated")
                        .HasForeignKey("CLogin")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

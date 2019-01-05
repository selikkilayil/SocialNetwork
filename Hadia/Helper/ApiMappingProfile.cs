using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Hadia.Models.DomainModels;
using Hadia.Models.Dtos;

namespace Hadia.Helper
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<Mem_UgColleges, UgCollageDto>();
            CreateMap<Mem_StateMaster,StateDto>();

            CreateMap<Mem_Master, RegistrationDto>();
            CreateMap<RegistrationDto, Mem_Master>();

            CreateMap<Mem_UniversityMaster,UniversityDto>()
             .ForMember(dest => dest.Name, o => o.MapFrom(s => s.UniversityName));

            CreateMap<UniversityDto,Mem_UniversityMaster>()
            .ForMember(dest => dest.UniversityName, o => o.MapFrom(s => s.Name));

            CreateMap<Mem_EducationalQualificationMaster,EducationQualificationDto>()
                .ForMember(dest => dest.Name, o => o.MapFrom(s => s.DegreeName));
            CreateMap<EducationQualificationDto,Mem_EducationalQualificationMaster>();
                        


            
            CreateMap<Mem_JobCategoryMaster,JobCategoryDto>();
            CreateMap<JobCategoryDto,Mem_JobCategoryMaster>();

            
            CreateMap<Mem_CountryCode,CountryDto>();
            CreateMap<CountryDto,Mem_CountryCode>();

            CreateMap<Mem_WorkDetail,JobdetailDto>();
            CreateMap<JobdetailDto,Mem_WorkDetail>();

            CreateMap<Mem_SpouseEducationMaster,SpouseEducationDto>()
                .ForMember(f=>f.Name,o=> o.MapFrom(s=>s.QualificationName));
            CreateMap<SpouseEducationDto,Mem_SpouseEducationMaster>();

            
            CreateMap<Mem_Kid,KidsDto>();
            CreateMap<KidsDto,Mem_Kid>()
             .ForMember(dest => dest.Age,opt => opt.MapFrom(src => new DateTime(DateTime.Now.Year - src.Age??1,1,1)));

            CreateMap<Post_Category, PostCategoryDto>();


            CreateMap<Post_Comment, CommentViewDto>()
                .ForMember(dest => dest.Name, from =>
                    from.MapFrom(src => src.Createdby.Name))
                .ForMember(dest => dest.Text, from =>
                    from.MapFrom(src => GetUrl(src.Type, src.Comment, src.Date)));

            CreateMap<Post_Comment, CommentReplayDto>()
                .ForMember(dest => dest.Name, from =>
                    from.MapFrom(src => src.Createdby.Name))
                .ForMember(dest => dest.Text, from =>
                    from.MapFrom(src => GetUrl(src.Type, src.Comment, src.Date)));

            //CreateMap<Post_Master, TimelineViewDto>()
            //    .ForMember(dest => dest.Images, from =>
            //        from.MapFrom(src => GetUrl(src.PostImages)));

            CreateMap<Post_Master, FeedDto>()
                .ForMember(dest => dest.Images, from =>
                    from.MapFrom(src => GetUrl(src.PostImages)))
                .ForMember(dest => dest.Name, from =>
                    from.MapFrom(src => src.OpendBy.Name))
                .ForMember(dest => dest.Date, from =>
                    from.MapFrom(src => src.CDate.ToString("yyyy-MM-dd hh:mm:ss tt")))
                .ForMember(dest => dest.Voice, from =>
                    from.MapFrom(src => src.Voice != null?GetVoice(src.Voice):null));

            CreateMap<Post_Master, TimelineViewDto>()
                .ForMember(dest => dest.Images, from =>
                    from.MapFrom(src => GetUrl(src.PostImages)))
                .ForMember(dest => dest.Date, from =>
                    from.MapFrom(src => src.CDate.ToString("yyyy-MM-dd hh:mm:ss tt")))
                .ForMember(dest => dest.Voice, from =>
                    from.MapFrom(src => GetVoice(src.Voice)));



        }


        private List<string> GetUrl(ICollection<Post_Image> images)
        {
            return images.Select(x => $"/Images/{x.Image}").ToList();
        }

        private string GetVoice(string url) => $"/Voice/{url}";

        private string GetUrl(CommentType commentType,string src,DateTime date)
        {
            var folderName = date.ToString("yyyy-MM-dd");
            switch (commentType)
            {
                case CommentType.Image:
                    return $"/Images/{folderName}/{src}";
                case CommentType.Voice:
                    return $"/Voice/{folderName}/{src}";
                default:
                    return src;
            }
        }
    }
}
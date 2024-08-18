using AutoMapper;
using PM_DataAccess.GeneInfo;
using PM_DataAccess.PatientClasses;
using PM_DataAccess.Referrer;
using PM_DataAccess.SEA;
using PM_DataAccess.StagesClasses;
using PM_DataAccess.UserProfiles;
using PM_Models.GeneInfo;
using PM_Models.PatientModels;
using PM_Models.ReferrerModels;
using PM_Models.SEA;
using PM_Models.StageModels;
using PM_Models.UserProfilesModels;

namespace PM_Server.Business.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Patient, PatientDTO>().ReverseMap();
            CreateMap<Referrer, ReferrerDTO>().ReverseMap();
            CreateMap<UserProfile, UserProfileDTO>().ReverseMap();
            CreateMap<UserType, UserTypeDTO>().ReverseMap();
            CreateMap<Stage, StageDTO>().ReverseMap();
            CreateMap<StageStatus, StageStatusDTO>().ReverseMap();
            CreateMap<NGOClass, NGOClassDTO>().ReverseMap();
            CreateMap<SocioeconomicAssessment, SocioeconomicAssessmentDTO>().ReverseMap();
            CreateMap<StageTypes, StageTypeDTO>().ReverseMap();
            CreateMap<Nationality, NationalityDTO>().ReverseMap();
            CreateMap<Surgery, SurgeryDTO>().ReverseMap();
            CreateMap<ScoringSystem, ScoringSystemDTO>().ReverseMap();
            CreateMap<EmploymentStatus, EmploymentStatusDTO>().ReverseMap();
            CreateMap<EmploymentType, EmploymentTypeDTO>().ReverseMap();
        }
    }
}

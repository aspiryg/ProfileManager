using AutoMapper;
using PM_DataAccess.PatientClasses;
using PM_Models.PatientModels;

namespace ProfileManager_Web.Business.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Patient, PatientDTO>().ReverseMap();
        }
    }
}

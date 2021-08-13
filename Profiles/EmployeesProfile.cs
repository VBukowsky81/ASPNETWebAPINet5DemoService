using WebAPIDemoApp.DTO;
using WebAPIDemoApp.Models;
using AutoMapper;

//DTO mappings configurations. Each map must be done manually, and is not reversable
namespace WebAPIDemoApp.Profiles
{
    public class EmployeesProfile : Profile
    {

        public EmployeesProfile()
        {
            CreateMap<Employee, ReadDTO>();

            CreateMap<CreateDTO, Employee>();

            CreateMap<UpdateDTO, Employee>();

            CreateMap<Employee, UpdateDTO>();
        }

    }
}

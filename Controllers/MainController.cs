using WebAPIDemoApp.Data;
using WebAPIDemoApp.DTO;
using WebAPIDemoApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;
using AutoMapper;

namespace WebAPIDemoApp.Controllers
{
    [Route("myapi/employees")]
    [ApiController]
    public class MainController : ControllerBase
    {

        //1st part is in Startup, AddScoped
        private readonly IEmployeesRepo _repository;
        private readonly IMapper _mapper;

        public MainController(IEmployeesRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadDTO>> GetAll()
        {
            var employeeItems = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<ReadDTO>>(employeeItems));
        }

        [HttpGet("{id}", Name = "GetEmployeeById")]
        public ActionResult<ReadDTO> GetEmployeeById(int id)
        {
            var employeeItem = _repository.GetEmployeeById(id);
            if (employeeItem != null)
            {
                return Ok(_mapper.Map<ReadDTO>(employeeItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ReadDTO> CreateEmployee(CreateDTO employeeCreateDto)
        {

            var employeeModel = _mapper.Map<Employee>(employeeCreateDto);
            _repository.CreateEmployee(employeeModel);
            _repository.SaveChanges();

            //just AutoMapper to the request object data that we get from users
            var employeeReadDto = _mapper.Map<ReadDTO>(employeeModel);

            //adds proper Status Codes, and the source URL in the header
            return CreatedAtRoute(nameof(GetEmployeeById), new { Id = employeeReadDto.Id }, employeeReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateResult(int id, UpdateDTO employeeUpdateDto) {

            var employeeModelFromRepo = _repository.GetEmployeeById(id);

            //Just checking for empty objects
            if (employeeModelFromRepo == null)
            {
                return NotFound();
            }

            //Automapper mapping
            _mapper.Map(employeeUpdateDto, employeeModelFromRepo);

            _repository.UpdateEmployee(employeeModelFromRepo);
            _repository.SaveChanges();

            //Returns 204 code
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialCommandUpdate(int id, JsonPatchDocument<UpdateDTO> patchDoc)
        {
            var employeeModelFromRepo = _repository.GetEmployeeById(id);

            if (employeeModelFromRepo == null)
            {
                return NotFound();
            }

            var employeeToPatch = _mapper.Map<UpdateDTO>(employeeModelFromRepo);

            //applying JSON patch
            patchDoc.ApplyTo(employeeToPatch, ModelState);

            //validation check
            if (!TryValidateModel(employeeToPatch))

            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(employeeToPatch, employeeModelFromRepo);

            _repository.UpdateEmployee(employeeModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            var employeeModelFromRepo = _repository.GetEmployeeById(id);

            if (employeeModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteEmployee(employeeModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}

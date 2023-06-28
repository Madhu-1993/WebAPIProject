using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Model;
using WebAPIProject.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentServices service;
        public DepartmentController(IDepartmentServices service)
        {
            this.service = service;
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        [Route("GetAllDepartments")]
        public IActionResult Get()
        {
            return new ObjectResult(service.GetAllDepartment());
        }

        // GET api/<DepartmentController>/5
        [HttpGet]
        [Route("GetDepartmentById/{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            return new ObjectResult(service.GetDepartmentById(id));
        }

        // POST api/<DepartmentController>
        [HttpPost]
        [Route("AddDepartment")]
        public IActionResult AddDepartment([FromBody] Department dept)
        {
            try
            {
                int result = service.AddDepartment(dept);
                if (result == 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        // PUT api/<DepartmentController>/5
        [HttpPost]
        [Route("UpdateDepartment")]
        public IActionResult UpdateDepartment([FromBody] Department dept)
        {
            try
            {
                int result = service.UpdateDepartment(dept);
                if (result == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // DELETE api/<DepartmentController>/5
        [HttpGet]
        [Route("DeleteDepartment/{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            try
            {
                int result = service.DeleteDepartment(id);
                if (result == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}

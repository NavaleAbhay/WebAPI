
using Microsoft.AspNetCore.Mvc;
using TflWebAPI.Contexts;
using TflWebAPI.Model;
using TflWebAPI.Repositories.Interfaces;
using TflWebAPI.Repositories;
using TflWebAPI.Services.Interfaces;
using TflWebAPI.Services;

namespace TflWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DepartmentController : ControllerBase
{
        private IDepartmentService _svc;
        public DepartmentController(IDepartmentService svc){
            _svc=svc;
        }

        [HttpGet]
        [Route("api/departments")]
        public IActionResult GetAll(){
            try{
                var message=_svc.GetAllDepartment();
                if(message==null){
                    return NotFound();
                }
                return Ok(message);
            }
            catch(Exception){
                return BadRequest();
            }
        }

    }

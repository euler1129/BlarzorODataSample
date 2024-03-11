using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ODataApiSample.Models;

namespace ODataApiSample.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [EnableQuery()]
        public IEnumerable<Student> Get()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Vishwa Goli",
                    Score = 100
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Josh McCall",
                    Score = 120
                }
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using ChildStudy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChildStudy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase 
    {
        [HttpGet]
        public IEnumerable<Raiting> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Raiting
            {
                TeacherGrade = rng.Next(10),
                StudentGrade = rng.Next(10)
            })
            .ToArray();
        }
    }
}

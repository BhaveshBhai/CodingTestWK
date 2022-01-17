using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WKBackend.Model;
using WKBackend.Repository;

namespace WKBackend.Controllers
{
    [Route("api/[controller]")]
    public class FormController : Controller
    {
        private readonly IFormsRepository _formsRepository;
        public FormController(IFormsRepository formsRepository)
        {
            _formsRepository = formsRepository;
        }
       [HttpGet]
        public async Task<IActionResult> GetForms()
        {
            return Ok(_formsRepository.GetForms());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFormById(int id)
        {
            return Ok(_formsRepository.GetFormDetailsById(id));
        }

    }
}

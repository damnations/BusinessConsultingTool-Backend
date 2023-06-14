using BusinessConsultingTool.DataAPI.Models;
using BusinessConsultingTool.DataAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusinessConsultingTool.DataAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController: ControllerBase
    {
        private readonly CustomersService _customersService;

        public CustomersController(CustomersService customersService) => _customersService = customersService;

        [HttpGet]
        public async Task<List<Customer>> Get() { }

        [HttpPost]
        public async Task<IActionResult> Post(Customer newCustomer) { }

        [HttpPut("{id}")]
        public async Task<IActionResult> AddToPlaylist(string id, string movieId) { }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id) { }
    }
}

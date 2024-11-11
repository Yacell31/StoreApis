using Microsoft.AspNetCore.Mvc;
using System.Xml;
using Yacell.Store.APIs.Services.Contracts;

namespace Yacell.Store.APIs.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class HomeController : Controller
    {

        private readonly ICustomerService _customerService;

        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
     

        [HttpGet]
        [Route("/Clients")]
        public  IActionResult GetClientList()
        {
            try
            {       
                return new JsonResult(_customerService.GetCustomerList());
               // return new JsonResult('This is a client');
            }
            catch (Exception e)

            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);

            }
        }



    }
}

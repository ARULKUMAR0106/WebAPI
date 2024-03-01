using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebAPI_Tutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstAPIController : ControllerBase
    {
        [HttpGet]
        public IActionResult get()
        {
            return Ok("Your first API call is success");
        }     

        [HttpPost]
        public IActionResult Post(JObject data)
        {
            data["value"] = "arul";
           return Ok(data);
            // If get this point we can connect to database and send it back with some data
        }
    }
}

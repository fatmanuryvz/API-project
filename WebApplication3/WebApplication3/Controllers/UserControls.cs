using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserControls : ControllerBase
    {
        public string Get()
        {
            return "Get Users";
        } 

        }
    }


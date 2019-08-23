using System.Web.Http;

namespace DevOpsProjectWebApi.Controllers
{
    public class HomeController : ApiController
    {            
        [HttpGet]
        [ActionName("Data")]
        public IHttpActionResult Data()
        {
            return Ok("Hey");
        }

        [HttpGet]
        [ActionName("Value")]
        public IHttpActionResult Value()
        {
            return Ok("Hi");
        }
    }
}
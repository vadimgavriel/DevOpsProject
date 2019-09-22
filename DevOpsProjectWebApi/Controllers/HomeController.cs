using System.Web.Http;

namespace DevOpsProjectWebApi.Controllers
{
    public class HomeController : ApiController
    {            
        [HttpGet]
        [ActionName("GetStudentName")]
        public IHttpActionResult GetStudentName()
        {
            return Ok("Vadim");
        }

        [HttpGet]
        [ActionName("GetStudentMail")]
        public IHttpActionResult GetStudentMail()
        {
            return Ok("godofsaw@gmail.com");
        }
    }
}
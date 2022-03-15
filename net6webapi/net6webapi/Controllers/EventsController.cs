using Microsoft.AspNetCore.Mvc;

namespace net6webapi.Controllers
{
    
    public class EventsController : Controller
    {

        // GET: EventsController
        
        [Route("events")]
        public ActionResult EventsAPI()
        {
            var systeminfo = new sysinfo
            {
                OSDescription = System.Runtime.InteropServices.RuntimeInformation.OSDescription,
                OSArchitecture = System.Runtime.InteropServices.RuntimeInformation.OSArchitecture.ToString(),
                FrameworkDescription = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription,
                ProcessArchitecture = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString(),
                RuntimeIdentifier = System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier,
                Feature = "X"
            };
            return Ok(systeminfo);

        }

        [HttpGet]
        [Route("events/health")]
        public ActionResult HealthAPI()
        {
            return Ok("Healthy");

        }


    }
}

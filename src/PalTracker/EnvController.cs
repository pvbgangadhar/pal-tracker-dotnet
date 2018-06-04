using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("env")]
    public class EnvController : Controller
    {
        private readonly CloudFoundryInfo _cloudFoundryEnv;

        [HttpGet]
        public CloudFoundryInfo Get() => _cloudFoundryEnv;

        public EnvController(CloudFoundryInfo cloudFoundryEnv)
        {
            //CHANGE THAT DOES NOT MATTER

            _cloudFoundryEnv = cloudFoundryEnv;
        }
    }
}
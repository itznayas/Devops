using Microsoft.AspNetCore.Mvc;
using Devops.Shared;

namespace Devops.WebApi.Controllers
{
    [ApiController]
    [Route("api/my")]
    public class MyController : ControllerBase
    {
        private readonly IMyService _myService;

        public MyController(IMyService myService)
        {
            _myService = myService;
        }

        [HttpGet]
        public ActionResult<bool> Index()
        {
            return _myService.IsOK();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Resize.Application;
using Resize.Domain;

namespace Resize.API.Controllers
{
    public class ResizeController : ControllerBase
    {
        private readonly IResizeApplication _resizeApplication;

        public ResizeController(IResizeApplication resizeApplication)
        {
            _resizeApplication = resizeApplication;
        }

        [HttpGet("InitialDimentions")]
        public async Task<Dimensions> InitialDimentions([FromQuery] string info)
        {
            return await _resizeApplication.InitialDimentions(info);
        }

        [HttpPost("UpdateDimensions")]
        public async Task<Dimensions> UpdateDimensions([FromQuery] string info)
        {
            return await _resizeApplication.UpdateDimentions(info);
        }
    }
}

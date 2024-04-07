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
        public async Task<ActionResult<Dimensions>> InitialDimentions()
        {
            try
            {
                return Ok(await _resizeApplication.InitialDimentions());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("UpdateDimensions")]
        public async Task<ActionResult<Dimensions>> UpdateDimensions([FromQuery] string info)
        {
            try
            {
                return Ok(await _resizeApplication.UpdateDimentions(info));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

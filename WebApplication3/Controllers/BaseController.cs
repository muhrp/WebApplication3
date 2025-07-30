using Entities.DTO;
using Entities.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication3.Controllers
{
    public class BaseController : Controller
    {
        protected UserSSO _userSSO = new();

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _userSSO = context.HttpContext.User.Claims.GetUserLogin();
        }

        public IActionResult Index()
        {
            return View();
        }

        

        protected OkObjectResult Ok(object value, string message = "", bool pagination = false)
        {
            return base.Ok(new ApiResponse() { Data = value, Message = message, Success = true });
        }

        protected OkObjectResult Ok(object value, int total)
        {
            return base.Ok(new ApiResponse() { Data = value, Total = total, Success = true });
        }

        protected BadRequestObjectResult BadRequest(Exception ex)
        {
            return base.BadRequest(new BadRequestError(ex));
        }
    }
}

using Chi_ExpenseTracker_Service.Common.Jwt;
using Chi_ExpenseTracker_Service.Models.Api;
using Chi_ExpenseTracker_Service.Models.Jwt;
using Microsoft.AspNetCore.Mvc;

namespace Chi_ExpenseTracker_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LoginController : Controller
    {
        private readonly IJwtAuthService _jwtAuth;

        /// <summary>
        /// JWT服務載入
        /// </summary>
        public LoginController(IJwtAuthService jwtAuthService)
        {
            _jwtAuth = jwtAuthService;
        }

        /// <summary>
        /// 產生JWT TOKEN
        /// </summary>
        /// <param name="jwtLoginViewModel">登入資料</param>
        /// <returns></returns>
        [HttpPost]
        public ApiResponseModel Login([FromBody] JwtLoginDto jwtLoginViewModel)
        {
            var result = _jwtAuth.Login(jwtLoginViewModel);

            return new ApiResponseModel
            {
                Code = result.Code,
                Data = result.Data
            };
        }

        /// <summary>
        /// 驗證Token
        /// </summary>
        /// <returns>Token資料</returns>
        [HttpPost]
        public IActionResult RefreshToken([FromBody] JwtTokenDto tokenViewModel)
        {
            JwtTokenDto result = _jwtAuth.RefreashToken(tokenViewModel);

            return Ok(result);
        }
    }
}

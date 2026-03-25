using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyVocabulary.Web.Models;
using MyVokabulary.Repository.Data;
using MyVokabulary.Repository.Models;


namespace MyVocabulary.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistrationController:Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly MyVocabularyContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public RegistrationController(
            MyVocabularyContext context, 
            UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] UserModel user)
        {
            var userIdentity = new IdentityUser { UserName = user.Login };
            var result = await userManager.CreateAsync(userIdentity, user.Password);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost("Login")]

        public async Task<IActionResult> Login([FromBody] UserModel user)
        {
            var result = await signInManager.PasswordSignInAsync(user.Login, user.Password,true,true);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

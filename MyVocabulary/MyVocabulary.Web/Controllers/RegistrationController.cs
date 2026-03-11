using Microsoft.AspNetCore.Mvc;
using MyVokabulary.Repository.Data;
using MyVokabulary.Repository.Models;


namespace MyVocabulary.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationController:Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly MyVocabularyContext _context;
        
        public RegistrationController(MyVocabularyContext context)
        {
            _context = context;
        }

        [HttpPost("Register")]
        public ContentResult Register([FromBody] User user)
        {        
            if (user != null)
            {
                var dbUser = from element in _context.Users where (element.Login == user.Login) &&(element.Password == user.Login) select element;
                if (dbUser == null)
                {
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    Response.ContentType = "application/json";
                   ContentResult result = new ContentResult();
                    result.Content = "Регистрация прошла успешно!";
                    result.StatusCode = 200;
                    return result;
                }
                else
                {
                    ContentResult result = new ContentResult();
                    result.Content = "Регистрация не прошла, допущенна ошибка!";
                    result.StatusCode = 400;
                    return result;
                }
            }
            else
            {
                ContentResult result = new ContentResult();
                result.Content = "Регистрация не прошла, допущенна ошибка!";
                result.StatusCode = 400;
                return result;
            }
        }
    }
}

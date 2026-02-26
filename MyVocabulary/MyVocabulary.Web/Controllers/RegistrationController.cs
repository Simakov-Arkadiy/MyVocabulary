using Microsoft.AspNetCore.Mvc;
using MyVokabulary.Repository.Data;
using MyVokabulary.Repository.Models;

namespace MyVocabulary.Web.Controllers
{
    [Controller]
    public class RegistrationController:Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly MyVocabularyContext _context;
        
        public RegistrationController(MyVocabularyContext context)
        {
            _context = context;
        }
        
        public string Register(User user)
        {
            
            if (user != null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return "Регистрация прошла успешно";
            }
            else
            {
                return "Регистрация не прошла, допущенна ошибка";
            }
        }
    }
}

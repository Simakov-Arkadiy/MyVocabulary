using MyVokabulary.Repository.Models;
using System.Text.Json.Serialization;

namespace MyVocabulary.Web.Models
{
    public class UserModel
    {
        public required string Login { get; set; }
        public required string Password { get; set; }
    }
}

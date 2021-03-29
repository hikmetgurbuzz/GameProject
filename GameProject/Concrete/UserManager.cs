using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
     public class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public UserManager(UserValidationManager userValidationManager)
        {
        }

        public void Save(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kullanıcı sisteme kayıt edildi.");
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kullanıcı sistemden silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kullanıcı güncellendi.");
        }
    }
}

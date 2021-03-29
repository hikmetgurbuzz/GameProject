using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public class UserValidationManager : IEntity
    {
        public bool Validate(User user)
        {
            if (user.TcNo == "123456789" && user.FirstName == "Hikmet" && user.LastName == "Gürbüz" && user.BirthYear == new DateTime(1996 / 02 / 11))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IUserService
    {
        void Save(User user);
        void Delete(User user);
        void Update(User user);
    }
}
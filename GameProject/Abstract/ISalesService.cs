using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Buy(User user, Game game, Campaign campaign, Sales sales);
        void Return(User user, Game game, Campaign campaign, Sales sales);
    }
}

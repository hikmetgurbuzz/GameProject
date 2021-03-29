using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SalesManager : IEntity
    {
        public void Buy(User user, Game game, Campaign campaign, Sales sales)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " isimli oyuncu " + sales.SaleDate + " tarihinde " + campaign.CampaignName + " kampanyası dahilinde " + game.GamePrice + " TL olan " + game.GameName + " isimli oyunu " + campaign.Discount + " TL indirim ile satın aldı.");
        }

        public void Return(User user, Game game, Campaign campaign, Sales sales)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " isimli oyuncu " + sales.SaleDate + " tarihinde " + game.GamePrice + " TL tutarındaki " + game.GameName + " isimli oyunu iade etti." );
        }
    }
}

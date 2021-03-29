using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyuna " + campaign.CampaignName + " kampanyası kapsamında " + campaign.Discount + " TL indirim tanımlandı.");
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası sona erdi. " + game.GameName + " adlı oyunun " + campaign.Discount + " TL indirim fırsatı bitti.");
        }

        public void Update(Campaign campaign, Game game)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyasındaki " + game.GameName + " adlı oyunun indirimli fiyatı " + campaign.Discount + " TL olarak güncellendi.");
        }
    }
}

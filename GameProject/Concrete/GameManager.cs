using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun sepete eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun sepetten çıkarıldı.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Sepetinde ki " + game.GameName + " adlı oyunun fiyatı güncellendi." );
        }
    }
}

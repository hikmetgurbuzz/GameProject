using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Database
{
    public class DatabaseLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veriler veritabanına kaydedildi!");
        }
    }
}

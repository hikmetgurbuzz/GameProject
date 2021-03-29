using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Database
{
    public class FileLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veriler dosyaya kaydedildi!");
        }
    }
}

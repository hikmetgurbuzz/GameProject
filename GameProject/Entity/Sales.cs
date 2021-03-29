using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
    }
}

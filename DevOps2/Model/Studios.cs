using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOps2.Model
{
    public class Studios
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HQCity { get; set; }
        public int workers { get; set; }


        public Studios()
        {
                
        }

        public Studios(int id, string name, string hqCity, int workers)
        {
            Id = id;
            Name = name;
            HQCity = hqCity;
            this.workers = workers; 
        }

        
    }
}

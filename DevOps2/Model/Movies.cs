using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace DevOps2.Model
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double RunningDuration { get; set; }
        public int StudioId { get; set; }

        public Movies(int id, string title, int year, double runningDuration, int studioId)
        {
            Id = id;
            Title = title;
            Year = year;
            RunningDuration = runningDuration;
            StudioId = studioId;    
        }

        public Movies()
        {
                
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Game : BaseDomainModel
    {     
        public string? Title { get; set; }
        public double OverallRating { get; set; }
        public string? Genre { get; set; }       
        public string? Developer { get;set; }       
        public DateTime ReleaseDate { get; set; }   
        public string? Description { get; set; }   
        public string? Platform { get; set; }
        public virtual List<Recommendation>? Recommedations { get; set; }
        public virtual List<Store>? Stores { get; set; }
        public virtual List<Review>? Reviews { get; set; }
    }
}

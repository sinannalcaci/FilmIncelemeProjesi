using FilmIncelemeProjesi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmIncelemeProjesi.Entity.Poco
{
    public class Film:BaseEntity
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public string Description { get; set; }
        public DateTime DateTime { get; set; }


        public IEnumerable<Yorum> Yorums { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}

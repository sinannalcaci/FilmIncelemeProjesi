using FilmIncelemeProjesi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmIncelemeProjesi.Entity.Poco
{
    public class Yorum:BaseEntity
    {
        public string Content { get; set; }

        public Film Film { get; set; }
        public int FilmId { get; set; }

    }
}

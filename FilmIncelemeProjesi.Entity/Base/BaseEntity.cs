using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmIncelemeProjesi.Entity.Base
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.Guid = Guid.NewGuid();
        }
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}

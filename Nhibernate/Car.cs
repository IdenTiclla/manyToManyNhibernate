using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhibernate
{
    class Car
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual Make Make { get; set; }
        public virtual Model Model { get; set; }
    }
}

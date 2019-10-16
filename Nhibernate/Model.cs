using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhibernate
{
    class Model
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Make Make { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhibernate
{
    class Book
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }

        public virtual Author Author { get; set; }
    }
}

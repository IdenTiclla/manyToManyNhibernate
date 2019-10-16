
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhibernate
{
    class Author
    {
        public virtual int Id { get; set; }
        public virtual string Name {get;set;}
        public virtual string LastName { get; set; }

        public virtual IList<Book> Books { get; set; }
    }
}

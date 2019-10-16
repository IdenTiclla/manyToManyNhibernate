
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
namespace Nhibernate
{
    class BookMap:ClassMap<Book>
    {
        public BookMap()
        {
            Id(x => x.Id);
            Map(x => x.Title);
            References(x => x.Author).Cascade.All();


        }
    }
}

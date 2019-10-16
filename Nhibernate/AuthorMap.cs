
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
namespace Nhibernate
{
    class AuthorMap:ClassMap<Author>
    {
        public AuthorMap()
        {
            
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.LastName);
        }
    }
}

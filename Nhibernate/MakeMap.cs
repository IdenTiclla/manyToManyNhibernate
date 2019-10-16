using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using FluentNHibernate.Mapping;

namespace Nhibernate
{
    class MakeMap : ClassMap<Make>
    {
        public MakeMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);

        }

    }
}

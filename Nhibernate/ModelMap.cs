using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;

namespace Nhibernate
{
    class ModelMap : ClassMap<Model>
    {
        public ModelMap()

        {
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.Make).Cascade.All();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;

namespace Nhibernate
{
    class CarMap : ClassMap<Car>
    {
        public CarMap()

        {
            Id(x => x.Id);
            Map(x => x.Title);
            References(x => x.Make).Cascade.All();
            References(x => x.Model).Cascade.All();
        }
    }
}

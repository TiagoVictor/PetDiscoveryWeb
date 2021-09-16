using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDiscovery.Models
{
    public class AnimaisEncontradosMap : ClassMap<AnimaisEncontrados>
    {
        public AnimaisEncontradosMap()
        {
            Id(c => c.animaisEncontrados_id);
            Map(c => c.animaisEncontrados_cliente_id);
            Table("tb_animaisencontrados");
        }
    }
}

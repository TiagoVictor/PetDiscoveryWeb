using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDiscovery.Models
{
    public class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Id(c => c.cliente_Id);
            Map(c => c.cliente_nome);
            Map(c => c.cliente_email);
            Table("tb_cliente");
        }
    }
}

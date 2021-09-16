using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDiscovery.Models
{
    public class EnderecoMap : ClassMap<Endereco>
    {
        public EnderecoMap()
        {
            Id(c => c.endereco_Id);
            Map(c => c.endereco_cliente_Id);
            Map(c => c.endereco_cidade);
            Map(c => c.endereco_numero);
            Map(c => c.endereco_pais);
            Map(c => c.endereco_rua);
            Map(c => c.endereco_uf);
            Table("tb_endereco");
        }
    }
}

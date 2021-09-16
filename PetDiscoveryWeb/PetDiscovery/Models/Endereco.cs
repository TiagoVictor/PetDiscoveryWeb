using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDiscovery.Models
{
    public class Endereco
    {
        public virtual int endereco_Id { get; set; }

        public virtual int endereco_cliente_Id { get; set; }

        public virtual string endereco_cidade { get; set; }

        public virtual string endereco_uf { get; set; }

        public virtual string endereco_pais { get; set; }

        public virtual string endereco_rua { get; set; }

        public virtual string endereco_numero { get; set;}

    }
}

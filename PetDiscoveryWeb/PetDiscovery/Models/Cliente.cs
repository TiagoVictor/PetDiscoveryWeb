using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDiscovery.Models
{
    public class Cliente
    {
        public virtual int cliente_Id { get; set;}

        public virtual string cliente_nome { get; set;}

        public virtual string cliente_email { get; set;}
    }
}

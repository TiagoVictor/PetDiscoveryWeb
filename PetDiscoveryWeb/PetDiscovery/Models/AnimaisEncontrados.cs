using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDiscovery.Models
{
    public class AnimaisEncontrados
    {
        public virtual int animaisEncontrados_id { get; set;}

        public virtual int animaisEncontrados_cliente_id { get; set;}
    }
}

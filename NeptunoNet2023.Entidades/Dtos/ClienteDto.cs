using NeptunoNet2023.Entidades.Dtos.Ciudad;
using NeptunoNet2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptunoNet2023.Entidades.Dtos
{
    public class ClienteDto
    {
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        
        public string Pais { get; set; }
        public CiudadListDto CiudadListDto { get; set; }
        public string Ciudad { get; set; }

        
    }
}

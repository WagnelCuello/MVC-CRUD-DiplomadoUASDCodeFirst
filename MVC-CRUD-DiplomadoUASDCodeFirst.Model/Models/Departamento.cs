using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_DiplomadoUASDCodeFirst.Model.Models
{
    class Departamento
    {
        public int DepartamentooID { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Registro> registros { get; set; }
    }
}

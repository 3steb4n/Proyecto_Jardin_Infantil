using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Jardin.DAO
{
    class conexionBD
    {
        protected SqlConnection conexion = new SqlConnection("Server=DIEGOALEJANDRO; Database=JardinInfantil; Integrated Security=true");
    }
}

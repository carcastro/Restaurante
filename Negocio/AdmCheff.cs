using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmCheff
    {
        CheffDB cheffDB = new CheffDB();

        public int ingresarCheff(Cheff cheff)
        {
            //Validaciones
            //Validar si ya existe el cheff
            Cheff cheffAuxiliar = cheffDB.buscarPorDNI(cheff.DNI);

            if(cheffAuxiliar == null)//Si no existe el cheff con ese DNI me lo agrega
            {
                cheffDB.agregarCheff(cheff);
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}

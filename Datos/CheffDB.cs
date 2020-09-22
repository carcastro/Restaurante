using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CheffDB
    {
        ComaEnJoeDBEntities DB = new ComaEnJoeDBEntities();

        public void agregarCheff(Cheff cheff)
        {
            DB.Cheffs.Add(cheff);
            DB.SaveChanges();
        }

        public Cheff buscarPorDNI(string dni) 
        {
            Cheff cheff = DB.Cheffs.Where(c => c.DNI == dni).FirstOrDefault();
            return cheff;
        }
    }
}

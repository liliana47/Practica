using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ColeccionList
    {

        List<String> listaCiudades = new List<String>();

        public void Agregar(String nombreCiudad)
        {
            listaCiudades.Add(nombreCiudad);
        }

        public List<String> ConsultarTodo()
        {
            return listaCiudades;
        }
        public void Eliminar(String nombreCiudad)
        {
            listaCiudades.Remove(nombreCiudad);
        }

    }
}

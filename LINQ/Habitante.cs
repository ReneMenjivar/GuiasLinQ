using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinQ
{
    public class Habitante
    {
        // Propiedad para almacenar el identificador del habitante
        public int IdHabitante { get; set; }

        // Propiedad para almacenar el nombre del habitante
        public string Nombre { get; set; }

        // Propiedad para almacenar la edad del habitante
        public int Edad { get; set; }

        // Propiedad para almacenar el identificador de la casa en la que vive el habitante
        public int IdCasa { get; set; }

        // Método para obtener una cadena de texto con los datos del habitante
        public string datosHabitante()
        {
            // Retorna una cadena con los detalles del habitante formateada
            return $"Soy {Nombre} con edad de {Edad} años vividos en la casa con ID {IdCasa}";
        }

    }
}

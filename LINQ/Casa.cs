using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinQ
{
    public class Casa
    {
        // Propiedades para almacenar el atributos de la casa
        public int Id { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public int numeroHabitaciones { get; set; }

        public string dameDatosCasa()
        {
            // Retorna una cadena con los detalles de la casa formateada
            return $"Dirección es {Direccion} en la ciudad de {Ciudad} con número de habitaciones {numeroHabitaciones}";
        }
    }

}

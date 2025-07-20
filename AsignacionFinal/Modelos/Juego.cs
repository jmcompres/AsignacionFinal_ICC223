using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionFinal.Modelos
{
    public class Juego
    {
        public string idJuego {  get; set; }
        public string descripcion { get; set; }
        public string idEquipoA { get; set; }
        public string idEquipoB { get; set; }
        public DateTime fechaYHora { get; set; }
    }
}

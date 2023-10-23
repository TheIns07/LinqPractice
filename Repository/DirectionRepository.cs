using LinQPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQPractice.Repository
{
    public class DirectionRepository
    {
        public List<Direction> GetDirections()
        {
            return new List<Direction>
            {
                new Direction { Id = 1, EstudianteId = 1, DireccionEstudiante = "Gonzales suarez y eloy alfaro esquina." },
                new Direction { Id = 2, EstudianteId = 1, DireccionEstudiante = "Via a la villa km. 8." },
                new Direction { Id = 3, EstudianteId = 2, DireccionEstudiante = "las casas y mariana de jesus, casa #140." },
                new Direction { Id = 4, EstudianteId = 3, DireccionEstudiante = "guayas y pichincha , casa #15." },
                new Direction { Id = 5, EstudianteId = 4, DireccionEstudiante = "Gonzales suarez y eloy alfaro casa #145." },
                new Direction { Id = 6, EstudianteId = 5, DireccionEstudiante = "via a la costa y eloy alfaro esquina." },
                new Direction { Id = 7, EstudianteId = 6, DireccionEstudiante = "loja y e parque, esquina." },
                new Direction { Id = 8, EstudianteId = 6, DireccionEstudiante = "villa de los angeles, lote #2." },
                new Direction { Id = 9, EstudianteId = 7, DireccionEstudiante = "mariscal sucre y villamil esquina." },
                new Direction { Id = 10, EstudianteId = 8, DireccionEstudiante = "las lajas, casa #234." },
                new Direction { Id = 11, EstudianteId = 9, DireccionEstudiante = "el valle de los chillos, casa #235." },
                new Direction { Id = 12, EstudianteId = 10, DireccionEstudiante = "parque minicipal de cali, esquina #24." },
                new Direction { Id = 13, EstudianteId = 11, DireccionEstudiante = "10 de agosto y almagro, edificio el sol, departamento #456." },
                new Direction { Id = 14, EstudianteId = 12, DireccionEstudiante = "9 de octubre y 10 de agisto, esquina." },
                new Direction { Id = 15, EstudianteId = 13, DireccionEstudiante = "el quinche, km 3, casa #23." },
                new Direction { Id = 16, EstudianteId = 14, DireccionEstudiante = "san juan y portete, esquina." },
                new Direction { Id = 17, EstudianteId = 15, DireccionEstudiante = "las lajas y 12 de octubre, esquina." }
            };
        }
    }
}

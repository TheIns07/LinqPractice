using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQPractice.Models
{
    public class Direction
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public string DireccionEstudiante { get; set; }
    }
}

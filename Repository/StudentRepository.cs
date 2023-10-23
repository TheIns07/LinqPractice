using LinQPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQPractice.Repository
{
    public class StudentRepository
    {
        public List<Estudiante> getStudents()
        {
            List<Estudiante> Estudiantes = new List<Estudiante>
            {
                new Estudiante{ Id = 1, Name = "Juan Perez", Class = "Programación", Nota1 = 10, Nota2 = 6.5, Nota3 = 5.7},
                new Estudiante{ Id = 2, Name = "Carlos Velez",Class = "Matemáticas",  Nota1 = 5, Nota2 = 7.8, Nota3 = 9},
                new Estudiante{ Id = 3, Name = "Jhoana Jimenez",Class = "Programación",  Nota1 = 3.5, Nota2 = 4.9, Nota3 = 8.5},
                new Estudiante{ Id = 4, Name = "Roberta Sanchez",Class = "Matemáticas",  Nota1 = 4.8, Nota2 = 9.8, Nota3 = 8.2},
                new Estudiante{ Id = 5, Name = "Bryan Armas",Class = "Física",  Nota1 = 9.8, Nota2 = 6.2, Nota3 = 1.6},
                new Estudiante{ Id = 6, Name = "Alejandra Gaybor",Class = "Matemáticas",  Nota1 = 4.9, Nota2 = 7.9, Nota3 = 7.9},
                new Estudiante{ Id = 7, Name = "Adriana Paz",Class = "Química",  Nota1 = 7.8, Nota2 = 4.6, Nota3 = 7.5},
                new Estudiante{ Id = 8, Name = "Carlos Fuentes",Class = "Física",  Nota1 = 9, Nota2 = 9.7, Nota3 = 3.2},
                new Estudiante{ Id = 9, Name = "David Correa",Class = "Programación",  Nota1 = 8.9, Nota2 = 10, Nota3 = 8.8},
                new Estudiante{ Id = 10, Name = "Juana Quiñonez",Class = "Programación",  Nota1 = 4.2, Nota2 = 8.8, Nota3 = 3.4},
                new Estudiante{ Id = 11, Name = "Edgar Morales",Class = "Matemáticas",  Nota1 = 6.7, Nota2 = 8.2, Nota3 =4.9},
                new Estudiante{ Id = 12, Name = "Ramon Mejia",Class = "Química",  Nota1 = 5.5, Nota2 = 7.9, Nota3 = 9.9},
                new Estudiante{ Id = 13, Name = "Belquior Borja",Class = "Física",  Nota1 = 7.4, Nota2 = 6.6, Nota3 = 5.1},
                new Estudiante{ Id = 14, Name = "Alexander Molina",Class = "Matemáticas",  Nota1 = 2.6, Nota2 = 4.5, Nota3 = 4.5},
                new Estudiante{ Id = 15, Name = "Johnny Vargas",Class = "Física",  Nota1 = 7, Nota2 = 5.9, Nota3 = 5.2}
            };
            return Estudiantes;
        }
    }
}

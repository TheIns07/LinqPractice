using LinQPractice.Models;
using LinQPractice.Repository;
using System.Linq;

namespace LinqPractice;

class Program
{
    public static void Main(string[] args)
    {
        List<Estudiante> listStudents = new StudentRepository().getStudents();

        //Select
        var resultado = listStudents.Select(student => new { student.Id, student.Name, student.Nota1, student.Nota2, student.Nota3 }).ToList();
        
        /*foreach (var resultados in resultado)
        {
            Console.WriteLine(resultados.Id + resultados.Name + resultados.Nota1 + resultados.Nota2);

        }*/

        //Where
        var resultadoWhere = listStudents.Where(student => student.Class == "Programación" && student.Nota3 >= 6).ToList();

        foreach (var resultados in resultadoWhere)
        {
            Console.WriteLine(resultados.Id + " "+ resultados.Name  + " " + resultados.Nota3 + " " + resultados.Class);

        }
        Console.ReadLine();

        //SelectMany
        var resultadoSEM = listStudents.SelectMany(x => x.Name);
        foreach (var resultados in resultadoSEM)
        {
            Console.WriteLine($"{resultados}");

        }
        Console.ReadLine();

        //Sum,Max,Min,Avg

        Console.WriteLine("Sum: " + listStudents.Select(x => x.Nota2).Sum());
        Console.ReadLine();

        Console.WriteLine("Min: " + listStudents.Select(x => x.Nota2).Min());
        Console.ReadLine();

        Console.WriteLine("Max: " + listStudents.Select(x => x.Nota2).Max());
        Console.ReadLine();

        var firstList = listStudents.Select(x => x.Nota2).Average();
        Console.WriteLine("Average: "+ firstList);
        Console.ReadLine();

        //Agregate 
        var secondList = listStudents.Select(x => x.Nota2).Aggregate((numero1, numero2) => numero1 + numero2);
        Console.WriteLine("Agregate: "+ secondList);
        Console.ReadLine();

        //Join 
        var students =  new StudentRepository().getStudents();
        var directions = new DirectionRepository().GetDirections(); 

        

        var itemsMixed = students.Join(directions, est => est.Id, dir => dir.Id, (est, dir) => new { dir, est })
            .Where(x=> x.est.Name == "Johnny Vargas");

        foreach(var item in itemsMixed)
        {
            Console.WriteLine($"{item.est.Id}" + $"{item.est.Name}" + $"{item.dir.DireccionEstudiante}");
        }
        Console.ReadLine();

        //Take
        var take = directions.Take(5);
        var takeWhile = students.TakeWhile(z => z.Nota1 >= 8.7).ToList();

        foreach (var item in take)
        {
            Console.WriteLine("Take: " +$"{item.DireccionEstudiante}");
        }
        Console.ReadLine();
        foreach (var item in takeWhile)
        {
            Console.WriteLine("TakeWhile: " + $"{item.Name}");
        }
        Console.ReadLine();

        //Skip
        var skip = directions.Skip(5);
        var skipWhile = students.SkipWhile(z => z.Nota1 >= 4).ToList();

        foreach (var item in skip)
        {
            Console.WriteLine("Skip: " + $"{item.DireccionEstudiante}");
        }
        Console.ReadLine();
        foreach (var item in skipWhile)
        {
            Console.WriteLine("SkipWhile: " + $"{item.Name}");
        }
        Console.ReadLine();

        //OfType
        var ofType = students.OfType<double>();

        foreach (var item in ofType)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();

        //Concat
        var concated = students.Concat(listStudents);

        //OrderBy, ThenBy and Reverse
        var ordered = skipWhile.OrderBy(x => x.Name).ThenBy(x => x.Nota2).Reverse().ToList();
        foreach (var item in ordered)
        {
            Console.WriteLine(item.Name + "  "+ item.Nota2);
        }
        Console.ReadLine();

        //GroupBy










    }
}
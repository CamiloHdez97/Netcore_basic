using System.Collections;

internal class Array2{


    public static void Main(string[] args){

    string ? palabra;

    ArrayList Materias = new ArrayList();

    Materias.Add("Calculo");
    Materias.Add("Español");
    Materias.Add("Dibujo técnico");
    Materias.Add("Ingles");

    Console.Write("Escriba una materia buscar:");
    palabra = Console.ReadLine();
    Console.WriteLine(Materias.Contains(palabra) ? $"La materia {Materias.Contains(palabra)} esta disponible" : "La materia no esta disponible");
            

    }


}
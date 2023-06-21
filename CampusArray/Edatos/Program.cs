using System.Collections;


internal class Array{


private static void Main (string[] args){
// See https://aka.ms/new-console-template for more information
        
        Console.WriteLine("Hello, World!");

        int[] edades = {12,13,24,21};

        Console.WriteLine($"EL ultimo item: {edades[edades.Length -1]}");

        foreach (int edad in edades){

            Console.WriteLine($"{edad}");

        }


        ArrayList myAl = new ArrayList();

        myAl.Add("The");
        myAl.Add("quick");
        myAl.Add("brown");
        myAl.Add("fox");

        foreach (Object n in myAl){

            Console.WriteLine(n.ToString());
        
        }

    }

    private static void Especie(string[] args){

        ArrayList Carnivoros = new ArrayList();
        ArrayList Acuaticos = new ArrayList();
        ArrayList Animales = new ArrayList();

        Carnivoros.Add("Triger");
        Carnivoros.Add("Leon");
        Carnivoros.Add("Pantera");
        Carnivoros.Add("Leopardo");
        Acuaticos.Add("Tiburon");
        Acuaticos.Add("Delfin");
        Acuaticos.Add("Ballena");
        Acuaticos.Add("Pulpo");

        Animales.AddRange(Carnivoros);
        Animales.AddRange(Acuaticos);

        foreach(Object animal in Animales){

            Console.WriteLine(animal.ToString());

        }

        Animales.Clear();


    }
    
}
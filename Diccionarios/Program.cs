internal class Program{

    public static void Main(string[] args){

        //Listas

        List<string> myLista = new List<string>();
        myLista.Add("item1");
        myLista.Add("item2");
        Console.WriteLine("Elementos de la lista: {0}",myLista.Count);
        Console.WriteLine("Elemento posición 2 con vectores {0}", myLista[1]);

        foreach(String str in myLista){

            Console.WriteLine(str);
            
        }

        string[] Dinos = {
            "Brachiosaurus",
            "Amargasaurus",
            "Mamenchisaurus"
        };

        //Inserta al final la los items dino
        myLista.AddRange(Dinos);

        //Buscar1
        string ? palabra = Console.ReadLine();
        Console.WriteLine(myLista.Exists(item => item.Equals(palabra)) ? "Se encontro el item" : "No se encontro el Item");

        //Buscar2
        string ? nombre = myLista.Find(n => n.StartsWith(palabra ?? String.Empty));

        //Diccionarios
        Dictionary<int, string> Frutas = new Dictionary<int, string>();
        Dictionary<int, string> Automoviles = new Dictionary<int, string>();
        Dictionary<int, string> Productos = new Dictionary<int, string>();

        Frutas.Add(1,"Manzana");
        Frutas.Add(2,"Pera");
        Automoviles.Add(1,"Auto");
        Automoviles.Add(2,"Moto");
        Productos.Add(1,"Cartera");
        Productos.Add(2,"Relog");

        //Validar si ya existe la llave:
        try{

            Frutas.Add(1,"Manzana");

        }catch(ArgumentException){

            Console.WriteLine("Un elemento con la llave = \"txt\" Ya existe.");

        }

        Console.WriteLine("El total de frutas {0}", Frutas.Count);
        Console.WriteLine("El total de Automoviles {0}", Automoviles.Count);
        Console.WriteLine("El total de Productos {0}", Productos.Count);

    }

}
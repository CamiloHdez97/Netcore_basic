using System;
using System.Collections;

/*
internal class Producto{

    private string name;
    private decimal precio;
    private int cantidad;

    public Producto(string name, decimal precio, int cantidad){

        this.name = name;
        this.precio = precio;
        this.cantidad = cantidad;

    }

    public string ObtenerNombre(){

        return this.name;

    }

    public decimal ObtenerPrecio(){

        return this.precio;

    }

    public int ObtenerCantidad(){

        return this.cantidad;

    }

}

partial class Program{

    static ArrayList listaArray = new ArrayList();

    static void Main(){

        bool flag = false;
        
        do{

            Console.WriteLine("\n----------Menu----------\n");
            Console.WriteLine("1. Registrar un producto ");
            Console.WriteLine("2. BUscar un producto ");
            Console.WriteLine("3. Mostrar un producto ");
            Console.WriteLine("4. Salir...");            
            Console.WriteLine("Ingrese una opción.");
            string opción = Console.ReadLine();

            switch(opc){

                case "1":
                    RegistroProducto();
                    break;
                case "2":
                    BuscarProducto();
                    break;
                case "3":
                    MostrarProducto();
                    break;
                case "4":
                    opc = true;
                    break;
                default:
                    Console.WriteLine("Opción Invalido.");
                    break;
            }

        }
        
        while (!flag);

    }
    static void RegistroProducto(){

        Console.WriteLine("Registro Producto");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el precio del producto.");
        decimal precio = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad");
        int cantidad = int.Parse(Console.ReadLine());

        Producto nuevoProducto = new Producto(nombre,precio,cantidad);
        listaProductos.Add(nuevoProducto);

        Console.WriteLine("Registro Exitoso");

    }

    static void BuscarProducto(string nombre, string precio, int cantidad){

        Console.WriteLine("Ingrese el nombre del Producto a buscar");
        string nombreBusqueda = Console.ReadLine();

        Producto nuevoEncontrado = null;
        foreach(Producto producto in listaProducto){

            if(producto.ObtenerNombre() == nombreBusqueda) {

                productoEncontrado = producto;
                break;

            }
        }

        if (productoEncontrado != null){

            Console.WriteLine($"Producto encontrado: {productoEncontrado.ObtenerNombre()}");
            Console.WriteLine("");
            Console.WriteLine("");

        }

    }


}
 */
internal class Program{

    private static void Main(string[] args) {

        String ? palabra;
        List<String> Dinosaurios = new List<String>();
        string[] Dinos = {
            "Branchisaurus",
            "Amargasaurus",
            "Mamenchisaurus"
        };

        Dinosaurios.AddRange(Dinos);
        Console.WriteLine("Ingrese el nombre del Dinosaurio a buscar");
        palabra = Console.ReadLine();
        Console.WriteLine(Dinosaurios.Exists(item => item.Equals(palabra)) ? "Se encontro el dinosaurio" : "No se encontro el dinosaurio");
        Console.WriteLine(String.Join(",",Dinosaurios));
        //Console.WriteLine(typeof(Dinosaurios));

    }

}
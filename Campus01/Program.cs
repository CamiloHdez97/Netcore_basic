internal class Program

{
    private static void Main(string[] args)
    {

        //[Modificador de Acceso] tipo Identificador;
        int edad =0;

        string ? nombre;

        string apellido = String.Empty;

        const double iva = 1.0;

        bool estado = false;

    try{

        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine() ?? String.Empty;
  
        Console.WriteLine("{0} Ingrese su apellido", nombre.ToUpper());
        apellido = Console.ReadLine() ?? String.Empty;

        bool estadoE = false;
        
        do{
            try{
            Console.WriteLine($"{nombre} {apellido} Ingrese su edad: ");
            edad = Convert.ToInt16(Console.ReadLine());
            estadoE = true;

            }catch(IOException ex){
                estadoE = true;
                Console.WriteLine($"{ex}, La cacilla no puede estar vacia");
                //bool flag = Convert.ToBoolean(Console.ReadLine());
                //Console.WriteLine(flag);
                //Console.WriteLine(Convert.ToBoolean(Console.ReadLine()));
                //Pausa en el codigo, esperando una pulsación.
                Console.ReadKey();

                //
                for(int i = 0; i <= 3;i++){

                    Console.Beep();

                }
                estadoE = false;
            }

        }while(estadoE==false);


        if(edad >= 1 && edad <=11){
            
            Console.WriteLine($"{nombre} {apellido} Es un niño.");

        }else if(edad > 11 && edad <=17){
            
            Console.WriteLine($"{nombre} {apellido} Es un adolescente.");
        
        }else if(edad > 17 && edad <=59){
            
            Console.WriteLine($"{nombre} {apellido} Es un Adulto.");
        
        }else{
            
            Console.WriteLine($"{nombre} {apellido} Es un Adulto Mayor.");
        
        }

        Console.WriteLine($"{nombre} {apellido} Ingrese su dirección");
        

        Console.WriteLine(estado ? "Ok" : "No");

    }catch(IOException ex){

        Console.WriteLine("Error al momento de ingresar el dato",ex.Message);
        Console.ReadLine();

    }

/*         Console.WriteLine("Hello, World!");
        Console.Write("2023");
        Console.Write(Console.ReadKey().Key); */
    }

}
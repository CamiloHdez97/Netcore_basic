class Sub20{

    public static void Main(string[] args){

        bool flag = true;
        int option = 0;

        try
        
        {
        
            do{
                
                Console.WriteLine("Ingrese una opción: \n  1. Registrar equipo.\n  2. Registrar Fecha\n  3. Mostrar Estadísticas");
                option = Convert.ToInt32(Console.ReadLine());

                switch(option){

                    case 1:

                        bool fgl_one = true;
                        Console.Clear();
                        
                        Console.WriteLine("REGISTRO EQUIPO:\n");
                        
                        Console.WriteLine("Ingrese el País:");
                        string ? paisIO = Console.ReadLine();
                        
                        Console.WriteLine("Grupo del país:");
                        string ? grupoIO = Console.ReadLine();

                        Console.WriteLine("Ingrese una opción: \n  1. Registrar Jugadores.\n  2. Registrar Cuerpo Técnico\n  3. Registrar Cuerpo Médico.");
                        int ? option_addJ = Convert.ToInt32(Console.ReadLine());

                        switch(option_addJ){

                            case 1: 
                                bool fgl_J = true;
                                do{
                                    
                                    Console.Clear();
                                    
                                    Console.WriteLine($"REGISTRO JUGADORES ({paisIO}):\n");
                                    
                                    Console.WriteLine("Ingrese el nombre del jugador:");            
                                    string ? nombreJIO = Console.ReadLine();            
                                    
                                    Console.WriteLine("Ingrese el apellido del jugador:");
                                    string ? apellidoIO = Console.ReadLine();

                                    Console.WriteLine("Dorsal:");
                                    string ? dorsalIO = Console.ReadLine();

                                    Console.WriteLine("Posición de Juego:");
                                    string ? poscicionIO = Console.ReadLine();

                                    Console.WriteLine("Ingrese la edad:");
                                    string ? edadIO = Console.ReadLine();

                                    if(Convert.ToInt32(edadIO) == 20){

                                        Console.Clear();
                                        Console.WriteLine("Registro exitoso.");
                                        Console.WriteLine("Registrar otro jugador Y/N:");

                                        string ? continueJ = Console.ReadLine()?.ToUpper();
                                        fgl_J = continueJ == "Y" ? true : false;
                                        Console.WriteLine($"valor fgl_one: {fgl_one}");

                                    }else{

                                        Console.Clear();
                                        Console.WriteLine($"{nombreJIO} {apellidoIO} No cumple con el requisito de edad = 20.");

                                    }

                                }while(fgl_J);
                                break;

                            case 2: 

                                bool fgl_ct = true;

                                do{
                                        
                                        Console.Clear();
                                        
                                        Console.WriteLine($"REGISTRO CUERPO TÉCNICO ({paisIO}):\n");
                                        
                                        Console.WriteLine("Ingrese el nombre:");            
                                        string ? nombreJIO = Console.ReadLine();            
                                        
                                        Console.WriteLine("Ingrese el cargo:");
                                        string ? apellidoIO = Console.ReadLine();

                                        Console.WriteLine("Ingrese la edad:");
                                        string ? edadIO = Console.ReadLine();


                                        Console.Clear();
                                        Console.WriteLine("Registro exitoso.");
                                        Console.WriteLine("Registrar otro CT Y/N:");

                                        string ? continueCT = Console.ReadLine()?.ToUpper();
                                        fgl_ct = continueCT == "Y" ? true : false;
                                        Console.WriteLine($"valor fgl_one: {fgl_ct}");

                                    }while(fgl_ct);

                                break;

                        }

                        break;

                    case 2:

                    

                        break;

                    case 3:

                        break;

                    default:
                        flag = false;
                        break;

                }
        
            }
        
            while(!flag);

            Console.WriteLine("Ejecución Finalizada.");
        
        }

        catch (System.Exception){
            
            throw;

        }
    
    }

}
Console.WriteLine(@"
     ___      .______    __    __   _______      _______..___________.     ___         .______        ______   ____    ____      ___       __       _______ 
    /   \     |   _  \  |  |  |  | |   ____|    /       ||           |    /   \        |   _  \      /  __  \  \   \  /   /     /   \     |  |     |   ____|
   /  ^  \    |  |_)  | |  |  |  | |  |__      |   (----``---|  |----`   /  ^  \       |  |_)  |    |  |  |  |  \   \/   /     /  ^  \    |  |     |  |__   
  /  /_\  \   |   ___/  |  |  |  | |   __|      \   \        |  |       /  /_\  \      |      /     |  |  |  |   \_    _/     /  /_\  \   |  |     |   __|  
 /  _____  \  |  |      |  `--'  | |  |____ .----)   |       |  |      /  _____  \     |  |\  \----.|  `--'  |     |  |      /  _____  \  |  `----.|  |____ 
/__/     \__\ | _|       \______/  |_______||_______/        |__|     /__/     \__\    | _| `._____| \______/      |__|     /__/     \__\ |_______||_______|
                                                                                                                                                            ");

Console.WriteLine("===================================================================================================================================");

int money;
string name;
int validat;
int beis;

Console.WriteLine("Ingresa tu nombre");
Console.WriteLine();
name = Console.ReadLine();


if (!string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Epa ludopata, " + name + "!");

    Console.WriteLine("Cuanto dinero tiene para regalar");
    money = Convert.ToInt32(Console.ReadLine());
        
        
        
        //Console.ReadLine("");


    if (money >= 100)
    {
        Console.Clear();
        Console.WriteLine("MANO MEJOR INVIERTE EN OTRA COSA QUE NO SEA AQUI!!");
        Console.WriteLine(money);


    }
    else if (money > 1)
    {
        Console.Clear();
        Console.WriteLine("Apuesta mi loca");
        Console.WriteLine(money);

        Console.WriteLine("SELECCIONA DONDE QUIERE APOSTAR");

        Console.WriteLine("=====================================");

        Console.WriteLine("1 \tBEISBOL VENEZOLANO");
        Console.WriteLine("2 \tFUTBOL SHAOLIN");
        Console.WriteLine("3 \tESPECIAL");
        Console.WriteLine("4 \tMEJOR OPCION IRSE");

        int select;
        select = Convert.ToInt32(Console.ReadLine());


        if (select == 1)
        {
            Console.Clear();
            Console.WriteLine("DISPONIBLE LOS TIGRE DE ARAGUA VS LEONES DE CARACA");

            Console.WriteLine();
            Console.WriteLine("Quiere apostar");
            Console.WriteLine("1.SI QUIERO");
            Console.WriteLine("2.NO QUIERO");
            validat = Convert.ToInt32(Console.ReadLine());

            if (validat == 1)
            {
                Console.Clear();

                Console.WriteLine("SELECCIONA EL EQUIPO");
                Console.WriteLine("1 \tTIGRE DE ARAGUA ");
                Console.WriteLine("2 \tLEONE DE CARACA");
                beis = Convert.ToInt32(Console.ReadLine());

                if (beis == 1)
                {
                    Console.WriteLine("ERES DE LOS TIGRES DE ARAGUA");

                    Batear(); // Ejecuta el juego de bateo
                    int resultadoFinal = MostrarResultadoFinal(); 

                    if (resultadoFinal == 1)
                    {
                        Console.WriteLine("¡Felicidades, ganaste la apuesta!");
                    }
                    else if (resultadoFinal == 0)
                    {
                        Console.WriteLine("Perdiste la apuesta, ¡mejor suerte la próxima vez!");
                    }
                    else
                    {
                        Console.WriteLine("¡La partida terminó en empate!");
                    }
                }

                else if(beis == 2)
                {
                    Console.WriteLine("ERES DE LOS LEONES DE CARACA");

                    Batear(); // Ejecuta el juego de bateo
                    int resultadoFinal = MostrarResultadoFinal(); 

                    if (resultadoFinal == 1)
                    {
                        Console.WriteLine("¡Felicidades, ganaste la apuesta!");
                    }
                    else if (resultadoFinal == 0)
                    {
                        Console.WriteLine("Perdiste la apuesta, ¡mejor suerte la próxima vez!");
                    }
                    else
                    {
                        Console.WriteLine("¡La partida terminó en empate!");
                    }
                }


               // Console.WriteLine("PERDISTE MANO");
            }
            else
            {
                Console.WriteLine("MEJOR OPCION WEON");
                Console.Clear();
                
            }
        }

        else if (select == 2)
        {
            Console.Clear();
            Console.WriteLine("DISPONIBLE BARCELONA VS REAL MADRID");

        }

        else if (select == 3)
        {
            Console.Clear();
            Console.WriteLine("CABALLO");


            Console.WriteLine();
            Console.WriteLine("Quiere apostar");
            Console.WriteLine("1.SI QUIERO");
            Console.WriteLine("2.NO QUIERO");
            validat = Convert.ToInt32(Console.ReadLine());

            if (validat == 1)
            {
                Console.Clear();
                Console.WriteLine("¿A qué caballo quieres apostar?");
                Console.WriteLine("1. Caballo 1");
                Console.WriteLine("2. Caballo 2");
                Console.WriteLine("3. Caballo 3");
                Console.Write("Selecciona el número del caballo: ");
                int apuesta = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Apostaste por el Caballo " + apuesta);
                Console.WriteLine("\nPresiona una tecla para comenzar la carrera...");
                Console.ReadKey();

                int ganador = CarreraCaballos(); // Ejecuta la carrera

                if (ganador + 1 == apuesta)
                {
                    Console.WriteLine("\n🎉 ¡Felicidades! Ganaste la apuesta. 🤑");
                }
                else
                {
                    Console.WriteLine("\n💸 PERDISTE LA APUESTA, MANO 😢");
                }
            }

            else
            {
                Console.WriteLine("MEJOR OPCION WEON");
                Console.Clear();

            }


        }

    }
    else
    {
        Console.WriteLine("NO PAPI ESTA PELANDO BOLA");
    }


}
else
{
    Console.WriteLine("no ingreso su nombre, reinicie la aplicacion, presione cualquier letra");
    Console.ReadKey();
}




static int CarreraCaballos()
{
    const int trackLength = 50;
    string[] horses = { "Caballo 1", "Caballo 2", "Caballo 3" };
    int[] positions = new int[horses.Length];
    Random rand = new Random();
    bool raceOver = false;

    while (!raceOver)
    {
        Console.Clear();
        Console.WriteLine("🏁 ¡La carrera ha comenzado! 🏁\n");

        for (int i = 0; i < horses.Length; i++)
        {
            positions[i] += rand.Next(1, 4);

            if (positions[i] >= trackLength)
            {
                positions[i] = trackLength;
                raceOver = true;
            }

            Console.Write(horses[i].PadRight(10) + " |");
            Console.Write(new string('-', positions[i]) + "-(o_o)>"); // Caballito de texto
            Console.WriteLine();
        }

        Thread.Sleep(200);
    }

    int ganador = Array.IndexOf(positions, trackLength);
    Console.WriteLine($"\n🎉 ¡{horses[ganador]} ha ganado la carrera!");

    return ganador; // Devuelve el índice del caballo ganador (0, 1 o 2)
}


static void Batear()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    int totalCarrerasTigres = 0;
    int totalCarrerasLeones = 0;

    for (int inning = 1; inning <= 3; inning++)
    {
        Console.WriteLine($"--- ENTRADA {inning} ---");
        Console.WriteLine("Presiona una tecla para batear...");
        Console.ReadKey(true);

        Random rand = new Random();
        int resultadoTigres = rand.Next(1, 5); // Resultado para Tigres de Aragua
        int resultadoLeones = rand.Next(1, 5); // Resultado para Leones de Caracas

        Console.Clear();
        Console.WriteLine("¡Swing!");
        Thread.Sleep(1000);

        // Tigres de Aragua
        int carrerasTigres = SimularJugada(resultadoTigres);
        totalCarrerasTigres += carrerasTigres;

        // Leones de Caracas
        int carrerasLeones = SimularJugada(resultadoLeones);
        totalCarrerasLeones += carrerasLeones;

        // Muestra las carreras de cada equipo
        Console.Clear();
        Console.WriteLine($"Tigres de Aragua: {totalCarrerasTigres} | Leones de Caracas: {totalCarrerasLeones}");
        Console.WriteLine("Presiona una tecla para continuar...");
        Console.ReadKey(true);
        Console.Clear();
    }
}

static int SimularJugada(int resultado)
{
    string jugada = "";
    int avanceBases = 0;
    int carreras = 0;

    if (resultado == 1) { jugada = "Hit sencillo"; avanceBases = 1; }
    else if (resultado == 2) { jugada = "Doble"; avanceBases = 2; }
    else if (resultado == 3) { jugada = "Triple"; avanceBases = 3; }
    else if (resultado == 4) { jugada = "¡Home run!"; avanceBases = 4; carreras = 1; }

    Console.WriteLine($"Resultado: {jugada}");
    Thread.Sleep(1000);

    for (int i = 0; i <= Math.Min(avanceBases, 4); i++)
    {
        Console.Clear();
        Console.WriteLine("       [2B]");
        Console.WriteLine("        |");
        Console.WriteLine("   [3B]- + -[1B]");
        Console.WriteLine("        |");
        Console.WriteLine("       [Home]");

        switch (i)
        {
            case 1: Console.WriteLine("\nCorredor → 1B"); break;
            case 2: Console.WriteLine("\nCorredor → 2B"); break;
            case 3: Console.WriteLine("\nCorredor → 3B"); break;
            case 4: Console.WriteLine("\nCorredor → ¡Home!"); break;
            default: Console.WriteLine("\nSin corredores."); break;
        }

        Thread.Sleep(700);
    }

    if (carreras == 1)
        Console.WriteLine("\n🏃‍♂️ El corredor anota una carrera!!!");

    return carreras;
}

static int MostrarResultadoFinal()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("¡RESULTADO FINAL!");
    Console.WriteLine("************************************");
    Console.WriteLine("⚾ Tigres de Aragua vs Leones de Caracas ⚾");
    Console.WriteLine("************************************");

    // Simula el resultado final
    Random rand = new Random();
    int totalCarrerasTigres = rand.Next(0, 10); // Carreras aleatorias para Tigres
    int totalCarrerasLeones = rand.Next(0, 10); // Carreras aleatorias para Leones

    Console.WriteLine($"Tigres de Aragua: {totalCarrerasTigres}");
    Console.WriteLine($"Leones de Caracas: {totalCarrerasLeones}");

    // Determina el ganador
    if (totalCarrerasTigres > totalCarrerasLeones)
    {
        Console.WriteLine("¡TIGRES DE ARAGUA GANAN!");
        return 1; // El jugador gana si apostó por Tigres y ellos ganaron
    }
    else if (totalCarrerasLeones > totalCarrerasTigres)
    {
        Console.WriteLine("¡LEONES DE CARACAS GANAN!");
        return 0; // El jugador pierde si apostó por Tigres y los Leones ganaron
    }
    else
    {
        Console.WriteLine("¡EMPATE!");
        return -1; // Empate
    }
    
    Console.WriteLine("************************************");
    Console.WriteLine("¡Gracias por jugar!");
    Console.WriteLine("************************************");

    // Pausa para mostrar el cartel
    Console.ReadKey(true);
}

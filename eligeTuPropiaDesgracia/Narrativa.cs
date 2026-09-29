public class Narrativa
{
    int dia = 0;
    string[] dias;
    string[] narrativas;
    string[][] decisiones;
    string[][] resultados;

    string[][] consecuencias;

    string[] intro;

    public Narrativa(String[] narrt, String[][] decs, String[][] resp, String[] ntr, String[] dias_, String[][] consecuencias_ )
    {
        narrativas = narrt;
        decisiones = decs;
        resultados = resp;
        intro = ntr;
        consecuencias = consecuencias_;
        dias = dias_;
    }

    public void mostrarIntro()
    {
        foreach (string txt in intro)
        {
            Console.WriteLine(txt);
        }
    }


    public void diaActual(Jugador player)
    {
        Console.Clear();

        Console.WriteLine(dias[dia]);
        Console.WriteLine("======================================");
        Console.WriteLine();

        Console.WriteLine(narrativas[dia]);
        Console.WriteLine("======================================");
        Console.WriteLine();

        Console.WriteLine("¿Qué quieres hacer?");
        Console.WriteLine();
        for (int opcion = 0; opcion < 4; opcion++)
            {
                Console.WriteLine(decisiones[dia][opcion]);
            }
        
         Console.WriteLine();
            Console.Write("Elige A, B, C o D: ");

            string eleccion = Console.ReadLine().ToUpper();

            while (eleccion != "A" &&
                   eleccion != "B" &&
                   eleccion != "C" &&
                   eleccion != "D")
            {
                Console.Write("Opción inválida. Elige A, B, C o D: ");
                eleccion = Console.ReadLine().ToUpper();
            }

            int indice = 0;

            if (eleccion == "A")
            {
                indice = 0;
            }
            else if (eleccion == "B")
            {
                indice = 1;
            }
            else if (eleccion == "C")
            {
                indice = 2;
            }
            else if (eleccion == "D")
            {
                indice = 3;
            }

            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("RESULTADO");
            Console.WriteLine("======================================");
            Console.WriteLine();

            Console.WriteLine(resultados[dia][indice]);
            afectarJugador(player, consecuencias[dia][indice] );

            Console.WriteLine();
            Console.WriteLine("Presiona ENTER para continuar...");
            Console.ReadLine();
            dia++;
    }

    private void afectarJugador(Jugador player, String afectacion)
    {
        string propiedad = afectacion.Split(':')[0];
        int valor = int.Parse(afectacion.Split(':')[1]);


        if(propiedad == "energia")
        {
            player.energia = player.energia + valor;
        }
       else if(propiedad == "hambre")
        {
            player.hambre = player.hambre + valor;
        }
        else if(propiedad == "dinero")
        {
            player.dinero = player.dinero + valor;
        }
        
       Console.WriteLine($" Dinero: ${player.dinero}");
       Console.WriteLine($" Energía: {player.energia}");
       Console.WriteLine($" Hambre: {player.hambre}");

    }






}
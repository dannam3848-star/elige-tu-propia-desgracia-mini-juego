public class Program
{

    public static void Main()
    {   
        Narrativa profesionPato = new Narrativa(Pato.Narraciones, Pato.Decisiones, Pato.resultados, Pato.intro, Pato.Dias, Pato.Consecuencias);
        
       // Narrativa profesionPeces = new Narrativa(Peces.Narraciones, Peces.Decisiones, Peces.resultados, Peces.intro, Peces.Dias);

        //Narrativa profesionRepartidor = new Narrativa(Repartidor.Narraciones, Repartidor.Decisiones, Repartidor.resultados, Repartidor.intro, Repartidor.Dias);

        //Narrativa profesionPaloma = new Narrativa(Paloma.Narraciones, Paloma.Decisiones, Paloma.resultados, Paloma.intro, Paloma.Dias);
                
      //Narrativa profesionPlanta = new Narrativa(Planta.Narraciones, Planta.Decisiones, Planta.resultados, Planta.intro, Planta.Dias);
                  
                  
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();

        string rol = trabajos();

        Jugador player = new Jugador(nombre, rol);
        player.mostrarPersoanje();

        for (int i =0; i<7 ; i++){

            if (rol == "guardia de pato presidencial")
            {
                profesionPato.mostrarIntro();
                profesionPato.diaActual(player);
            }
            /* else if (rol == "traductor de peces")
            {
                profesionPeces.mostrarIntro();
                profesionPeces.diaActual(player);
            }
            else if (rol == "repartidor")
            {
                profesionRepartidor.mostrarIntro();
                profesionRepartidor.diaActual(player);
            }
            else if (rol == "Entrenador de paloma")
            {
                profesionPaloma.mostrarIntro();
                profesionPaloma.diaActual(player);
            }
            else 
            {
                profesionPlanta.mostrarIntro();
                profesionPlanta.diaActual(player);
            }*/

            //visualizar estado jugador

            //preguntar si continua o renuncia
        }

    }

    public static string trabajos()
    {
        Console.Write("Escoge tu herramienta: ");
        Console.Write("pistola");
        Console.Write("diccionario");
        Console.Write("alpiste");
        Console.Write("Etiquedador");
        Console.Write("regadera");
        string herramienta = Console.ReadLine();

        string rol;

        if (herramienta == "pistola")
            rol = "guardia de pato presidencial";
        else if (herramienta == "diccionario")
            rol = "traductor de peces";
        else if (herramienta == "alpiste")
            rol = "entrenador de palomas";
        else if (herramienta == "etiquetador")
            rol = "Repartidor de paquetes";
        else
            rol = "cuidador de plantas";

        return rol;
    }
}

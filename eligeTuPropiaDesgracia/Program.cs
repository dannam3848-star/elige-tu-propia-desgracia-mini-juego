public class Program
{
    public static void Main()
    {   
        Narrativa profesionPato = new Narrativa(Pato.Narraciones, Pato.Decisiones, Pato.resultados, Pato.intro, Pato.Dias);

                  
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();

        string rol = trabajos();

        Jugador player = new Jugador(nombre, rol);
        player.mostrarPersoanje();

        for (int i =0; i<7 ; i++){

            if (rol == "guardia de pato presidencial")
            {
                profesionPato.mostrarIntro();
                profesionPato.diaActual();
            }
            else if (rol == "cuidador de plantas")
            {
                //RutaPlantas();
            }

            //visualizar estado jugador

            //preguntar si continua o renuncia
        }

    }

    public static string trabajos()
    {
        Console.Write("Escoge tu herramienta: ");
        string herramienta = Console.ReadLine();

        string rol;

        if (herramienta == "pistola")
            rol = "guardia de pato presidencial";
        else if (herramienta == "diccionario")
            rol = "traductor de peces";
        else if (herramienta == "alpiste")
            rol = "entrenador de palomas";
        else if (herramienta == "pistola de etiquetar")
            rol = "Repartidor de paquetes";
        else
            rol = "cuidador de plantas";

        return rol;
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();

        string rol = trabajos();

        Jugador player = new Jugador(nombre, rol);
        player.mostrarPersoanje();

        if (rol == "guardia de pato presidencial")
        {
            Narrativa profesionPato = new Narrativa(Pato.Narraciones, Pato.Decisiones, Pato.resultados, Pato.intro);
        }
        else if (rol == "cuidador de plantas")
        {
            //RutaPlantas();
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

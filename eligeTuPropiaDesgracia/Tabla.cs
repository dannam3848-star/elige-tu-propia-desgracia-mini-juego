public static void AplicarCambios(Jugador jugador, int cambioDinero, int cambioEnergia, int cambioHambre)
{
    jugador.dinero += cambioDinero;
    jugador.energia += cambioEnergia;
    jugador.hambre += cambioHambre;

    if (jugador.dinero < 0)
        jugador.dinero = 0;

    if (jugador.energia < 0)
        jugador.energia = 0;

    if (jugador.energia > 100)
        jugador.energia = 100;

    if (jugador.hambre < 0)
        jugador.hambre = 0;

    if (jugador.hambre > 100)
        jugador.hambre = 100;
}
public static string MostrarCambio(int cambio)
{
    if (cambio > 0)
        return "+" + cambio;

    return cambio.ToString();
}
public static void MostrarResumenDia(Jugador jugador, int dineroAntes, int energiaAntes, int hambreAntes)
{
    int cambioDinero = jugador.dinero - dineroAntes;
    int cambioEnergia = jugador.energia - energiaAntes;
    int cambioHambre = jugador.hambre - hambreAntes;

    Console.WriteLine();
    Console.WriteLine("========================================");
    Console.WriteLine("           RESUMEN DEL DÍA");
    Console.WriteLine("========================================");

    Console.WriteLine("              ANTES   CAMBIO   AHORA");

    Console.WriteLine($"Dinero        ${dineroAntes}     {MostrarCambio(cambioDinero)}       ${jugador.dinero}");
    Console.WriteLine($"Energía        {energiaAntes}     {MostrarCambio(cambioEnergia)}       {jugador.energia}");
    Console.WriteLine($"Hambre          {hambreAntes}     {MostrarCambio(cambioHambre)}       {jugador.hambre}");

    Console.WriteLine("========================================");
}
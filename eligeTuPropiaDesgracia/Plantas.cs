// =========================================================
    // RUTA DEL CUIDADOR DE PLANTAS
    // =========================================================

    public static void RutaPlantas()
    {
        Console.Clear();

        Console.WriteLine("======================================");
        Console.WriteLine(" CUIDADOR DE PLANTAS");
        Console.WriteLine("======================================");
        Console.WriteLine();
        Console.WriteLine("Has conseguido un trabajo cuidando un jardín.");
        Console.WriteLine("El dueño te advierte que algunas plantas son...");
        Console.WriteLine("bastante extrañas.");
        Console.WriteLine();

        Console.WriteLine("Presiona ENTER para comenzar...");
        Console.ReadLine();

        string[] dias =
        {
            "DÍA 1 — LAS PLANTAS",
            "DÍA 2 — EL PROBLEMA",
            "DÍA 3 — LA PLANTA MÁS RARA",
            "DÍA 4 — EL JARDÍN",
            "DÍA 5 — LAS PLANTAS QUIEREN ALGO",
            "DÍA 6 — LA INVASIÓN",
            "DÍA 7 — EL DUEÑO"
        };

        string[] narraciones =
        {
            "Llegas al jardín por primera vez. Hay plantas por todas partes y algunas tienen pequeños carteles de advertencia.",

            "Algo extraño sucede con las plantas. Varias parecen haberse movido durante la noche.",

            "Encuentras una planta que no se parece a ninguna otra. Su apariencia resulta bastante inquietante.",

            "El jardín necesita mantenimiento. El dueño te deja decidir cuánto tiempo quieres dedicarle al trabajo.",

            "Las plantas parecen necesitar algo más que agua. El problema es que nadie te dijo exactamente qué necesitan.",

            "Cuando llegas al jardín descubres que las plantas se han extendido por todas partes.",

            "El dueño finalmente regresa para comprobar cómo ha quedado el jardín."
        };

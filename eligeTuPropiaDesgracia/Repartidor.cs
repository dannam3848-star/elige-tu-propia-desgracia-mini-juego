public static void RutaRepartidor()
{
    Console.WriteLine("\n================================");
    Console.WriteLine(" RUTA — REPARTIDOR DE PAQUETES");
    Console.WriteLine("================================\n");

    Console.WriteLine("«Se busca repartidor de paquetes.»");
    Console.WriteLine("«No se requiere experiencia.»");
    Console.WriteLine("«Debe poder caminar, correr y cargar paquetes.»");
    Console.WriteLine("«Pago: $50 por hora.»\n");

    Console.WriteLine("Llegas a una pequeña oficina llena de cajas.");
    Console.WriteLine("Hay paquetes por todas partes.");
    Console.WriteLine("Algunos son pequeños.");
    Console.WriteLine("Otros son enormes.");
    Console.WriteLine("Uno parece estar respirando.\n");

    Console.WriteLine("El encargado te entrega una mochila y una lista.");
    Console.WriteLine("—Solo tienes que entregar los paquetes en las direcciones indicadas.");
    Console.WriteLine("—¿Y qué pasa si no puedo?");
    Console.WriteLine("—Entonces no los entregas.\n");

    Console.WriteLine("Te entrega el primer paquete.");
    Console.WriteLine("—Buena suerte.\n");

    string[] dias =
    {
        "DÍA 1 — TU PRIMER REPARTO",
        "DÍA 2 — EL PAQUETE PESADO",
        "DÍA 3 — EL PAQUETE QUE NO DEBERÍA EXISTIR",
        "DÍA 4 — EL EDIFICIO",
        "DÍA 5 — EL DÍA DE LAS ENTREGAS",
        "DÍA 6 — LA ENTREGA IMPOSIBLE",
        "DÍA 7 — EL ÚLTIMO PAQUETE"
    };

    string[] narraciones =
    {
        "Tu primera entrega parece sencilla.\n\nTienes tres paquetes y las direcciones están relativamente cerca.\n\nSales de la oficina.\n\nDespués de caminar unas cuadras, llegas al primer edificio.\n\nEntregas el paquete.\n\nTodo normal.\n\nEl segundo también.\n\nPero cuando llegas al tercero...\n\nNo encuentras el número de la casa.\n\nRevisas la dirección.\n\nLa vuelves a revisar.\n\nEl número existe.\n\nPero la casa no.",

        "Llegas temprano.\n\nEl encargado te señala una caja enorme.\n\n—Tienes que llevar esto al otro lado de la ciudad.\n\nMiras la caja.\n\n—¿Qué tiene?\n\n—No tengo idea.\n\nIntentas levantarla.\n\nPesa muchísimo.",

        "Tu jefe te entrega un paquete pequeño.\n\nLa dirección dice:\n\n«ENTREGAR EN EL MISMO LUGAR DONDE ESTÁS.»\n\nMiras alrededor.\n\nNo hay nadie.\n\nMiras el paquete.\n\nDespués miras nuevamente la dirección.",

        "Tu siguiente entrega es en un edificio enorme.\n\nTienes que subir al piso 30.\n\nEl ascensor tiene un cartel:\n\n«FUERA DE SERVICIO.»\n\nMiras las escaleras.\n\nSon muchas.\n\nDemasiadas.",

        "Tu jefe está desesperado.\n\n—Tenemos demasiados paquetes.\n\nTe muestra una montaña de cajas.\n\n—Necesito que entregues todas las que puedas.",

        "Al llegar al trabajo encuentras una dirección escrita en una hoja.\n\nLa lees.\n\nDespués la vuelves a leer.\n\nLa dirección está en medio de un parque.\n\nNo hay ninguna casa.\n\nNo hay ningún edificio.\n\nSolo árboles.\n\nTu jefe te entrega el paquete.\n\n—Hay que entregarlo.",

        "La dirección te lleva hasta las afueras de la ciudad.\n\nEl paquete es pequeño.\n\nMucho más pequeño que todos los que has transportado durante la semana.\n\nTu jefe te llama.\n\n—Escucha bien.\n\n—¿Qué pasa?\n\n—Solo tienes que entregarlo.\n\n—¿A quién?\n\n—Lo sabrás cuando llegues.\n\nComienzas a caminar."
    };

    string[][] decisiones1 =
    {
        new string[]
        {
            "A) Buscar la dirección durante 4 horas.",
            "B) Buscarla durante 2 horas y regresar.",
            "C) Buscarla durante 3 horas.",
            "D) Buscarla durante 1 hora y regresar."
        },

        new string[]
        {
            "A) Cargarla tú solo durante 5 horas.",
            "B) Hacer el recorrido durante 3 horas y descansar varias veces.",
            "C) Cargarla durante 4 horas.",
            "D) Cargarla durante 2 horas y descansar."
        },

        new string[]
        {
            "A) Trabajar durante 5 horas buscando al destinatario.",
            "B) Trabajar durante 2 horas buscando al destinatario.",
            "C) Buscar durante 3 horas.",
            "D) Buscar durante 1 hora."
        },

        new string[]
        {
            "A) Subir caminando y hacer la entrega.",
            "B) Subir solamente hasta el piso 15 y descansar antes de continuar.",
            "C) Subir hasta el piso 20 y descansar antes de continuar.",
            "D) Subir lentamente y hacer varias pausas."
        },

        new string[]
        {
            "A) Trabajar durante 6 horas.",
            "B) Trabajar durante 3 horas.",
            "C) Trabajar durante 5 horas.",
            "D) Trabajar durante 2 horas."
        },

        new string[]
        {
            "A) Buscar durante 5 horas.",
            "B) Buscar durante 2 horas.",
            "C) Buscar durante 4 horas.",
            "D) Buscar durante 1 hora."
        },

        new string[]
        {
            "A) Trabajar durante 5 horas para completar la entrega.",
            "B) Trabajar durante 2 horas y descansar.",
            "C) Trabajar durante 4 horas.",
            "D) Trabajar durante 1 hora y descansar."
        }
    };

    string[][] resultados1 =
    {
        new string[]
        {
            "Buscas durante horas.\n\nCuando finalmente regresas a la oficina, encuentras el tercer paquete.\n\nEstá exactamente sobre tu escritorio.\n\nNo recuerdas haberlo dejado ahí.",
            "Buscas durante un par de horas, pero no encuentras la casa.\n\nDecides regresar.",
            "Pasas varias horas buscando la dirección.\n\nEl número existe, pero la casa sigue sin aparecer.",
            "Buscas durante una hora y decides regresar.\n\nLa dirección sigue siendo un misterio."
        },

        new string[]
        {
            "Cargas la caja durante horas.\n\nFinalmente consigues llevarla hasta la dirección.",
            "Haces el recorrido descansando varias veces.\n\nFinalmente consigues llegar a la dirección.",
            "Cargas la caja durante varias horas.\n\nDespués de mucho esfuerzo consigues llegar.",
            "Cargas la caja durante un rato y haces varias pausas."
        },

        new string[]
        {
            "Buscas al destinatario durante horas.\n\nDespués de buscar durante un rato, una persona aparece frente a ti.\n\n—Ese paquete es mío.",
            "Buscas durante dos horas.\n\nFinalmente una persona aparece frente a ti.\n\n—Ese paquete es mío.",
            "Pasas varias horas buscando.\n\nUna persona aparece frente a ti.\n\n—Ese paquete es mío.",
            "Buscas durante una hora.\n\nDe repente, una persona aparece frente a ti."
        },

        new string[]
        {
            "Subes las escaleras y finalmente llegas al piso 30.\n\nTocas la puerta.\n\nNadie responde.\n\nTocas otra vez.\n\nNada.",
            "Subes hasta el piso 15 y descansas antes de continuar.",
            "Subes hasta el piso 20 y descansas antes de continuar.",
            "Subes lentamente, haciendo varias pausas."
        },

        new string[]
        {
            "Trabajas durante horas y consigues realizar muchas entregas.",
            "Realizas varias entregas durante el día.",
            "Trabajas durante varias horas y entregas una gran cantidad de paquetes.",
            "Haces algunas entregas antes de terminar el día."
        },

        new string[]
        {
            "Buscas durante horas.\n\nDespués de caminar por el parque, encuentras una pequeña puerta.\n\nNo está conectada a ningún edificio.\n\nSimplemente está ahí.\n\nTocas.\n\nLa puerta se abre.",
            "Buscas durante un rato.\n\nFinalmente encuentras una pequeña puerta en medio del parque.",
            "Pasas varias horas buscando.\n\nFinalmente encuentras una pequeña puerta.",
            "Buscas durante una hora.\n\nDespués de caminar un poco, encuentras una puerta que no debería estar ahí."
        },

        new string[]
        {
            "Trabajas durante horas para completar la entrega.\n\nFinalmente llegas a la dirección.",
            "Trabajas durante un rato y descansas.\n\nFinalmente llegas a la dirección.",
            "Trabajas durante varias horas.\n\nDespués de mucho caminar, finalmente llegas.",
            "Trabajas durante poco tiempo y descansas antes de continuar."
        }
    };

    string[][] decisiones2 =
    {
        new string[]
        {
            "A) Comprar comida.",
            "B) Guardar el dinero y aguantar el hambre.",
            "C) Comprar algo barato para comer.",
            "D) Comprar una comida grande y descansar."
        },

        new string[]
        {
            "A) Llevar la caja de vuelta a la oficina.",
            "B) Dejar la caja y marcharte.",
            "C) Esperar un rato para intentar aclarar el problema.",
            "D) Dejar la caja y descansar antes de regresar."
        },

        new string[]
        {
            "A) Llevar el nuevo paquete a la oficina.",
            "B) Intentar entregarlo inmediatamente.",
            "C) Llevarlo durante una hora antes de regresar.",
            "D) Descansar antes de decidir qué hacer."
        },

        new string[]
        {
            "A) Esperar durante una hora.",
            "B) Dejar una nota y regresar.",
            "C) Esperar durante 30 minutos.",
            "D) Dejar el paquete y descansar unos minutos antes de bajar."
        },

        new string[]
        {
            "A) Llevarlo a la oficina.",
            "B) Intentar entregarlo en la dirección más cercana.",
            "C) Llevarlo durante una hora para buscar otra dirección.",
            "D) Guardarlo y descansar antes de regresar."
        },

        new string[]
        {
            "A) Llevar el sobre inmediatamente a la oficina.",
            "B) Guardar el sobre y descansar.",
            "C) Llevar el sobre después de descansar un rato.",
            "D) Regresar inmediatamente con el sobre."
        },

        new string[]
        {
            "A) Entregar el paquete y terminar el trabajo.",
            "B) Pedir un descanso antes de continuar.",
            "C) Entregar el paquete después de descansar unos minutos.",
            "D) Entregarlo rápidamente y regresar."
        }
    };

    string[][] resultados2 =
    {
        new string[]
        {
            "Compras comida.",
            "Decides guardar el dinero y aguantar el hambre.",
            "Compras algo barato para comer.",
            "Compras una comida grande y descansas."
        },

        new string[]
        {
            "Decides llevar la caja de vuelta a la oficina.",
            "Dejas la caja y te marchas.",
            "Esperas un rato para intentar aclarar el problema.",
            "Dejas la caja y descansas antes de regresar."
        },

        new string[]
        {
            "Decides llevar el nuevo paquete a la oficina.",
            "Intentas entregar el nuevo paquete inmediatamente.",
            "Llevas el paquete durante una hora antes de regresar.",
            "Decides descansar antes de tomar una decisión."
        },

        new string[]
        {
            "Esperas durante una hora.\n\nNadie responde.",
            "Dejas una nota y regresas.",
            "Esperas durante treinta minutos.",
            "Dejas el paquete y descansas unos minutos antes de bajar."
        },

        new string[]
        {
            "Llevas el paquete a la oficina.",
            "Intentas entregarlo en la dirección más cercana.",
            "Llevas el paquete durante una hora buscando otra dirección.",
            "Guardas el paquete y descansas antes de regresar."
        },

        new string[]
        {
            "Llevas el sobre inmediatamente a la oficina.",
            "Guardas el sobre y descansas.",
            "Descansas un rato y después llevas el sobre.",
            "Regresas inmediatamente con el sobre."
        },

        new string[]
        {
            "Entregas el paquete y terminas el trabajo.",
            "Pides un descanso antes de continuar.",
            "Descansas unos minutos y después entregas el paquete.",
            "Entregas el paquete rápidamente y regresas."
        }
    };

    for (int dia = 0; dia < 7; dia++)
    {
        Console.WriteLine("\n================================");
        Console.WriteLine(dias[dia]);
        Console.WriteLine("================================\n");

        Console.WriteLine(narraciones[dia]);

        Console.WriteLine("\nDECISIÓN 1\n");

        for (int opcion = 0; opcion < 4; opcion++)
        {
            Console.WriteLine(decisiones1[dia][opcion]);
        }

        Console.Write("\nElige una opción: ");
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
            indice = 0;
        else if (eleccion == "B")
            indice = 1;
        else if (eleccion == "C")
            indice = 2;
        else
            indice = 3;

        Console.WriteLine("\n" + resultados1[dia][indice]);

        Console.WriteLine("\nDECISIÓN 2\n");

        for (int opcion = 0; opcion < 4; opcion++)
        {
            Console.WriteLine(decisiones2[dia][opcion]);
        }

        Console.Write("\nElige una opción: ");
        eleccion = Console.ReadLine().ToUpper();

        while (eleccion != "A" &&
               eleccion != "B" &&
               eleccion != "C" &&
               eleccion != "D")
        {
            Console.Write("Opción inválida. Elige A, B, C o D: ");
            eleccion = Console.ReadLine().ToUpper();
        }

        indice = 0;

        if (eleccion == "A")
            indice = 0;
        else if (eleccion == "B")
            indice = 1;
        else if (eleccion == "C")
            indice = 2;
        else
            indice = 3;

        Console.WriteLine("\n" + resultados2[dia][indice]);

        if (dia == 0)
        {
            Console.WriteLine("\nCuando finalmente regresas a la oficina, encuentras el tercer paquete.");
            Console.WriteLine("Está exactamente sobre tu escritorio.");
            Console.WriteLine("No recuerdas haberlo dejado ahí.");
        }
        else if (dia == 1)
        {
            Console.WriteLine("\nCuando vuelves a la oficina, encuentras otra caja exactamente igual.");
        }
        else if (dia == 2)
        {
            Console.WriteLine("\nCuando terminas el día, te das cuenta de algo.");
            Console.WriteLine("El paquete que entregaste originalmente sigue apareciendo en tu mochila.");
        }
        else if (dia == 3)
        {
            Console.WriteLine("\nCuando bajas, ves que el ascensor vuelve a funcionar.");
            Console.WriteLine("Se abre.");
            Console.WriteLine("Dentro hay una montaña de paquetes.");
            Console.WriteLine("No sabes quién los puso ahí.");
        }
        else if (dia == 4)
        {
            Console.WriteLine("\nAl regresar, tu jefe mira la caja.");
            Console.WriteLine("—¿De dónde sacaste eso?");
            Console.WriteLine("—Me la dieron.");
            Console.WriteLine("Tu jefe mira la caja.");
            Console.WriteLine("—Yo nunca la he visto.");
        }
        else if (dia == 5)
        {
            Console.WriteLine("\nCuando regresas a la oficina, tu jefe está esperando.");
            Console.WriteLine("—Mañana será tu último día.");
            Console.WriteLine("Te entrega una última lista.");
            Console.WriteLine("Hay una sola dirección.");
        }
        else if (dia == 6)
        {
            Console.WriteLine("\nLa persona recibe el paquete.");
            Console.WriteLine("Lo abre.");
            Console.WriteLine("Dentro hay...");
            Console.WriteLine("Otro paquete.");
            Console.WriteLine("Te mira.");
            Console.WriteLine("Tú miras el paquete.");
            Console.WriteLine("La persona suspira.");
            Console.WriteLine("—Bueno.");
            Console.WriteLine("—¿Ahora qué?");
            Console.WriteLine("Te entrega el nuevo paquete.");
            Console.WriteLine("—Ahora tienes que entregarlo.");
        }
    }
}
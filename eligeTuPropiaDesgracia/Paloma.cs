public static void RutaPalomas()
{
    Console.WriteLine("\n================================");
    Console.WriteLine(" RUTA — ENTRENADOR DE PALOMAS");
    Console.WriteLine("================================\n");

    Console.WriteLine("«Se busca entrenador de palomas.»");
    Console.WriteLine("«No se requiere experiencia.»");
    Console.WriteLine("«El trabajo consiste en enseñar a las palomas a transportar pequeños objetos.»");
    Console.WriteLine("«Pago: $50 por hora.»\n");

    Console.WriteLine("Llegas a una plaza donde te espera un hombre con una caja llena de semillas.");
    Console.WriteLine();
    Console.WriteLine("—¿Has trabajado con palomas antes?");
    Console.WriteLine("—No.");
    Console.WriteLine("—Perfecto. Ellas tampoco han trabajado contigo.\n");

    Console.WriteLine("Te entrega una bolsa de semillas.");
    Console.WriteLine("—Buena suerte.\n");

    string[] dias =
    {
        "DÍA 1 — LAS PALOMAS",
        "DÍA 2 — MENSAJERAS",
        "DÍA 3 — EL ENTRENAMIENTO MILITAR",
        "DÍA 4 — EL MENSAJE",
        "DÍA 5 — EL MENSAJE DE LAS PALOMAS",
        "DÍA 6 — LA CIUDAD",
        "DÍA 7 — EL CONGRESO DE LAS PALOMAS"
    };

    string[] narraciones =
    {
        "Tu primer trabajo parece sencillo.\n\nTienes que enseñar a las palomas a caminar hasta un punto, recoger un pequeño paquete y regresar.\n\nEl problema es que ninguna quiere cooperar.\n\nUna paloma se acerca.\n\nTe mira.\n\nSe come una semilla.\n\nY se va.",

        "Tu jefe está emocionado.\n\n—¡Funcionó!\n\nAhora quiere que las palomas transporten cartas.\n\nTe entrega diez sobres.",

        "Al día siguiente, tu jefe tiene una idea.\n\n—Necesitamos palomas más eficientes.\n\nTe entrega pequeños chalecos.\n\n—Entrénalas para que trabajen en equipo.\n\nLas palomas se colocan en círculo.\n\nNo las has enseñado a hacer eso.",

        "Cuando llegas, encuentras a las palomas esperándote.\n\nTodas.\n\nEstán alineadas.\n\nTu jefe te entrega una carta.\n\n—La encontraron esta mañana.\n\nLa carta dice:\n\n«NECESITAMOS HABLAR.»\n\n—¿Quién la escribió?\n\nTu jefe señala las palomas.",

        "Tu jefe ya no sabe qué hacer.\n\nLas palomas ahora transportan cartas entre ellas.\n\nUna paloma recibe una carta.\n\nVuela hasta otra.\n\nLa otra la lee.\n\nDespués todas miran hacia ti.\n\nTu jefe traga saliva.\n\n—Creo que están organizándose.",

        "Al llegar al trabajo, encuentras cientos de palomas.\n\nNo recuerdas haber entrenado tantas.\n\nTu jefe está pálido.\n\n—¿De dónde salieron?\n\nUna paloma se posa sobre su hombro.\n\nDespués le deja una carta.\n\nLa lee.\n\n—Dice que mañana habrá una reunión.\n\n—¿Con quién?\n\nLa paloma te mira.\n\nLuego señala el cielo.",

        "Llegas a la plaza.\n\nHay miles de palomas.\n\nMiles.\n\nEstán sobre los edificios, los árboles, los postes y las calles.\n\nEn el centro hay una pequeña mesa.\n\nSobre ella hay una paloma enorme.\n\nTu jefe se acerca lentamente.\n\n—Creo que es su líder.\n\nLa paloma se acerca a ti.\n\nDeja una pequeña caja sobre la mesa.\n\nDentro hay dinero.\n\nMucho dinero.\n\nTu jefe abre los ojos.\n\n—Creo que quieren contratarte.\n\nLa paloma extiende un ala."
    };

    string[][] decisiones1 =
    {
        new string[]
        {
            "A) Entrenar durante 4 horas.",
            "B) Entrenar durante 2 horas.",
            "C) Entrenar durante 3 horas.",
            "D) Entrenar durante 1 hora."
        },

        new string[]
        {
            "A) Entrenar a las palomas durante 5 horas.",
            "B) Entrenarlas durante 3 horas.",
            "C) Entrenarlas durante 2 horas.",
            "D) Entrenarlas durante 1 hora."
        },

        new string[]
        {
            "A) Entrenarlas durante 5 horas.",
            "B) Entrenarlas durante 2 horas.",
            "C) Entrenarlas durante 4 horas.",
            "D) Entrenarlas durante 1 hora."
        },

        new string[]
        {
            "A) Seguir entrenándolas.",
            "B) Descansar y observarlas.",
            "C) Entrenarlas durante 2 horas.",
            "D) Entrenarlas durante 1 hora y descansar."
        },

        new string[]
        {
            "A) Entrenar a las palomas durante 6 horas.",
            "B) Entrenarlas durante 3 horas.",
            "C) Entrenarlas durante 5 horas.",
            "D) Entrenarlas durante 2 horas."
        },

        new string[]
        {
            "A) Preparar a las palomas durante 5 horas.",
            "B) Prepararlas durante 2 horas.",
            "C) Prepararlas durante 4 horas.",
            "D) Prepararlas durante 1 hora."
        },

        new string[]
        {
            "A) Aceptar el trabajo.",
            "B) Rechazarlo.",
            "C) Aceptar el trabajo y descansar después.",
            "D) Aceptar solo una parte del contrato."
        }
    };

    string[][] resultados1 =
    {
        new string[]
        {
            "Entrenas a las palomas durante horas.\n\nAl terminar el día, una paloma finalmente recoge el paquete.\n\nTodos celebran.\n\nLa paloma deja el paquete en el suelo...\n\nY se come la etiqueta.",
            "Entrenas a las palomas durante un par de horas.\n\nUna de ellas parece empezar a entender lo que quieres.",
            "Después de varias horas, algunas palomas comienzan a seguir tus instrucciones.",
            "Entrenas durante poco tiempo.\n\nLas palomas te observan sin mucho interés."
        },

        new string[]
        {
            "Las palomas practican durante horas.\n\nAl final, parecen entender cómo transportar las cartas.",
            "Entrenas a las palomas durante un buen rato.\n\nVarias consiguen llevar los sobres.",
            "Algunas palomas aprenden rápidamente a transportar las cartas.",
            "Las palomas practican durante poco tiempo.\n\nNo todas parecen entender el ejercicio."
        },

        new string[]
        {
            "Las palomas entrenan durante horas.\n\nPoco a poco empiezan a trabajar juntas.",
            "Entrenas al grupo durante un rato.\n\nLas palomas comienzan a seguir algunas órdenes.",
            "Después de varias horas, las palomas empiezan a coordinarse.",
            "El entrenamiento es corto.\n\nAun así, las palomas parecen estar aprendiendo algo."
        },

        new string[]
        {
            "Sigues entrenando a las palomas.\n\nParece que están planeando algo.",
            "Decides observarlas.\n\nNinguna se mueve.\n\nTodas te miran.",
            "Las entrenas durante dos horas.\n\nLas palomas obedecen perfectamente.",
            "Entrenas durante una hora y después descansas.\n\nLas palomas siguen alineadas."
        },

        new string[]
        {
            "Entrenas a las palomas durante horas.\n\nCada vez parecen más organizadas.",
            "Las entrenas durante un rato.\n\nLas palomas continúan intercambiando cartas.",
            "Las palomas practican durante varias horas.\n\nSu coordinación es extrañamente perfecta.",
            "Trabajas durante poco tiempo.\n\nLas palomas siguen organizándose por su cuenta."
        },

        new string[]
        {
            "Preparas a las palomas durante horas.\n\nTodas parecen estar listas para lo que sea que ocurrirá mañana.",
            "Preparas a las palomas durante un rato.\n\nDespués observas cómo se comportan.",
            "Las entrenas durante varias horas.\n\nLas palomas parecen estar perfectamente coordinadas.",
            "Las preparas durante poco tiempo.\n\nAun así, parecen saber exactamente qué hacer."
        },

        new string[]
        {
            "Aceptas el trabajo.\n\nLa paloma líder parece satisfecha.",
            "Rechazas el trabajo.\n\nLa paloma líder te observa en silencio.",
            "Aceptas el trabajo y decides descansar después.",
            "Aceptas solamente una parte del contrato.\n\nLa paloma parece pensarlo."
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
            "A) Darle comida para convencerla.",
            "B) Ignorarla y trabajar con las demás.",
            "C) Darle una pequeña porción de comida.",
            "D) Dejarla descansar y continuar con las demás."
        },

        new string[]
        {
            "A) Seguirla y entrenar al grupo.",
            "B) Detener el entrenamiento y descansar.",
            "C) Seguir entrenando durante una hora más.",
            "D) Darles un descanso y comer algo."
        },

        new string[]
        {
            "A) Quedártela.",
            "B) Devolverla.",
            "C) Quedártela y comprar comida.",
            "D) Devolverla y descansar."
        },

        new string[]
        {
            "A) Aceptarla y comértela.",
            "B) Rechazarla y comprar comida.",
            "C) Aceptarla y descansar.",
            "D) Guardarla y comprar comida."
        },

        new string[]
        {
            "A) Aceptar $300 y marcharte.",
            "B) Quedarte y seguir trabajando.",
            "C) Aceptar $150 y descansar.",
            "D) Rechazar el dinero y descansar un poco."
        },

        new string[]
        {
            "A) Trabajar otras 4 horas para ellas.",
            "B) Irte a descansar.",
            "C) Trabajar otras 2 horas.",
            "D) Trabajar 1 hora y después descansar."
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
            "Le das comida a la paloma para convencerla de trabajar.",
            "Ignoras a la paloma y continúas trabajando con las demás.",
            "Le das una pequeña porción de comida.",
            "Dejas descansar a la paloma y continúas con las demás."
        },

        new string[]
        {
            "Sigues a la paloma y entrenas al grupo.\n\nLas palomas terminan formando una fila perfecta.\n\nTu jefe sonríe.\n\n—Esto ya parece un ejército.\n\nUna paloma levanta un ala.\n\nLas demás hacen lo mismo.",
            "Detienes el entrenamiento y descansas.\n\nLas palomas permanecen en círculo.",
            "Sigues entrenando durante una hora más.\n\nLas palomas terminan formando una fila perfecta.",
            "Les das un descanso.\n\nLas palomas se quedan completamente quietas."
        },

        new string[]
        {
            "Decides quedarte con la moneda.",
            "Devuelves la moneda.",
            "Te quedas con la moneda y compras comida.",
            "Devuelves la moneda y decides descansar."
        },

        new string[]
        {
            "Aceptas la semilla y te la comes.",
            "Rechazas la semilla y compras comida.",
            "Aceptas la semilla y descansas.",
            "Guardas la semilla y compras comida."
        },

        new string[]
        {
            "Aceptas los $300 y abandonas el trabajo.",
            "Decides quedarte y continuar trabajando.",
            "Aceptas los $150 y decides descansar.",
            "Rechazas el dinero y descansas un poco."
        },

        new string[]
        {
            "Trabajas otras cuatro horas para las palomas.",
            "Decides irte a descansar.",
            "Trabajas otras dos horas.",
            "Trabajas durante una hora y después descansas."
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
            Console.WriteLine("\nAl terminar el día, una paloma finalmente recoge el paquete.");
            Console.WriteLine("Todos celebran.");
            Console.WriteLine("La paloma deja el paquete en el suelo...");
            Console.WriteLine("Y se come la etiqueta.");
        }
        else if (dia == 1)
        {
            Console.WriteLine("\nAl final del día, nueve palomas entregan sus cartas correctamente.");
            Console.WriteLine("La décima vuelve tres horas después.");
            Console.WriteLine("Trae una carta diferente.");
            Console.WriteLine("No sabes de dónde salió.");
            Console.WriteLine("Tu jefe la abre.");
            Console.WriteLine("Está completamente en blanco.");
        }
        else if (dia == 2)
        {
            Console.WriteLine("\nLas palomas terminan formando una fila perfecta.");
            Console.WriteLine("Tu jefe sonríe.");
            Console.WriteLine("—Esto ya parece un ejército.");
            Console.WriteLine("\nUna paloma levanta un ala.");
            Console.WriteLine("Las demás hacen lo mismo.");
        }
        else if (dia == 3)
        {
            Console.WriteLine("\nLa paloma te mira.");
            Console.WriteLine("Después mira a las demás.");
            Console.WriteLine("Todas vuelven a formar una fila.");
            Console.WriteLine("\nDefinitivamente están planeando algo.");
        }
        else if (dia == 4)
        {
            Console.WriteLine("\nEsa noche descubres algo.");
            Console.WriteLine("Las palomas han construido un pequeño mapa de la ciudad.");
            Console.WriteLine("No sabes cómo.");
            Console.WriteLine("Y tampoco quieres saberlo.");
        }
        else if (dia == 5)
        {
            Console.WriteLine("\nAl final del día, todas las palomas desaparecen.");
            Console.WriteLine("Solo queda una.");
            Console.WriteLine("Está sobre tu hombro.");
            Console.WriteLine("Te entrega una última carta:");
            Console.WriteLine("«MAÑANA.»");
        }
        else if (dia == 6)
        {
            Console.WriteLine("\nLa paloma líder se acerca.");
            Console.WriteLine("Coloca una pequeña corona sobre su cabeza.");
            Console.WriteLine("Después mira hacia las miles de palomas.");
            Console.WriteLine("Todas empiezan a volar.");
        }
    }
}
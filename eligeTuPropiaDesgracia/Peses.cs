public static void RutaPeces()
{
    Console.WriteLine("\n================================");
    Console.WriteLine(" RUTA — TRADUCTOR DE PECES");
    Console.WriteLine("================================\n");

    Console.WriteLine("«Se busca traductor de peces.»");
    Console.WriteLine("«No se requiere experiencia previa.»");
    Console.WriteLine("«El trabajo consiste en interpretar los sonidos producidos por peces.»");
    Console.WriteLine("«Pago: $60 por hora.»\n");

    Console.WriteLine("Llegas a un pequeño acuario.");
    Console.WriteLine("Un hombre con una bata blanca te recibe.\n");

    Console.WriteLine("—¿Sabes hablar pez?");
    Console.WriteLine("—No.");
    Console.WriteLine("—Perfecto. Nosotros tampoco.\n");

    Console.WriteLine("Te entrega unos audífonos y señala una pecera.");
    Console.WriteLine("Dentro hay tres peces.");
    Console.WriteLine("Uno te mira fijamente.");
    Console.WriteLine("—Ese es Carlos.");
    Console.WriteLine("—¿Carlos?");
    Console.WriteLine("—Sí.");
    Console.WriteLine("—¿Y qué dice?");
    Console.WriteLine("—Todavía no lo sabemos.\n");

    Console.WriteLine("Te sientas frente a la pecera.");
    Console.WriteLine("Tu nuevo trabajo comienza.\n");

    string[] dias =
    {
        "DÍA 1 — TU PRIMER PEZ",
        "DÍA 2 — EL ACUARIO",
        "DÍA 3 — EL PEZ QUE SABE DEMASIADO",
        "DÍA 4 — EL MENSAJE",
        "DÍA 5 — EL OCÉANO",
        "DÍA 6 — LA REUNIÓN",
        "DÍA 7 — LA CUMBRE DEL OCÉANO"
    };

    string[] narraciones =
    {
        "Te colocas los audífonos.\n\nEscuchas:\n«Blub.»\n\nEsperas.\nOtro:\n«Blub blub.»\n\nEl pez nada en círculos.\n\nTu jefe te mira.\n\n—¿Qué dijo?\n\nNo tienes idea.\n\nPero tienes que responder algo.",

        "Regresas al día siguiente.\n\nAhora hay veinte peces.\n\nTu jefe está emocionado.\n\n—Necesitamos saber qué están diciendo.\n\nTe sientas frente al tanque.\n\nTodos empiezan a hacer sonidos al mismo tiempo.\n\nBlub.\n\nBlub blub.\n\nBLUB.\n\nTe duele la cabeza.",

        "Tu jefe te lleva a una habitación privada.\n\nHay una pecera cubierta con una tela.\n\n—Este pez es diferente.\n\nRetira la tela.\n\nDentro hay un pez enorme.\n\nTe mira.\n\nY habla.\n\nNo con sonidos.\n\nCon palabras.\n\n—POR FIN.\n\nTe quedas congelado.\n\nTu jefe también.\n\n—¿Entendiste eso?\n\nAsientes lentamente.\n\nEl pez vuelve a hablar.\n\n—TENEMOS UN PROBLEMA.",

        "Cuando llegas al acuario, todos los peces están alineados.\n\nTodos.\n\nIncluso los peces pequeños.\n\nTu jefe observa la pecera.\n\n—Nunca había visto esto.\n\nTe colocas los audífonos.\n\nTodos empiezan a hablar al mismo tiempo.\n\nPero esta vez entiendes una palabra:\n\n«GUERRA.»\n\nMiras a tu jefe.\n\n—Creo que los peces están preocupados.\n\n—¿Por qué?\n\nUn pez salta.\n\nCae nuevamente al agua.\n\nY dice:\n\n—LOS HUMANOS NO ESTÁN ESCUCHANDO.",

        "Tu jefe recibe una llamada.\n\nDespués de colgar, te mira.\n\n—Necesitamos que traduzcas algo importante.\n\nTe lleva a una enorme sala.\n\nHay una pantalla.\n\nEn ella aparece una transmisión submarina.\n\nMiles de peces están reunidos.\n\nUno de ellos se acerca a la cámara.\n\n—HUMANO.\n\nTu jefe te entrega los audífonos.\n\n—Traduce.",

        "Llegas al trabajo.\n\nLa sala está llena de personas.\n\nCientíficos.\n\nEmpresarios.\n\nPeriodistas.\n\nY representantes de varios países.\n\nEn el centro hay una pecera gigantesca.\n\nDentro hay cientos de peces.\n\nTodos están esperando.\n\nTu jefe se acerca.\n\n—Mañana será la reunión más importante de tu carrera.\n\nUn pez golpea el vidrio.\n\nToc.",

        "Llegas temprano.\n\nLa sala está llena.\n\nCámaras.\n\nMicrófonos.\n\nPersonas.\n\nY una gigantesca pecera en el centro.\n\nMiles de peces nadan dentro.\n\nEl pez principal se acerca al vidrio.\n\nTe colocas los audífonos.\n\n—HUMANOS.\n\nTodas las cámaras apuntan hacia la pecera.\n\n—HEMOS VENIDO A HABLAR.\n\nMiras a tu jefe.\n\nTu jefe te mira.\n\nAhora depende de ti traducir."
    };

    string[][] decisiones1 =
    {
        new string[]
        {
            "A) Trabajar durante 4 horas intentando traducirlo.",
            "B) Trabajar durante 2 horas.",
            "C) Trabajar durante 1 hora y descansar.",
            "D) Pasar el día observando al pez sin trabajar."
        },

        new string[]
        {
            "A) Traducir durante 5 horas.",
            "B) Traducir durante 3 horas.",
            "C) Traducir durante 2 horas.",
            "D) Traducir durante 1 hora."
        },

        new string[]
        {
            "A) Trabajar durante 5 horas traduciendo al pez.",
            "B) Trabajar durante 2 horas y tomar un descanso.",
            "C) Trabajar durante 4 horas.",
            "D) Escuchar al pez durante 1 hora."
        },

        new string[]
        {
            "A) Traducir durante 5 horas.",
            "B) Descansar y observar a los peces.",
            "C) Traducir durante 3 horas.",
            "D) Traducir durante 1 hora y descansar."
        },

        new string[]
        {
            "A) Traducir durante 6 horas.",
            "B) Traducir durante 3 horas.",
            "C) Traducir durante 5 horas.",
            "D) Traducir durante 2 horas."
        },

        new string[]
        {
            "A) Prepararte durante 5 horas.",
            "B) Prepararte durante 2 horas y descansar.",
            "C) Prepararte durante 4 horas.",
            "D) Prepararte durante 1 hora y descansar."
        },

        new string[]
        {
            "A) Trabajar durante 5 horas traduciendo el discurso.",
            "B) Trabajar durante 2 horas y conservar energía.",
            "C) Trabajar durante 4 horas.",
            "D) Trabajar durante 1 hora y descansar."
        }
    };

    string[][] resultados1 =
    {
        new string[]
        {
            "Después de varias horas consigues escribir una traducción:\n\n«Tengo hambre.»\n\nTu jefe mira al pez.\n\nDespués te mira a ti.\n\n—Tiene sentido.",
            "Después de varias horas consigues escribir una traducción:\n\n«Tengo hambre.»\n\nTu jefe mira al pez.\n\n—Tiene sentido.",
            "Después de una hora consigues entender una palabra del pez.\n\nParece estar hablando de comida.",
            "Pasas el día observando al pez.\n\nNo consigues traducir nada."
        },

        new string[]
        {
            "Después de escuchar durante horas, consigues entender una frase:\n\n«EL AGUA ESTÁ DEMASIADO FRÍA.»\n\nTu jefe ajusta la temperatura.\n\nLos peces dejan de quejarse.\n\nProbablemente acabas de resolver una crisis diplomática.",
            "Consigues entender parte del mensaje.\n\nEl pez parece estar quejándose del agua.",
            "Después de un rato consigues entender:\n\n«EL AGUA ESTÁ DEMASIADO FRÍA.»",
            "Después de una hora consigues entender algunas palabras.\n\nTodavía no sabes qué quieren decir."
        },

        new string[]
        {
            "El pez te cuenta algo extraño.\n\nSegún él, los peces de la ciudad llevan años intercambiando información.\n\nY alguien está robando sus secretos.",
            "El pez te cuenta parte de la historia.\n\nParece que algo extraño está ocurriendo entre los peces.",
            "Después de escucharlo durante horas, descubres que los peces llevan años intercambiando información.",
            "El pez apenas alcanza a contarte algunos detalles."
        },

        new string[]
        {
            "Después de varias horas descubres que los peces están discutiendo sobre algo llamado:\n\nEL GRAN OCÉANO.",
            "Observas a los peces durante un rato.\n\nParece que todos están preocupados por algo.",
            "Después de varias horas descubres información sobre:\n\nEL GRAN OCÉANO.",
            "Consigues entender algunas palabras relacionadas con el Gran Océano."
        },

        new string[]
        {
            "El pez continúa hablando.\n\n—TENEMOS RECURSOS. TENEMOS TERRITORIOS. TENEMOS EJÉRCITOS.\n\nPausa.\n\n—PERO NO TENEMOS UN TRADUCTOR.\n\nTu jefe te mira.\n\nTú lo miras.",
            "El pez explica que los peces tienen recursos y territorios.",
            "El pez continúa explicando cómo funciona su sociedad.",
            "El pez habla rápidamente y consigues entender solo una parte."
        },

        new string[]
        {
            "Después de prepararte, el pez principal se acerca.\n\n—MAÑANA HABRÁ UNA DECLARACIÓN.",
            "Te preparas durante un rato y luego descansas.\n\nEl pez principal se acerca.\n\n—MAÑANA HABRÁ UNA DECLARACIÓN.",
            "Después de varias horas de preparación, el pez principal se acerca.\n\n—MAÑANA HABRÁ UNA DECLARACIÓN.",
            "Terminas de prepararte y descansas.\n\nEl pez principal te mira."
        },

        new string[]
        {
            "El pez continúa:\n\n—QUEREMOS COMERCIO. QUEREMOS RESPETO. Y QUEREMOS...\n\nHace una pausa.\n\nMira directamente hacia ti.\n\n—UN SALMÓN.\n\nLa sala queda completamente en silencio.",
            "El pez continúa hablando.\n\nParece que su discurso es más importante de lo que esperabas.",
            "El pez explica la parte principal de su mensaje.\n\nTodos esperan tu traducción.",
            "Intentas traducir rápidamente mientras todos esperan."
        }
    };

    string[][] decisiones2 =
    {
        new string[]
        {
            "A) Comprar comida para ti.",
            "B) Guardar el dinero y aguantar el hambre.",
            "C) Comprar algo barato para comer.",
            "D) Comprar una comida grande."
        },

        new string[]
        {
            "A) Comprar comida para los peces.",
            "B) Ignorarlo y continuar trabajando.",
            "C) Comprar comida para ti y para los peces.",
            "D) No comprar nada y descansar."
        },

        new string[]
        {
            "A) Seguir escuchando al pez.",
            "B) Terminar el trabajo y marcharte.",
            "C) Escucharlo durante una hora más.",
            "D) Tomarte un descanso antes de seguir escuchando."
        },

        new string[]
        {
            "A) Quedártela.",
            "B) Devolverla.",
            "C) Aceptarla y descansar.",
            "D) Devolverla y seguir trabajando."
        },

        new string[]
        {
            "A) Aceptarla.",
            "B) Rechazarla.",
            "C) Aceptarla y descansar.",
            "D) Aceptarla y continuar trabajando."
        },

        new string[]
        {
            "A) Seguir trabajando y preparar la traducción.",
            "B) Irte a descansar para llegar con energía.",
            "C) Trabajar durante 2 horas más.",
            "D) Trabajar durante 1 hora y después descansar."
        },

        new string[]
        {
            "A) Traducir todo el discurso.",
            "B) Pedir un descanso antes de continuar.",
            "C) Traducir solamente la parte principal.",
            "D) Traducir rápidamente todo el discurso."
        }
    };

    string[][] resultados2 =
    {
        new string[]
        {
            "Compras comida para ti.",
            "Decides guardar el dinero y aguantar el hambre.",
            "Compras algo barato para comer.",
            "Compras una comida grande."
        },

        new string[]
        {
            "Compras comida para los peces.",
            "Ignoras al pez y continúas trabajando.",
            "Compras comida para ti y para los peces.",
            "Decides no comprar nada y descansar."
        },

        new string[]
        {
            "Sigues escuchando al pez.\n\nAntes de irte, el pez te dice:\n\n—MAÑANA NECESITAMOS HABLAR CONTIGO.",
            "Terminas el trabajo y te marchas.\n\nEl pez te observa mientras te vas.",
            "Lo escuchas durante una hora más.\n\nAntes de irte, el pez te dice:\n\n—MAÑANA NECESITAMOS HABLAR CONTIGO.",
            "Te tomas un descanso antes de seguir escuchando.\n\nEl pez espera pacientemente."
        },

        new string[]
        {
            "Decides quedarte con la moneda.",
            "Devuelves la moneda al pez.",
            "Aceptas la moneda y decides descansar.",
            "Devuelves la moneda y continúas trabajando."
        },

        new string[]
        {
            "Aceptas la recompensa.",
            "Rechazas la recompensa.",
            "Aceptas la recompensa y decides descansar.",
            "Aceptas la recompensa y continúas trabajando."
        },

        new string[]
        {
            "Sigues trabajando y preparas la traducción.",
            "Decides irte a descansar para llegar con energía.",
            "Trabajas durante dos horas más.",
            "Trabajas durante una hora y después descansas.\n\nAntes de salir, el pez te mira.\n\n—NO NOS DEJES EN RIDÍCULO."
        },

        new string[]
        {
            "Terminas la traducción.",
            "Pides un descanso antes de continuar.",
            "Traducís solamente la parte principal del discurso.",
            "Traducís rápidamente todo el discurso."
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
            Console.WriteLine("\nAntes de irte, Carlos golpea el vidrio.");
            Console.WriteLine("Toc.");
            Console.WriteLine("Toc.");
            Console.WriteLine("Toc.");
            Console.WriteLine("No sabes qué significa.");
        }
        else if (dia == 1)
        {
            Console.WriteLine("\nAntes de irte, el pez dibuja algo en la arena del fondo.");
            Console.WriteLine("Parece un mapa.");
        }
        else if (dia == 2)
        {
            Console.WriteLine("\nAntes de irte, el pez te dice:");
            Console.WriteLine("—MAÑANA NECESITAMOS HABLAR CONTIGO.");
        }
        else if (dia == 3)
        {
            Console.WriteLine("\nAntes de marcharte, todos los peces golpean el vidrio al mismo tiempo.");
            Console.WriteLine("Toc.");
        }
        else if (dia == 4)
        {
            Console.WriteLine("\nEl pez termina su discurso:");
            Console.WriteLine("—MAÑANA HABLAREMOS CON LOS HUMANOS.");
            Console.WriteLine("\nTu jefe apaga la pantalla.");
            Console.WriteLine("—Creo que acabas de conseguir un ascenso.");
        }
        else if (dia == 5)
        {
            Console.WriteLine("\nAntes de salir, el pez te mira.");
            Console.WriteLine("—NO NOS DEJES EN RIDÍCULO.");
        }
        else if (dia == 6)
        {
            Console.WriteLine("\nTerminas la traducción.");
            Console.WriteLine("El representante de los peces se acerca al vidrio.");
            Console.WriteLine("Todos los peces comienzan a nadar formando un círculo.");
            Console.WriteLine("El agua empieza a girar.");
            Console.WriteLine("El pez principal levanta una aleta.");
            Console.WriteLine("—TENEMOS UN ACUERDO.");
            Console.WriteLine("\nTodos los presentes comienzan a aplaudir.");
        }
    }
}
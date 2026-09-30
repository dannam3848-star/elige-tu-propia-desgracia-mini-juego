class Peces
{
    
  public static string[] Dias =
    {
        "DÍA 1 — TU PRIMER PEZ",
        "DÍA 2 — EL ACUARIO",
        "DÍA 3 — EL PEZ QUE SABE DEMASIADO",
        "DÍA 4 — EL MENSAJE",
        "DÍA 5 — EL OCÉANO",
        "DÍA 6 — LA REUNIÓN",
        "DÍA 7 — LA CUMBRE DEL OCÉANO"
    };


   public static string[] Narraciones =
    {
        "Te colocas los audífonos.\n\nEscuchas:\n«Blub.»\n\nEsperas.\nOtro:\n«Blub blub.»\n\nEl pez nada en círculos.\n\nTu jefe te mira.\n\n—¿Qué dijo?\n\nNo tienes idea.\n\nPero tienes que responder algo.",

        "Regresas al día siguiente.\n\nAhora hay veinte peces.\n\nTu jefe está emocionado.\n\n—Necesitamos saber qué están diciendo.\n\nTe sientas frente al tanque.\n\nTodos empiezan a hacer sonidos al mismo tiempo.\n\nBlub.\n\nBlub blub.\n\nBLUB.\n\nTe duele la cabeza.",

        "Tu jefe te lleva a una habitación privada.\n\nHay una pecera cubierta con una tela.\n\n—Este pez es diferente.\n\nRetira la tela.\n\nDentro hay un pez enorme.\n\nTe mira.\n\nY habla.\n\nNo con sonidos.\n\nCon palabras.\n\n—POR FIN.\n\nTe quedas congelado.\n\nTu jefe también.\n\n—¿Entendiste eso?\n\nAsientes lentamente.\n\nEl pez vuelve a hablar.\n\n—TENEMOS UN PROBLEMA.",

        "Cuando llegas al acuario, todos los peces están alineados.\n\nTodos.\n\nIncluso los peces pequeños.\n\nTu jefe observa la pecera.\n\n—Nunca había visto esto.\n\nTe colocas los audífonos.\n\nTodos empiezan a hablar al mismo tiempo.\n\nPero esta vez entiendes una palabra:\n\n«GUERRA.»\n\nMiras a tu jefe.\n\n—Creo que los peces están preocupados.\n\n—¿Por qué?\n\nUn pez salta.\n\nCae nuevamente al agua.\n\nY dice:\n\n—LOS HUMANOS NO ESTÁN ESCUCHANDO.",

        "Tu jefe recibe una llamada.\n\nDespués de colgar, te mira.\n\n—Necesitamos que traduzcas algo importante.\n\nTe lleva a una enorme sala.\n\nHay una pantalla.\n\nEn ella aparece una transmisión submarina.\n\nMiles de peces están reunidos.\n\nUno de ellos se acerca a la cámara.\n\n—HUMANO.\n\nTu jefe te entrega los audífonos.\n\n—Traduce.",

        "Llegas al trabajo.\n\nLa sala está llena de personas.\n\nCientíficos.\n\nEmpresarios.\n\nPeriodistas.\n\nY representantes de varios países.\n\nEn el centro hay una pecera gigantesca.\n\nDentro hay cientos de peces.\n\nTodos están esperando.\n\nTu jefe se acerca.\n\n—Mañana será la reunión más importante de tu carrera.\n\nUn pez golpea el vidrio.\n\nToc.",

        "Llegas temprano.\n\nLa sala está llena.\n\nCámaras.\n\nMicrófonos.\n\nPersonas.\n\nY una gigantesca pecera en el centro.\n\nMiles de peces nadan dentro.\n\nEl pez principal se acerca al vidrio.\n\nTe colocas los audífonos.\n\n—HUMANOS.\n\nTodas las cámaras apuntan hacia la pecera.\n\n—HEMOS VENIDO A HABLAR.\n\nMiras a tu jefe.\n\nTu jefe te mira.\n\nAhora depende de ti traducir."
    };

    public static string[][] Decisiones =
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
     public static string[][] resultados =
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
  
  
   public static string[][] Consecuencias =
    {
        new string[]
        {
            "energia:-10",
            "hambre:-15",
            "energia:-5",
            "dinerio:-10"
        },

        new string[]
        {
            "energia:-12",
            "energia:-5",
            "dinero:+30",
            "dinero:+60"
        },

        new string[]
        {
            "hambre:-2",
            "energia:+34",
            "energia:+56",
            "hambre:-10"
        },

        new string[]
        {
            "energia:-7",
            "energia:-17",
            "energia:-5",
            "energia:-28"
        },

        new string[]
        {
            "dinero:+45",
            "dinero:+100",
            "dinero:+12",
            "energia:-10"
        },

        new string[]
        {
            "hambre:+50",
            "energia:-4",
            "energia:-15",
            "hambre:+20"
        },

        new string[]
        {
            "energia:+45",
            "energia:-10",
            "energia:-5",
            "energia:-50"
        }
    };
  
  public static string[] intro =
  {
    "\n================================",
    " TRADUCTOR DE PECES",
    "================================\n",
    "«Se busca traductor de peces.»",
    "«No se requiere experiencia previa.»",
    "«El trabajo consiste en interpretar los sonidos producidos por peces.»",
    "«Pago: $60 por hora.»\n",

    "Llegas a un pequeño acuario.",
    "Un hombre con una bata blanca te recibe.\n",

    "—¿Sabes hablar pez?",
    "—No.",
    "—Perfecto. Nosotros tampoco.\n",

    "Te entrega unos audífonos y señala una pecera.",
    "Dentro hay tres peces.",
    "Uno te mira fijamente.",
    "—Ese es Carlos.",
    "—¿Carlos?",
    "—Sí.",
    "—¿Y qué dice?",
    "—Todavía no lo sabemos.\n",

    "Te sientas frente a la pecera.",
    "Tu nuevo trabajo comienza.\n"
 };
}

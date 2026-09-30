class Paloma
{
    
  public static string[] Dias =
    {
        "DÍA 1 — LAS PALOMAS",
        "DÍA 2 — MENSAJERAS",
        "DÍA 3 — EL ENTRENAMIENTO MILITAR",
        "DÍA 4 — EL MENSAJE",
        "DÍA 5 — EL MENSAJE DE LAS PALOMAS",
        "DÍA 6 — LA CIUDAD",
        "DÍA 7 — EL CONGRESO DE LAS PALOMAS"
    };

   public static string[] Narraciones =
    {
        "Tu primer trabajo parece sencillo.\n\nTienes que enseñar a las palomas a caminar hasta un punto, recoger un pequeño paquete y regresar.\n\nEl problema es que ninguna quiere cooperar.\n\nUna paloma se acerca.\n\nTe mira.\n\nSe come una semilla.\n\nY se va.",

        "Tu jefe está emocionado.\n\n—¡Funcionó!\n\nAhora quiere que las palomas transporten cartas.\n\nTe entrega diez sobres.",

        "Al día siguiente, tu jefe tiene una idea.\n\n—Necesitamos palomas más eficientes.\n\nTe entrega pequeños chalecos.\n\n—Entrénalas para que trabajen en equipo.\n\nLas palomas se colocan en círculo.\n\nNo las has enseñado a hacer eso.",

        "Cuando llegas, encuentras a las palomas esperándote.\n\nTodas.\n\nEstán alineadas.\n\nTu jefe te entrega una carta.\n\n—La encontraron esta mañana.\n\nLa carta dice:\n\n«NECESITAMOS HABLAR.»\n\n—¿Quién la escribió?\n\nTu jefe señala las palomas.",

        "Tu jefe ya no sabe qué hacer.\n\nLas palomas ahora transportan cartas entre ellas.\n\nUna paloma recibe una carta.\n\nVuela hasta otra.\n\nLa otra la lee.\n\nDespués todas miran hacia ti.\n\nTu jefe traga saliva.\n\n—Creo que están organizándose.",

        "Al llegar al trabajo, encuentras cientos de palomas.\n\nNo recuerdas haber entrenado tantas.\n\nTu jefe está pálido.\n\n—¿De dónde salieron?\n\nUna paloma se posa sobre su hombro.\n\nDespués le deja una carta.\n\nLa lee.\n\n—Dice que mañana habrá una reunión.\n\n—¿Con quién?\n\nLa paloma te mira.\n\nLuego señala el cielo.",

        "Llegas a la plaza.\n\nHay miles de palomas.\n\nMiles.\n\nEstán sobre los edificios, los árboles, los postes y las calles.\n\nEn el centro hay una pequeña mesa.\n\nSobre ella hay una paloma enorme.\n\nTu jefe se acerca lentamente.\n\n—Creo que es su líder.\n\nLa paloma se acerca a ti.\n\nDeja una pequeña caja sobre la mesa.\n\nDentro hay dinero.\n\nMucho dinero.\n\nTu jefe abre los ojos.\n\n—Creo que quieren contratarte.\n\nLa paloma extiende un ala."
    };

    public static string[][] Decisiones =


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
     public static string[][] resultados =


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
  
  
  public static string[][] Consecuencias =


     {
        new string[]
        {
            "energia:-5",
            "energia:-20",
            "energia:-56",
            "energia:-30"
        },

        new string[]
        {
            "hambre:-10",
            "hambre:-45",
            "hambre:-56",
            "hambre:-23"
        },

        new string[]
        {
            "dinero:+500",
            "dineero:+45",
            "dinero:+34",
            "dinero:+23"
        },

        new string[]
        {
            "A) dinerio:+50",
            "B) energia:+54",
            "C) hambre:+6",
            "D) energia:+10"
        },

        new string[]
        {
            "energia:-23",
            "energia:-27",
            "energia:-56",
            "energia:-30"
        },

        new string[]
        {
            "hambre:-12",
            "hambre:-23",
            "hambre:-1",
            "hambre:-22"
        },

        new string[]
        {
            "dinero:+34",
            "dinero:-34",
            "energia:+34",
            "dinero:+15"
        }
    };
  
  public static string[] intro =
  {
    "\n================================",
    " RUTA — ENTRENADOR DE PALOMAS",
    "================================\n",

    "«Se busca entrenador de palomas.»",
    "«No se requiere experiencia.»",
    "«El trabajo consiste en enseñar a las palomas a transportar pequeños objetos.»",
    "«Pago: $50 por hora.»\n",

    "Llegas a una plaza donde te espera un hombre con una caja llena de semillas.",
    " ",
    "—¿Has trabajado con palomas antes?",
    "—No.",
    "—Perfecto. Ellas tampoco han trabajado contigo.\n",

    "Te entrega una bolsa de semillas.",
    "—Buena suerte.\n",
   };
}

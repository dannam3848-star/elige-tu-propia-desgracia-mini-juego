class Planta
{
    
  public static string[] Dias =
     {
            "DÍA 1 — LAS PLANTAS",
            "DÍA 2 — EL PROBLEMA",
            "DÍA 3 — LA PLANTA MÁS RARA",
            "DÍA 4 — EL JARDÍN",
            "DÍA 5 — LAS PLANTAS QUIEREN ALGO",
            "DÍA 6 — LA INVASIÓN",
            "DÍA 7 — EL DUEÑO"
        };

   public static string[] Narraciones =
     {
            "Llegas al jardín por primera vez. Hay plantas por todas partes y algunas tienen pequeños carteles de advertencia.",

            "Algo extraño sucede con las plantas. Varias parecen haberse movido durante la noche.",

            "Encuentras una planta que no se parece a ninguna otra. Su apariencia resulta bastante inquietante.",

            "El jardín necesita mantenimiento. El dueño te deja decidir cuánto tiempo quieres dedicarle al trabajo.",

            "Las plantas parecen necesitar algo más que agua. El problema es que nadie te dijo exactamente qué necesitan.",

            "Cuando llegas al jardín descubres que las plantas se han extendido por todas partes.",

            "El dueño finalmente regresa para comprobar cómo ha quedado el jardín."
        };

    public static string[][] Decisiones =

     {
            new string[]
            {
                "A) Regar todas las plantas.",
                "B) Regar solamente las plantas pequeñas.",
                "C) Sentarte durante 5 minutos.",
                "D) Tocar la planta que dice 'NO TOCAR'."
            },

            new string[]
            {
                "A) Mover todas las plantas.",
                "B) Mover solamente las plantas grandes.",
                "C) Regarlas y esperar.",
                "D) Ignorar el problema."
            },

            new string[]
            {
                "A) Regarla.",
                "B) No tocarla.",
                "C) Preguntarle al jefe.",
                "D) Alejarte de ella."
            },

            new string[]
            {
                "A) Trabajar durante 4 horas.",
                "B) Trabajar durante 2 horas.",
                "C) Trabajar durante 1 hora.",
                "D) Descansar."
            },

            new string[]
            {
                "A) Comprar fertilizante.",
                "B) Comprar tierra nueva.",
                "C) No comprar nada.",
                "D) Comprar todo."
            },

            new string[]
            {
                "A) Trabajar durante 5 horas.",
                "B) Trabajar durante 3 horas.",
                "C) Trabajar durante 1 hora.",
                "D) Sentarte y esperar."
            },

            new string[]
            {
                "A) Trabajar durante 5 horas.",
                "B) Trabajar durante 3 horas.",
                "C) Trabajar durante 1 hora.",
                "D) No trabajar y descansar."
            }
        };

     public static string[][] resultados =


   {
            new string[]
            {
                "Riegas todas las plantas. Algunas parecen agradecerlo... de una manera bastante extraña.",
                "Solo riegas las pequeñas. Las grandes tendrán que esperar.",
                "Te sientas durante cinco minutos. El jardín permanece completamente tranquilo.",
                "Tocas la planta prohibida. Algo dentro de la planta se mueve."
            },

            new string[]
            {
                "Mueves todas las plantas. El jardín termina completamente reorganizado.",
                "Mueves las plantas grandes y dejas las demás donde estaban.",
                "Riegas las plantas y esperas para ver qué sucede.",
                "Decides ignorar el problema. Quizás mañana desaparezca."
            },

            new string[]
            {
                "Riegas la planta extraña. Sus hojas comienzan a moverse.",
                "Decides no tocarla. Probablemente sea lo más sensato.",
                "Le preguntas al jefe qué ocurre con ella. Su respuesta no te tranquiliza.",
                "Te alejas de la planta y finges que nunca la viste."
            },

            new string[]
            {
                "Trabajas durante cuatro horas. El jardín queda mucho más ordenado.",
                "Trabajas durante dos horas. Haces bastante trabajo sin agotarte demasiado.",
                "Trabajas solamente una hora.",
                "Decides descansar. El jardín puede esperar."
            },

            new string[]
            {
                "Compras fertilizante para las plantas. Parecen reaccionar inmediatamente.",
                "Cambias la tierra de varias plantas.",
                "Decides no gastar dinero. Las plantas tendrán que arreglárselas.",
                "Compras todo lo que crees necesario."
            },

            new string[]
            {
                "Trabajas durante cinco horas intentando controlar la invasión.",
                "Trabajas durante tres horas y consigues controlar parte del jardín.",
                "Trabajas solamente una hora antes de rendirte.",
                "Te sientas y observas cómo las plantas continúan extendiéndose."
            },

            new string[]
            {
                "Trabajas durante cinco horas para dejar el jardín perfecto.",
                "Trabajas tres horas y dejas el resto para después.",
                "Trabajas una hora y decides que ya es suficiente.",
                "No trabajas y aprovechas el día para descansar."
            }
        };
  
  
  
   public static string[][] Consecuencias =

     {
            new string[]
            {
                "energia:-20",
                "energia:-10",
                "energia:+50",
                "energia:-34"
            },

            new string[]
            {
                "dinero:+43",
                "energia:-20",
                "energia:-34",
                "energia:+34"
            },

            new string[]
            {
                "energia:-10",
                "energia:+50",
                "energia:-5",
                "energia:+5"
            },

            new string[]
            {
                "dinero:+34.",
                "dinero:+45",
                "dinero:+34",
                "dinero:-23"
            },

            new string[]
            {
                "dinero:-23",
                "dinero:-23",
                "dinero:+1",
                "dinero-100"
            },

            new string[]
            {
                "energia:-45",
                "energia:-23",
                "energia:-10",
                "energia:+24"
            },

            new string[]
            {
                "energia:-34",
                "energia:-23",
                "energia:-10",
                "energia:+10."
            }
        };


  public static string[] intro =
   {
   

        "======================================",
        " CUIDADOR DE PLANTAS",
        "======================================",
        " ",
        "Has conseguido un trabajo cuidando un jardín.",
        "El dueño te advierte que algunas plantas son...",
        "bastante extrañas.",
        " ",

        "Presiona ENTER para comenzar...",
        " "

   };
}

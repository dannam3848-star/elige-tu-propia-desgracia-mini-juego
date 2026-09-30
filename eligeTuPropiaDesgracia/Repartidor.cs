class Repartidor
{
    
     public static string[] Dias =
       {
        "DÍA 1 — TU PRIMER REPARTO",
        "DÍA 2 — EL PAQUETE PESADO",
        "DÍA 3 — EL PAQUETE QUE NO DEBERÍA EXISTIR",
        "DÍA 4 — EL EDIFICIO",
        "DÍA 5 — EL DÍA DE LAS ENTREGAS",
        "DÍA 6 — LA ENTREGA IMPOSIBLE",
        "DÍA 7 — EL ÚLTIMO PAQUETE"
   };




   public static string[] Narraciones =
    {
        "Tu primera entrega parece sencilla.\n\nTienes tres paquetes y las direcciones están relativamente cerca.\n\nSales de la oficina.\n\nDespués de caminar unas cuadras, llegas al primer edificio.\n\nEntregas el paquete.\n\nTodo normal.\n\nEl segundo también.\n\nPero cuando llegas al tercero...\n\nNo encuentras el número de la casa.\n\nRevisas la dirección.\n\nLa vuelves a revisar.\n\nEl número existe.\n\nPero la casa no.",

        "Llegas temprano.\n\nEl encargado te señala una caja enorme.\n\n—Tienes que llevar esto al otro lado de la ciudad.\n\nMiras la caja.\n\n—¿Qué tiene?\n\n—No tengo idea.\n\nIntentas levantarla.\n\nPesa muchísimo.",

        "Tu jefe te entrega un paquete pequeño.\n\nLa dirección dice:\n\n«ENTREGAR EN EL MISMO LUGAR DONDE ESTÁS.»\n\nMiras alrededor.\n\nNo hay nadie.\n\nMiras el paquete.\n\nDespués miras nuevamente la dirección.",

        "Tu siguiente entrega es en un edificio enorme.\n\nTienes que subir al piso 30.\n\nEl ascensor tiene un cartel:\n\n«FUERA DE SERVICIO.»\n\nMiras las escaleras.\n\nSon muchas.\n\nDemasiadas.",

        "Tu jefe está desesperado.\n\n—Tenemos demasiados paquetes.\n\nTe muestra una montaña de cajas.\n\n—Necesito que entregues todas las que puedas.",

        "Al llegar al trabajo encuentras una dirección escrita en una hoja.\n\nLa lees.\n\nDespués la vuelves a leer.\n\nLa dirección está en medio de un parque.\n\nNo hay ninguna casa.\n\nNo hay ningún edificio.\n\nSolo árboles.\n\nTu jefe te entrega el paquete.\n\n—Hay que entregarlo.",

        "La dirección te lleva hasta las afueras de la ciudad.\n\nEl paquete es pequeño.\n\nMucho más pequeño que todos los que has transportado durante la semana.\n\nTu jefe te llama.\n\n—Escucha bien.\n\n—¿Qué pasa?\n\n—Solo tienes que entregarlo.\n\n—¿A quién?\n\n—Lo sabrás cuando llegues.\n\nComienzas a caminar."
    };

    public static string[][] Decisiones =
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
     public static string[][] resultados =
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

    public static string[][] Consecuencias =
    {
        new string[]
        {
            "energia:-27",
            "energia:-56",
            "energia:-34",
            "energia:-10"
        },

        new string[]
        {
            "dinero:+50",
            "energia:+20",
            "energia:-65",
            "energia:-30"
        },

        new string[]
        {
            "energia:-20",
            "hambre:-10",
            "energia:-45",
            "energia:-23"
        },

        new string[]
        {
            "energia:-76",
            "energia:+54",
            "energia:+67",
            "energia:+76"
        },

        new string[]
        {
            "dinero:+50",
            "dinero:+30",
            "dinero:+100",
            "dinero:-23"
        },

        new string[]
        {
            "hambre:-10",
            "energia:-20",
            "energia:-15",
            "hambre:-5"
        },

        new string[]
        {
            "dinero:-16",
            "dinero:+43",
            "energia:-34",
            "energia:+76"
        }
    };

  
  
  
  public static string[] intro =
  {
    
    "\n================================",
    " RUTA — REPARTIDOR DE PAQUETES",
    "================================\n",

    "«Se busca repartidor de paquetes.»",
    "«No se requiere experiencia.»",
    "«Debe poder caminar, correr y cargar paquetes.»",
    "«Pago: $50 por hora.»\n",

    "Llegas a una pequeña oficina llena de cajas.",
    "Hay paquetes por todas partes.",
    "Algunos son pequeños.",
    "Otros son enormes.",
    "Uno parece estar respirando.\n",

    "El encargado te entrega una mochila y una lista.",
    "—Solo tienes que entregar los paquetes en las direcciones indicadas.",
    "—¿Y qué pasa si no puedo?",
    "—Entonces no los entregas.\n",

    "Te entrega el primer paquete.",
    "—Buena suerte.\n",
 };
}

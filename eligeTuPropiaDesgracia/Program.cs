public class Program
{

    public static void Main()
    {   
        Narrativa profesionPato = new Narrativa(Pato.Narraciones, Pato.Decisiones, Pato.resultados, Pato.intro, Pato.Dias, Pato.Consecuencias);
        
       Narrativa profesionPeces = new Narrativa(Peces.Narraciones, Peces.Decisiones, Peces.resultados, Peces.intro, Peces.Dias,Peces.Consecuencias);

       Narrativa profesionRepartidor = new Narrativa(Repartidor.Narraciones, Repartidor.Decisiones, Repartidor.resultados, Repartidor.intro, Repartidor.Dias,Repartidor.Consecuencias);

       Narrativa profesionPaloma = new Narrativa(Paloma.Narraciones, Paloma.Decisiones, Paloma.resultados, Paloma.intro, Paloma.Dias,Paloma.Consecuencias);
                
       Narrativa profesionPlanta = new Narrativa(Planta.Narraciones, Planta.Decisiones, Planta.resultados, Planta.intro, Planta.Dias,Planta.Consecuencias);
                  
                  
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();

        string rol = trabajos();

        Jugador player = new Jugador(nombre, rol);
        player.mostrarPersoanje();
        player.estado();

        for (int i =0; i<7 ; i++){

            if (rol == "guardia de pato presidencial")
            {
                profesionPato.mostrarIntro();
                profesionPato.diaActual(player);
            }
             else if (rol == "traductor de peces")
            {
                profesionPeces.mostrarIntro();
                profesionPeces.diaActual(player);
            }
            
            else if (rol == "repartidor")
            {
                profesionRepartidor.mostrarIntro();
                profesionRepartidor.diaActual(player);
            }
            else if (rol == "Entrenador de paloma")
            {
                profesionPaloma.mostrarIntro();
                profesionPaloma.diaActual(player);
           }
            else 
            {
                profesionPlanta.mostrarIntro();
                profesionPlanta.diaActual(player);
           }
            //revisar esta vivo
         
             
            //visualizar estado jugador

            //preguntar si continua o renuncia

           
        }

        Console.Clear();
        Console.WriteLine("======================================");
        Console.WriteLine("              FINAL");
        Console.WriteLine("======================================");
        Console.WriteLine();

         //pato precidencial
        if (rol == "guardia de pato presidencial")
        {
            if (player.dinero <= 0 || player.energia <= 0 || player.hambre >= 100)
          {
            Console.WriteLine(" LO PERDISTE TODO");
            Console.WriteLine();
            Console.WriteLine("Tus rencuentros han llegado al limite.");
            Console.WriteLine("Ya no tienes dinero, estás completamente agotado y no puedes continuar con el trabajo.");
            Console.WriteLine("El pato presidencial simplemente te mira decepcionado.");
            Console.WriteLine("Has perdido tu trabajo, tu casa, incluso tu dignidad.");
            Console.WriteLine("Realmente debiste cuidarte mas o quizas este muundo es demaciado extraño para ti.");
           }
             else
           { 
              Console.WriteLine(" LA PERSONA MÁS IMPORTANTE DEL PAÍS");
           }
            Console.WriteLine();
            Console.WriteLine("Has sobrevivido a 7 días protegiendo al pato presidencial.");
            Console.WriteLine("El presidente está tan impresionado que decide darte un ascenso.");
            Console.WriteLine("Tu recompensa es enrome.");
            Console.WriteLine("A partir de ese momento, te conviertes en la persona encargada de proteger al pato presidencial permanentemente.");
            Console.WriteLine("me pregunto ¿cuanto duraras?");
        }

        //peces
         if (rol == "traductor de peces")
        {
            if (player.dinero <= 0 || player.energia <= 0 || player.hambre >= 100)
          {
            Console.WriteLine(" LO PERDISTE TODO");
            Console.WriteLine("  ");
            Console.WriteLine("La reunión termina.");
            Console.WriteLine("Todos comienzan a retirarse de la sala.");
            Console.WriteLine(" Tu jefe se acerca.");
            Console.WriteLine(" —Buen trabajo.");
            Console.WriteLine(" Intentas responder.");
            Console.WriteLine(" Pero estás completamente agotado.");
            Console.WriteLine(" Después de siete días de trabajo, traducciones y reuniones con los peces, ya no tienes recursos para continuar.");
            Console.WriteLine(" Miras la pecera.");
            Console.WriteLine(" El pez principal se acerca al vidrio.");
            Console.WriteLine(" —HUMANO.");
            Console.WriteLine(" Lo miras.");
            Console.WriteLine(" —¿Sí?");
            Console.WriteLine(" El pez golpea el vidrio.");
            Console.WriteLine(" Toc.");
            Console.WriteLine(" —BUENA SUERTE.");
            Console.WriteLine(" Recoges tus cosas y abandonas el acuario.");
            Console.WriteLine(" Tu trabajo como traductor de peces ha terminado.");
            Console.WriteLine(" LO PERDISTE TODO... ups, perdon por recordartelo");

           }
             else
           { 
              Console.WriteLine(" EL TRADUCTOR MÁS IMPORTANTE DEL MUNDO");
           }
            Console.WriteLine();
            Console.WriteLine("La sala queda en silencio.");
            Console.WriteLine("Después de unos segundos, todos comienzan a aplaudir.");
            Console.WriteLine("Los representantes de los países se levantan.");
            Console.WriteLine("Los científicos no pueden creer lo que acaba de ocurrir.");
            Console.WriteLine("Tu jefe se acerca lentamente.");
            Console.WriteLine("—Acabas de conseguir algo que nadie había conseguido antes.");
            Console.WriteLine("Miras la gigantesca pecera.");
            Console.WriteLine("Miles de peces nadan formando un círculo.");
            Console.WriteLine("El pez principal se acerca al vidrio.");
            Console.WriteLine("—HUMANO.");
            Console.WriteLine("—¿Sí?");
            Console.WriteLine("—ERES NUESTRO TRADUCTOR.");
            Console.WriteLine("El pez hace una pausa.");
            Console.WriteLine("—Y AHORA ERES IMPORTANTE.");
            Console.WriteLine("Tu jefe te entrega un nuevo contrato.");
            Console.WriteLine("Ya no eres simplemente un traductor de peces.");
            Console.WriteLine("Ahora eres el encargado oficial de las relaciones diplomáticas entre humanos y peces.");
            Console.WriteLine("Tu nuevo título es:");
            Console.WriteLine(" EL TRADUCTOR MÁS IMPORTANTE DEL MUNDO");
            Console.WriteLine("Y tu primer trabajo oficial será traducir una reunión entre los gobiernos humanos...");
            Console.WriteLine("y el gobierno de los peces.");
            Console.WriteLine("El pez principal vuelve a golpear el vidrio.");
            Console.WriteLine("Toc.");
            Console.WriteLine("—NECESITAMOS HABLAR SOBRE EL SALMÓN.");
        }
           //repartidor
          if (rol == "Repartidor de paquetes")
        {
            if (player.dinero <= 0 || player.energia <= 0 || player.hambre >= 100)
          {
            Console.WriteLine(" LO PERDISTE TODO");

            Console.WriteLine("Ya no puedes continuar.");
            Console.WriteLine("No tienes dinero para comprar comida.");
            Console.WriteLine("No tienes energía para seguir trabajando.");
            Console.WriteLine("Y tampoco puedes pagar tu casa.");
            Console.WriteLine("Tu mochila todavía está llena de paquetes.");
            Console.WriteLine("Miras uno de ellos.");
            Console.WriteLine("Tiene una etiqueta:");
            Console.WriteLine("«URGENTE.»");
            Console.WriteLine("Lo dejas en el suelo.");
            Console.WriteLine("Ya no puedes repartirlo.");
            Console.WriteLine("Te sientas.");
            Console.WriteLine("Después de siete días repartiendo paquetes por toda la ciudad...");
            Console.WriteLine("Terminas sin dinero, sin energía y completamente hambriento.");
            Console.WriteLine("Un último paquete aparece junto a ti.");
            Console.WriteLine("Tiene una nota:");
            Console.WriteLine("«GRACIAS POR PARTICIPAR.»");
           }
             else
           { 
              Console.WriteLine(" FINAL: EL REPARTIDOR MÁS IMPORTANTE");
           }
            Console.WriteLine();
            Console.WriteLine("Entregas el último paquete.");
            Console.WriteLine("La persona que lo recibe sonríe.");
            Console.WriteLine("—Has completado todas las entregas.");
            Console.WriteLine("—¿Eso significa que terminé?");
            Console.WriteLine("—No.");
            Console.WriteLine("Señala una enorme oficina detrás de la puerta.");
            Console.WriteLine("Hay cientos de personas esperando.");
            Console.WriteLine("Todas llevan paquetes.");
            Console.WriteLine("—A partir de hoy, tú serás el encargado de todas las entregas de la ciudad.");
            Console.WriteLine("Te entregan un uniforme nuevo.");
            Console.WriteLine("Una mochila nueva.");
            Console.WriteLine("Y una tarjeta.");
            Console.WriteLine("La miras.");
            Console.WriteLine("Dice:");
            Console.WriteLine("DIRECTOR GENERAL DE ENTREGAS");
            Console.WriteLine("Tu salario aumenta.");
            Console.WriteLine("Ya no tienes que caminar por toda la ciudad.");
            Console.WriteLine("Ahora tienes cientos de repartidores trabajando para ti.");
            Console.WriteLine("Tu antiguo jefe aparece.");
            Console.WriteLine("—¿Sabes qué es lo más importante?");
            Console.WriteLine("—¿Qué?");
            Console.WriteLine("Señala el último paquete.");
            Console.WriteLine("—Que todavía falta entregarlo.");
            Console.WriteLine("Miras la caja.");
            Console.WriteLine("Suspiras.");
            Console.WriteLine("La tomas.");
            Console.WriteLine("Y sales a repartirla.");

        }

        //entrendadoer de palomas
         if (rol == "entrenador de palomas")
        {
            if (player.dinero <= 0 || player.energia <= 0 || player.hambre >= 100)
          {
            Console.WriteLine(" LO PERDISTE TODO");
            Console.WriteLine("Ya no puedes continuar trabajando.");
            Console.WriteLine("Las palomas vuelan alrededor de ti.");
            Console.WriteLine("Tu jefe te mira.");
            Console.WriteLine("—Creo que necesitas descansar.");
            Console.WriteLine("Pero ya no puedes pagar comida.");
            Console.WriteLine("No puedes pagar tu casa.");
            Console.WriteLine("Y tampoco puedes continuar con el trabajo.");
            Console.WriteLine("Las palomas se marchan.");
            Console.WriteLine("Una última se queda contigo.");
            Console.WriteLine("Te mira durante unos segundos.");
            Console.WriteLine("Después deja una semilla en el suelo.");
            Console.WriteLine("No puedes evitar pensar:");
            Console.WriteLine("«Al menos alguien se acordó de mí.»");
           }
             else
           { 
              Console.WriteLine(" FINAL: EL IMPERIO DE LAS PALOMAS");
           }
            Console.WriteLine();
            Console.WriteLine("Las palomas te ofrecen un contrato.");
            Console.WriteLine("No es un contrato normal.");
            Console.WriteLine("Es un tratado internacional.");
            Console.WriteLine("Las palomas han decidido reconocerte oficialmente como:");
            Console.WriteLine("ENTRENADOR SUPREMO DE LA NACIÓN PALOMA");
            Console.WriteLine("Tu salario es enorme.");
            Console.WriteLine("Las palomas controlan el sistema de mensajería.");
            Console.WriteLine("Después controlan los servicios de entrega.");
            Console.WriteLine("Después controlan las plazas.");
            Console.WriteLine("Finalmente...");
            Console.WriteLine("Controlan prácticamente toda la ciudad.");
            Console.WriteLine("Tu antiguo jefe te mira desde una ventana.");
            Console.WriteLine("—¿Qué hicimos?");
            Console.WriteLine("Tú observas a miles de palomas marchando perfectamente formadas.");
            Console.WriteLine("Una paloma se acerca y te entrega un documento.");
            Console.WriteLine("Lo lees.");
            Console.WriteLine("Es tu nuevo cargo:");
            Console.WriteLine("MINISTRO DE ASUNTOS HUMANOS DEL IMPERIO DE LAS PALOMAS");
            Console.WriteLine("Miras al cielo.");
            Console.WriteLine("Una paloma pasa volando.");
            Console.WriteLine("Lleva una pequeña corbata.");

        }
        //cuidador de plantas
         if (rol == "cuidador de plantas")
        {
            if (player.dinero <= 0 || player.energia <= 0 || player.hambre >= 100)
          {
            Console.WriteLine(" LO PERDISTE TODO");
            Console.WriteLine("Tus recursos han llegado al límite.");
            Console.WriteLine("Ya no tienes dinero, estás completamente agotado y no puedes continuar con el trabajo.");
            Console.WriteLine("El jardín queda atrás.");
            Console.WriteLine("Has perdido tu trabajo.");
            Console.WriteLine(" Que... que quieres que te diga, me pregunto si sabes por que todo es tan raro, teorias venga.");
           }
             else
           { 
             Console.WriteLine("EL JARDÍN PERFECTO");
           }
            Console.WriteLine();      
            Console.WriteLine("Después de siete días, el dueño observa el jardín y queda completamente sorprendido.");
            Console.WriteLine("Las plantas están cuidadas, el jardín está en perfecto estado y, de alguna manera, la extraña puerta sigue allí.");
            Console.WriteLine("El dueño decide darte una recompensa especial.");
            Console.WriteLine("Desde ese día, te conviertes en el cuidador oficial del jardín.");
        }
    }



    public static string trabajos()
    {
        Console.WriteLine("Escoge tu herramienta: ");
        Console.WriteLine("pistola");
        Console.WriteLine("diccionario");
        Console.WriteLine("alpiste");
        Console.WriteLine("Etiquedador");
        Console.WriteLine("regadera");
        string herramienta = Console.ReadLine();

        string rol;

        if (herramienta == "pistola")
            rol = "guardia de pato presidencial";
        else if (herramienta == "diccionario")
            rol = "traductor de peces";
        else if (herramienta == "alpiste")
            rol = "entrenador de palomas";
        else if (herramienta == "etiquetador")
            rol = "Repartidor de paquetes";
        else
            rol = "cuidador de plantas";

        return rol;
    }
    
}

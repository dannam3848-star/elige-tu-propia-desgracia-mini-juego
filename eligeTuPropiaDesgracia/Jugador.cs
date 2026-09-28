public class Jugador
{
    public string nombre;
    public string rol;
    public int energia;
    public int hambre;
    public int paga;
    
	
	  int[] guardiaDePatoPresidencial = { 90, 50, 100, 5 };
	  int[] traductorDePeces = { 30, 20, 20, 3 };
	  int[] entrenadorDePalomas = { 60, 30, 10, 5 };
	  int[] repartidorDePaquetes = { 80, 80, 50, 2 };
	  int[] cuidadoDePlantas = { 50, 40, 30, 8 };	
	  
	  public Jugador (string nombreElegido, string  rolTemp){
			  nombre = nombreElegido;
			  rol = rolTemp;
		  	asignarCaracteristicas ();
			 
		}
	
     private void asignarCaracteristicas()
	 {
		
	   if (rol == "guardia de pato presidencial"){
	   		energia =  guardiaDePatoPresidencial[0]; 
		    hambre = guardiaDePatoPresidencial[1]; 
			paga = guardiaDePatoPresidencial[2]; 
	       
	      }
	   else if (rol == "traductor de peces"){
	   		energia =  traductorDePeces[0]; 
		    hambre = traductorDePeces[1]; 
			paga = traductorDePeces[2]; 
	      
	      }
		 else if (rol == "entrenador de palomas"){
	   		energia =  entrenadorDePalomas [0]; 
		    hambre = entrenadorDePalomas [1]; 
			paga = entrenadorDePalomas [2]; 
	       
	      }
		  else if (rol == "Repartidor de paquetes"){
	   		energia =   repartidorDePaquetes[0]; 
		    hambre =   repartidorDePaquetes[1]; 
			paga =   repartidorDePaquetes[2]; 
	    
	      }
		  else 
		  { 
	   		energia =   repartidorDePaquetes[0]; 
		    hambre =   repartidorDePaquetes[1]; 
			paga =   repartidorDePaquetes[2]; 
	      ; 
	      }
	 }
	public void mostrarPersoanje()
	{
		Console.Write($"Rol:{rol}  ");
		Console.Write($"nombre:{nombre}  ");
	}

	public void estado()
	{
		Console.Write($"Energia:{energia}  ");
	}
	
}
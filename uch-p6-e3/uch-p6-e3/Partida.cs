using System;

 public class Partida
{
	String eleccion1;
	String eleccion2;

	public Partida()
	{ }
	

	public void Seleccionar(int hilo, String eleccion)
	{
        if (hilo == 1)
        {
            eleccion1 = eleccion;
            Console.WriteLine("1 elije " + eleccion);
        }
        else
        {
            eleccion2 = eleccion;
            Console.WriteLine("2 elije " + eleccion);
        }
    }

	public String Resultado()
    {
        if (eleccion1 == eleccion2)
        {
            return "Empate";
        }
        else if (
            (eleccion1 == "Piedra" && eleccion2 == "Tijera") ||
            (eleccion1 == "Tijera" && eleccion2 == "Papel") ||
            (eleccion1 == "Papel" && eleccion2 == "Piedra")
        )
        {
            return "Jugador 1 gana";
        }
        else
        {
            return "Jugador 2 gana";
        }
    }
   
}


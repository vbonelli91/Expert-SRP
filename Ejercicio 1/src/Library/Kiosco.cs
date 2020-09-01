using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        
        /*
no cumple con SRP, ya que si el cambio del dolar se modifica, la clase no es experta en la información necesaria
para cumplir con la responsabilidad y por ende se deberia modificar la misma

*/
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}

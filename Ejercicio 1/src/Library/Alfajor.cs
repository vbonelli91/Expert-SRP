using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        /*
Cumple con el Expert ya que la información necesaria para poder cumplir con la responsabilidad. 
En cuanto al SRP no se cumple ya que la responsabilidad no se encuentra completamente encapsulada por la clase. 

*/
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}

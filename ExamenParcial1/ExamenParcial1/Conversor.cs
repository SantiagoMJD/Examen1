using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial1
{
    public class Conversor
    {
        //public string Moneda { get; set; }
        public double Monto { get; set; }
        public double total { get; set; }  
        public Conversor() {
           // this.Moneda = "";
            this.Monto = 0; 
            this.total = 0;
        }
        public Conversor(double Monto,double total) {
           // this.Moneda = Moneda;   
            this.Monto = Monto; 
            this.total=total;
        }

        
        }
    
    

}

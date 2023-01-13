using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProyect.PlanPensiones
{
    public class Renta
    {
        public string Name { get; set; }    
        public double facturation { get; set; } 
        public double planPensionesPersonaFisica { get; set; }   
        public double planPensionesEmpresa { get; set; }    

        public Renta() { } 
        public Renta(string Name, double facturation,double planPensionesPersonaFisica) {
        
            this.Name = Name;   
            this.facturation = facturation; 
            this.planPensionesPersonaFisica = planPensionesPersonaFisica;

        }
    }
}

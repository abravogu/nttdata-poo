using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProyect.PlanPensiones
{
    internal class Calcular
    {

        public static double TotaPlanPension(double planPensionesPersonaFisica, double planPensionesEmpresa)
        {
            return planPensionesPersonaFisica + planPensionesEmpresa;
        }

        public static double TotalDesgrabado(Renta rentaPersona)
        {
            if (rentaPersona.facturation < 35.200)
            {
                return TotaPlanPension(rentaPersona.planPensionesPersonaFisica, rentaPersona.planPensionesEmpresa) * 0.3;
            }else if (rentaPersona.facturation < 60.000)
            {
                return TotaPlanPension(rentaPersona.planPensionesPersonaFisica, rentaPersona.planPensionesEmpresa) * 0.37;
            }
            else
            {
                return TotaPlanPension(rentaPersona.planPensionesPersonaFisica, rentaPersona.planPensionesEmpresa) * 0.45;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class ComissionEmployee : Employee
    {
        #region Properties
        public int ComissionPercentage { get; set; }
        public int Sales { get; set; }
        public decimal SalaryComission{ get; set; }
        #endregion

        #region Constructor

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return SalaryComission = Sales * (ComissionPercentage/100);
        }
        public override string ToString()
        {
            return $"{base.ToString()}" + //base es la clase base o la clase padre
                $"Salario Devengado: {SalaryComission:C2}\n\t"; //C2 es para poder ponerlo mas legible el dinero 2000000 = 2.000.000
        }
        #endregion

    }
}

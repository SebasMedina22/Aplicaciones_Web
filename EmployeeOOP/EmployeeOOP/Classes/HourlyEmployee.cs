using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties
        public int Hours { get; set; }
        public decimal HourValue { get; set; }
        public decimal HourlyEmployeeSalary { get; set; }
        #endregion

        #region Constructor
        public HourlyEmployee()
        {
            
        }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return HourlyEmployeeSalary = (Hours * HourValue);
        }
        public override string ToString()
        {
            return $"{base.ToString()}" + //base es la clase base o la clase padre
                $"Salario Devengado por horas: {HourlyEmployeeSalary:C2}\n\t"; //C2 es para poder ponerlo mas legible el dinero 2000000 = 2.000.000
        }
        #endregion

    }
}

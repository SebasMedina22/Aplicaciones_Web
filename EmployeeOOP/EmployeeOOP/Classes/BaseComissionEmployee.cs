using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class BaseComissionEmployee : Employee
    {
        #region Properties
        public int Base{ get; set; }
        #endregion

        #region Constructor
        public BaseComissionEmployee()
        {
            
        }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" + //base es la clase base o la clase padre
                $"Salario Devengado: {Base:C2}\n\t"; //C2 es para poder ponerlo mas legible el dinero 2000000 = 2.000.000
        }
        #endregion




    }
}

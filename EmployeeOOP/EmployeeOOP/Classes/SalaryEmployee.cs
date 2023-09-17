﻿namespace EmployeeOOP.Classes
{
    public class SalaryEmployee : Employee
    {

        #region Properties
        public decimal Salary { get; set; } //Decimal es para trabajar con dinero.
        #endregion

        #region Constructor
        public SalaryEmployee()
        {

        }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" + //base es la clase base o la clase padre
                $"Salario Devengado: {Salary:C2}\n\t";
        }
        #endregion

    }
}

namespace EmployeeOOP.Classes
{
    public class SalaryEmployee : Employee
    {

        #region Properties
        public decimal Salary { get; set; } //Decimal es para trabajar con dinero.
        #endregion

        #region Methods

        #endregion
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" + //base es la clase base o la clase padre
                $"Salario Devengado: {Salary}\n\t";
        }
    }
}

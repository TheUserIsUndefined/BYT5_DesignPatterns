// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            var listEmployee = new List<Employee>();
            
            for (var i = 0; i < employeesArray.GetLength(0); i++)
                listEmployee.Add(
                    new Employee(Convert.ToInt32(employeesArray[i, 0]), employeesArray[i, 1], 
                    employeesArray[i, 2], Convert.ToDecimal(employeesArray[i, 3])));
            
            thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }
}

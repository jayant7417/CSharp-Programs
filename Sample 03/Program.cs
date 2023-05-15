namespace Sample03
{
    class Employee
    {
        public string employeeName;
        public Employee(string empName)
        {
            this.employeeName = empName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Harris");
            Employee emp2 = new Employee();
        }
    }
}

namespace Assinggmnet03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            Employee emp = new Employee(1, "Martin Reda", SecurityLevel.Developer, 12000.5, new DateTime(2023, 3, 15), Gender.M);
            Console.WriteLine(emp);
            #endregion Q03
            // Array 
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Mina", SecurityLevel.DBA, 15000, new HiringDate(10, 1, 2020), Gender.M);
            EmpArr[1] = new Employee(2, "Sara", SecurityLevel.Guest, 5000, new HiringDate(12, 3, 2022), Gender.F);
            EmpArr[2] = new Employee(3, "Officer", SecurityLevel.DBA, 20000, new HiringDate(1, 7, 2023), Gender.M);

            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i]);
            }
            #region
            Console.WriteLine( "hello world ");
            #endregion

            
        }
    }
}

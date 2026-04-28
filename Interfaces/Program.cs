namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IList<IEmployee> employees = new List<IEmployee>();

            SeedData(employees);

            Navigation(employees);
            

            Console.ReadKey();


            //    IEmployee emp1 = new Electrician
            //    {
            //        Id = 1,
            //        JobTitle = "Electrician",
            //        FirstName = "John",
            //        LastName = "Doe",
            //        AnnualSalary = 80000,
            //        JoinDate = new DateTime(2020, 3, 15)
            //    };

            //    IEmployee emp2 = new CraneOperator
            //    {
            //        Id = 2,
            //        JobTitle = "Crane Operator",
            //        FirstName = "Jane",
            //        LastName = "Smith",
            //        AnnualSalary = 90000,
            //        JoinDate = new DateTime(2012, 5, 1)
            //    };

            //    Manager manager1 = new SafetyManager
            //    {
            //        Id = 3,
            //        JobTitle = "Safety Manager",
            //        FirstName = "Alice",
            //        LastName = "Johnson",
            //        AnnualSalary = 120000,
            //        JoinDate = new DateTime(2015, 8, 20),
            //        OfficeId = "SM-101",
            //        SecretaryId = "S-201"

            //    };

            //    Manager manager2 = new ProjectManager
            //    {
            //        Id = 4,
            //        JobTitle = "Project Manager",
            //        FirstName = "Bob",
            //        LastName = "Brown",
            //        AnnualSalary = 150000,
            //        JoinDate = new DateTime(2010, 1, 10),
            //        OfficeId = "PM-202",
            //        SecretaryId = "S-202"
            //    };

            //    ChiefExecutiveOfficer chiefExecutiveOfficer = new ChiefExecutiveOfficer
            //    {
            //        Id = 5,
            //        JobTitle = "Chief Executive Officer",
            //        FirstName = "Charlie",
            //        LastName = "Davis",
            //        AnnualSalary = 300000,
            //        JoinDate = new DateTime(2005, 6, 1),
            //        OfficeId = "CEO-001",
            //        SecretaryId = "S-001",
            //        PersonalAssistant = "PA-001"
            //    };

            //    Console.WriteLine(emp1);
            //    Console.WriteLine(emp1.GetFullYearsWorked());

            //    Console.WriteLine();
            //    Console.WriteLine();

            //    Console.WriteLine(emp2);
            //    Console.WriteLine(emp2.GetFullYearsWorked());
            //    Console.WriteLine();
            //    Console.WriteLine();

            //    Console.WriteLine(manager1);
            //    Console.WriteLine(manager1.GetFullYearsWorked());
            //    Console.WriteLine();
            //    Console.WriteLine();

            //    Console.WriteLine(manager2);
            //    Console.WriteLine(manager2.GetFullYearsWorked());
            //    Console.WriteLine();
            //    Console.WriteLine();

            //    Console.WriteLine(chiefExecutiveOfficer);
            //    Console.WriteLine(chiefExecutiveOfficer.GetFullYearsWorked());
            //    Console.ReadKey();


        }

        public static void SeedData(IList<IEmployee> employees)
        {
            ChiefExecutiveOfficer chiefExecutiveOfficer = new ChiefExecutiveOfficer
            {
                Id = 5,
                JobTitle = "Chief Executive Officer",
                FirstName = "Charlie",
                LastName = "Davis",
                AnnualSalary = 300000,
                JoinDate = new DateTime(2005, 6, 1),
                Gender = 'M',
                HighestQualification = "MBA",
                OfficeId = "CEO-001",
                SecretaryId = "S-001",
                PersonalAssistant = "PA-001"
            };
            employees.Add(chiefExecutiveOfficer);

            SafetyManager safetyManager = new SafetyManager
            {
                Id = 3,
                JobTitle = "Safety Manager",
                FirstName = "Alice",
                LastName = "Johnson",
                AnnualSalary = 120000,
                Gender = 'F',
                HighestQualification = "BSc in Occupational Safety",
                OfficeId = "SM-101",
                SecretaryId = "S-201",
                JoinDate = new DateTime(2015, 8, 20),
            };
            employees.Add(safetyManager);

            ProjectManager projectManager = new ProjectManager
            {
                Id = 4,
                JobTitle = "Project Manager",
                FirstName = "Bob",
                LastName = "Brown",
                AnnualSalary = 150000,
                Gender = 'M',
                HighestQualification = "MBA",
                OfficeId = "PM-202",
                SecretaryId = "S-202",
                JoinDate = new DateTime(2010, 1, 10),
            };
            employees.Add(projectManager);

            CraneOperator craneOperator = new CraneOperator
            {
                Id = 2,
                JobTitle = "Crane Operator",
                FirstName = "Jane",
                LastName = "Smith",
                AnnualSalary = 90000,
                HighestQualification = "High School Diploma",
                JoinDate = new DateTime(2012, 5, 1),
                Gender = 'F'
            };
            employees.Add(craneOperator);

            Employee electrician = new Electrician
            {
                Id = 1,
                JobTitle = "Electrician",
                FirstName = "John",
                LastName = "Doe",
                AnnualSalary = 80000,
                Gender = 'M',
                HighestQualification = "Technical Diploma in Electrical Engineering",
                JoinDate = new DateTime(2020, 3, 15)
            };
            employees.Add(electrician);
        }

        public static void DisplayEmployeeInfo(IEmployee employee)
        {
            Console.Clear();
            WriteHeading();

            Console.WriteLine(employee.GetBasicInfo());


            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine(employee.GetAdditionalInfo());
        }

        public static void WriteHeading()
        {
            Console.WriteLine("The Construction Company");
            Console.WriteLine("---------------");
            Console.WriteLine();


        }

        private static void Navigation(IList<IEmployee> employees)
        {
            int counter = 0;

            while (true)
            {
                if (counter < 0 || counter > employees.Count - 1)
                {
                    counter = 0;
                }

                DisplayEmployeeInfo(employees[counter]);

                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.RightArrow)
                {
                    counter++;
                }
                else if (consoleKey == ConsoleKey.LeftArrow)
                {
                    counter--;
                }
                else if (consoleKey == ConsoleKey.Spacebar)
                {
                    break;
                }
            }

        }
    }
}

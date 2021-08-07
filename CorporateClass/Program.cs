using System;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Company UniversalPaperclips = new Company("Universal Paperclips", DateTime.Now);

            Employee Ben = new Employee("Ben", "CEO", DateTime.Now);
            UniversalPaperclips.AddEmployee(Ben);

            Employee Martin = new Employee("Martin", "Supervisor", DateTime.Now);
            UniversalPaperclips.AddEmployee(Martin);

            Employee Jonathan = new Employee("Jonathan", "Paperclip Forge Operator", DateTime.Now);
            UniversalPaperclips.AddEmployee(Jonathan);

            UniversalPaperclips.ListEmployees();


            Company ApertureScience = new Company("Aperture Science Laboratories Computer-Aided Enrichment Center", DateTime.Now);

            Employee Chie = new Employee("Chie", "CEO", DateTime.Now);
            ApertureScience.AddEmployee(Chie);

            Employee HoneyRae = new Employee("Honey-Rae", "Supervisor", DateTime.Now);
            ApertureScience.AddEmployee(HoneyRae);

            Employee Casey = new Employee("Casey", "Test Subject", DateTime.Now);
            ApertureScience.AddEmployee(Casey);

            ApertureScience.ListEmployees();
        }
    }
}

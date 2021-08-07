using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateClass
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Title { get; private set; }
        public DateTime StartDate { get; }

        public Employee(string name, string title, DateTime startDate)
        {
            Name = name;
            Title = title;
            StartDate = startDate;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }

        public void ChangePosition(string newTitle)
        {
            Title = newTitle;
        }
    }
}

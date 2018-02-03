using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmLightEmployee.ViewModel
{
    public class Employee : ObservableObject
    {
        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                Set<int>(() => this.ID, ref id, value);
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                Set<string>(() => this.Name, ref name, value);
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                Set<int>(() => this.Age, ref age, value);
            }
        }
        private decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                Set<decimal>(() => this.Salary, ref salary, value);
            }
        }

        public static ObservableCollection<Employee> GetSampleEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            for (int i = 0; i < 30; ++i)
            {
                employees.Add(new Employee
                {
                    ID = i + 1,
                    Name = "Name " + (i + 1).ToString(),
                    Age = 20 + i,
                    Salary = 20000 + (i * 10)
                });
            }
            return employees;
        }
    }
}

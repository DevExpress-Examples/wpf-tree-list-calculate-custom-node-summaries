﻿using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomNodeSummaries_MVVM {
    public class Employee {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public double Statistics { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
    }

    class MainViewModel : ViewModelBase {
        public ObservableCollection<Employee> Employees { get; set; }

        public MainViewModel() {
            Employees = new ObservableCollection<Employee>(GetEmployees());
        }

        [Command]
        public void CustomSummaryCommand(NodeSummaryArgs args) {
            if(args.IsNodeSummary && args.SummaryItem.PropertyName == nameof(Employee.Statistics)) {
                if(args.SummaryProcess == SummaryProcess.Calculate) {
                    args.TotalValue = Convert.ToDouble(args.TotalValue) + (double)args.FieldValue;
                }
            }
        }

        IEnumerable<Employee> GetEmployees() {
            yield return new Employee() { ID = 1, ParentID = 0, Name = "Gregory S. Price", Statistics = 2350, Department = "", Position = "President" };
            yield return new Employee() { ID = 2, ParentID = 1, Name = "Irma R. Marshall", Statistics = 2150, Department = "Marketing", Position = "Vice President" };
            yield return new Employee() { ID = 3, ParentID = 1, Name = "John C. Powell", Statistics = 3350, Department = "Operations", Position = "Vice President" };
            yield return new Employee() { ID = 4, ParentID = 1, Name = "Christian P. Laclair", Statistics = 2350, Department = "Production", Position = "Vice President" };
            yield return new Employee() { ID = 5, ParentID = 1, Name = "Karen J. Kelly", Statistics = 1350, Department = "Finance", Position = "Vice President" };

            yield return new Employee() { ID = 6, ParentID = 2, Name = "Brian C. Cowling", Statistics = 1650, Department = "Marketing", Position = "Manager" };
            yield return new Employee() { ID = 7, ParentID = 2, Name = "Thomas C. Dawson", Statistics = 1050, Department = "Marketing", Position = "Manager" };
            yield return new Employee() { ID = 8, ParentID = 2, Name = "Angel M. Wilson", Statistics = 2500, Department = "Marketing", Position = "Manager" };
            yield return new Employee() { ID = 9, ParentID = 2, Name = "Bryan R. Henderson", Statistics = 250, Department = "Marketing", Position = "Manager" };

            yield return new Employee() { ID = 10, ParentID = 3, Name = "Harold S. Brandes", Statistics = 350, Department = "Operations", Position = "Manager" };
            yield return new Employee() { ID = 11, ParentID = 3, Name = "Michael S. Blevins", Statistics = 3550, Department = "Operations", Position = "Manager" };
            yield return new Employee() { ID = 12, ParentID = 3, Name = "Jan K. Sisk", Statistics = 1750, Department = "Operations", Position = "Manager" };
            yield return new Employee() { ID = 13, ParentID = 3, Name = "Sidney L. Holder", Statistics = 1900, Department = "Operations", Position = "Manager" };

            yield return new Employee() { ID = 14, ParentID = 4, Name = "James L. Kelsey", Statistics = 5010, Department = "Production", Position = "Manager" };
            yield return new Employee() { ID = 15, ParentID = 4, Name = "Howard M. Carpenter", Statistics = 3400, Department = "Production", Position = "Manager" };
            yield return new Employee() { ID = 16, ParentID = 4, Name = "Jennifer T. Tapia", Statistics = 2350, Department = "Production", Position = "Manager" };

            yield return new Employee() { ID = 17, ParentID = 5, Name = "Judith P. Underhill", Statistics = 2950, Department = "Finance", Position = "Manager" };
            yield return new Employee() { ID = 18, ParentID = 5, Name = "Russell E. Belton", Statistics = 2150, Department = "Finance", Position = "Manager" };
        }
    }
}

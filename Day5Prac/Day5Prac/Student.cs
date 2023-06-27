using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Prac
{
    public class Student
    {
        // Fields or Properties or Variables
        public string NameOfStudent { get; set; }
        public int StudyHoursPerWeek { get; set; }
        public int StudyWeeksCompleted { get; set; }
        //Stirng to be able to share the output
        public string OutputStorage { get; set; }
        // Functions or Methods or Behaviours or Actions
        public void BuildStudentInformation()
        {
            this.OutputStorage = $" Student Name : {this.NameOfStudent} Study Hours : {this.StudyHoursPerWeek} Number of weeks Completed : {this.StudyWeeksCompleted}";
        }
        public void DisplayStudentInformation()
        {
            Console.WriteLine(this.OutputStorage);
        }
    }
}

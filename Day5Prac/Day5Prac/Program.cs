// See https://aka.ms/new-console-template for more information
using Day5Prac;

Console.WriteLine("Hello, World!");

#region old code format
/*// student called 
Student Pregozhin = new Student();
Student Alexandria = new Student();

// Assigning the students to numbers
Pregozhin.NameOfStudent = "Pregozhin";
Pregozhin.StudyHoursPerWeek= 35;
Pregozhin.StudyWeeksCompleted= 0;

Alexandria.NameOfStudent = "Alexandria";
Alexandria.StudyHoursPerWeek = 15;
Alexandria.StudyWeeksCompleted = 10;

string outputforPreg = $" Student Name : {Pregozhin.NameOfStudent} Study Hours : {Pregozhin.StudyHoursPerWeek} Number of weeks Completed : {Pregozhin.StudyWeeksCompleted}";

string outputforAlex = $" Student Name : {Alexandria.NameOfStudent} Study Hours : {Alexandria.StudyHoursPerWeek} Number of weeks Completed : {Alexandria.StudyWeeksCompleted}";

Console.WriteLine(outputforPreg);
Console.WriteLine(outputforAlex);*/
#endregion

#region New coding format
// Student Pregozhin
Student Pregozhin = new Student();
Pregozhin.NameOfStudent = "Pregozhin";
Pregozhin.StudyHoursPerWeek = 25;
Pregozhin.StudyWeeksCompleted = 0;
Pregozhin.BuildStudentInformation();
Pregozhin.DisplayStudentInformation();

// Student Alexandria
Student Alexandria = new Student();
Alexandria.NameOfStudent = "Alexandria";
Alexandria.StudyHoursPerWeek = 10;
Alexandria.StudyWeeksCompleted = 10;
Alexandria.BuildStudentInformation();
Alexandria.DisplayStudentInformation();

// Student Russell
Student Russell = new Student();
Russell.NameOfStudent = "Russell";
Russell.StudyHoursPerWeek = 30;
Russell.StudyWeeksCompleted = 35;
Russell.BuildStudentInformation();
Russell.DisplayStudentInformation();
#endregion

// It takes 500 hours to become a beginner developer
int TotalBeginnerDeveloperHours = 500;

/// 20 hours per week
/// 25 weeks to become a beginner developer
/// number of weeks already competed is 0
/// remaining weeks = 25 - 0 = 25 weeks
/// Ultimately, Pregozhin will become a developer in 25 weeks

/// 10 hours per week
/// 50 weeks to become a beginner developer
/// number of weeks already completed is 10
/// remaning weeks = 50 - 10 = 40 weeks
/// Ultimately, Alexandria will become a developer in 40 weeks
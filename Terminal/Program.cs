using System.Diagnostics.CodeAnalysis;
using Terminal;
using static System.Console;
//1
//2
Student[] students =
[
    new() {StID = 1, LastName = "Carson"},
     new() {StID = 2, LastName = "Klassen"},
      new()  {StID = 3, LastName = "Fleming"}
];
CourseStudent[] studentInCourse =
[
    new() {CourseName = "Art",StID = 1},
    new() {CourseName = "Art",StID = 2},
    new() {CourseName = "History",StID = 1},
    new() {CourseName = "History",StID = 3},
    new() {CourseName = "Physics",StID = 3},
];
var query = from s in students join c in studentInCourse on s.StID equals c.StID where c.CourseName == "History" select s.LastName;
foreach(var q in query)
{
    Console.WriteLine($"Student taking History: {q}");
}
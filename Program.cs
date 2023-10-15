using LINQDataContext;

internal class Program
{
    private static void Main(string[] args)
    {
        DataContext dc = new DataContext();

        //EX 2.2 
        // Console.WriteLine("EXO 2.2");

        //var students = from student in dc.Students
        //               select new { 
        //                   FullName = student.First_Name + " "+ student.Last_Name, 
        //                   DateNaiss = student.BirthDate,
        //                   ID = student.Student_ID 
        //               };

        //foreach (var student in students)
        //{
        //    Console.WriteLine("{0} {1} {2}", student.FullName, student.ID, student.DateNaiss);
        //}


        //Console.WriteLine("-------------------------------------------");
        ////EX 3.1
        //Console.WriteLine("EXO 3.1");


        //var students = from student in dc.Students
        //    .Where(s => s.BirthDate.Year < 1955)
        //    select new
        //    {
        //        FullName = student.First_Name, LastName = student.Last_Name,
        //        Resultat = student.Year_Result,
        //        Statut = (student.Year_Result >= 12) ? "OK" : "KO"
        //    };

        //foreach (var student in students)
        //{
        //    Console.WriteLine(student);
        //}

        //EXO 3.4 version : méthode requête de LINQ
        //Console.WriteLine("EXO 3.4");

        //var students = from Student s in dc.Students
        //               where (s.Year_Result <= 3)
        //               orderby (s.Year_Result) descending
        //               select new
        //               {
        //                   FullName = s.First_Name + " " + s.Last_Name,
        //                   Resultat = s.Year_Result
        //               };

        //foreach (var student in students)
        //{
        //    Console.WriteLine(student.FullName + " " + student.Resultat);
        //}

        /*
         * 3.4 version: méthode de LINQ
         *  var students = from student in dc.Students
                        .Where(c => c.Year_Result <= 3)
                       orderby (student.Year_Result) descending
                       select new
                       {
                           FullName = student.First_Name + " " + student.Last_Name,
                           Resultat = student.Year_Result
                       };

         */

        //EXO 3.5
        //Console.WriteLine("EXO 3.5");

        //var students = from Student s in dc.Students
        //               where (s.Section_ID == 1110)
        //               orderby (s.Last_Name)
        //               select new
        //               {
        //                   s.First_Name,
        //                   s.Last_Name,
        //                   s.Section_ID,
        //                   s.Year_Result
        //               };

        //foreach (var student in students)
        //{
        //    Console.WriteLine(student.First_Name + " " + student.Last_Name + " "
        //        + student.Year_Result + " " + student.Section_ID);
        //}


        //EXO 4.1
        // Console.WriteLine("EXO 4.1");

        //double moyenne = dc.Students.Average(s => s.Year_Result);
        //Console.WriteLine("Moyenne des étudiants: "+ moyenne);

        //EXO 4.5
        // Console.WriteLine("Nb lignes de la table students : " + dc.Students.Count());


        //EXO 5.1
        //Console.WriteLine("EXO 4.5");

        //var students = (from Student student in dc.Students
        //                group student by student.Section_ID into groupedSection
        //                select new
        //                {
        //                    Category = groupedSection.Key,
        //                    Max_Result = groupedSection.Max(s => s.Year_Result)
        //                }).ToList();

        //foreach (var student in students)
        //{
        //    Console.WriteLine(student.Category + " " + student.Max_Result);
        //}


        //EXO 5.3
        //Console.WriteLine("EXO 5.3");

        //var students = from Student s in dc.Students
        //               where (s.BirthDate.Year >= 1970 && s.BirthDate.Year <= 1985)
        //               group s by s.BirthDate.Month into groupedStudents
        //               select new
        //               {
        //                   BirthMonth = groupedStudents.Key,
        //                   AVG_Result = groupedStudents.Average(s => s.Year_Result)
        //               };

        //foreach (var student in students)
        //{
        //    Console.WriteLine("Month: "+student.BirthMonth + " Average: " + student.AVG_Result);
        //}



        //EXO 5.5
        Console.WriteLine("EXO 5.5");
        // jointure manuelle sans le join
        //var courses = from Course c in dc.Courses
        //              from Professor p in dc.Professors
        //              from Section s in dc.Sections
        //              where (c.Professor_ID == p.Professor_ID
        //              && s.Section_ID == p.Section_ID)
        //              select new
        //              {
        //                  Course_name = c.Course_Name,
        //                  Section_name = s.Section_Name,
        //                  Professor_name = p.Professor_Name
        //              };

        //avec le join
        //var courses = from Course c in dc.Courses
        //              join p in dc.Professors on c.Professor_ID equals p.Professor_ID
        //              join s in dc.Sections on p.Section_ID equals s.Section_ID
        //              select new
        //              {
        //                  c.Course_Name,
        //                  s.Section_Name,
        //                  p.Professor_Name
        //              };

        //foreach (var course in courses)
        //{
        //    Console.WriteLine(course.Course_Name + " " + course.Section_Name+
        //        " "+ course.Professor_Name);
        //}

        //EXO 5.7

        //var resultQuery = (from s in dc.Sections
        //                   join p in dc.Professors on s.Section_ID equals p.Section_ID into professorsGroup
        //                   select new
        //                   {
        //                       SectionID = $"{s.Section_ID} : ",
        //                       Professors = professorsGroup.Select(p => p.Professor_Name)
        //                   });

        //foreach (var item in resultQuery)
        //{
        //    Console.WriteLine("Section n°" + item.SectionID);
        //    foreach (var prof in item.Professors)
        //    {
        //        Console.WriteLine("\t -" + prof);
        //    }
        //}





    }
}
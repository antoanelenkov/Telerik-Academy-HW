using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Test
    {
        static void Main(string[] args)
        {
            //Make some disciplines
            Disciplines math2 = new Disciplines("Math 2", 5, 5);
            Disciplines math = new Disciplines("Math 1", 5, 4, new Comment("math is awful"));
            Disciplines physics=new Disciplines("Physics",9,5);
            Disciplines georaphy=new Disciplines("Geography",5,8);
            Disciplines informatcs=new Disciplines("Informatics",5,12);
            Disciplines foreignLanguage=new Disciplines("English",5,5);
            Disciplines foreignLanguage2=new Disciplines("Fluent English",5,5);

            //Make some teachers
            Teacher mimeto = new Teacher("Maria", math2, math, physics);
            Teacher BabaQga=new Teacher("Baba Qga",new Comment("loshata baba qga"),foreignLanguage,foreignLanguage2);

            //Make some student classes
            StudentsClass Aclass = new StudentsClass(mimeto, BabaQga);
            StudentsClass Bclass = new StudentsClass(mimeto);

            //Make some students
            Student Georgi = new Student("Georgi", 1);
            Student Antoan = new Student("Antoan", 2);
            Student Petar = new Student("Petar", 2,new Comment("dvoikar"));
            Student Ivan = new Student("Ivan", 2);
            //Student Ivann = new Student("Ivann", 3); This will cause exception, beacuse there is no class with ID=3; Check out how i make the verification
            Ivan.Comment = new Comment("marzel");
        }
    }
}

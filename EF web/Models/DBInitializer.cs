﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_web.Models
{
    public class DBInitializer : System.Data.Entity.DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {

            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            // создаем две роли
            var role1 = new IdentityRole { Name = "admin" };
            var role2 = new IdentityRole { Name = "user" };

            // добавляем роли в бд
            roleManager.Create(role1);
            roleManager.Create(role2);

            // создаем пользователей
            var admin = new ApplicationUser { Email = "elis.tkachuk@gmail.com", UserName = "elis.tkachuk@gmail.com" };
            string password = "Twente!383";
            var result = userManager.Create(admin, password);

            // если создание пользователя прошло успешно
            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(admin.Id, role1.Name);
                userManager.AddToRole(admin.Id, role2.Name);
            }

            base.Seed(context);
        
    
    var students = new List<Student>
{
new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
};
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
{
new Course{CourseID=1050,Title="Chemistry",Credits=3,},
new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
new Course{CourseID=1045,Title="Calculus",Credits=4,},
new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
new Course{CourseID=2021,Title="Composition",Credits=3,},
new Course{CourseID=2042,Title="Literature",Credits=4,}
};
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
{
new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
new Enrollment{StudentID=3,CourseID=1050},
new Enrollment{StudentID=4,CourseID=1050,},
new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
new Enrollment{StudentID=6,CourseID=1045},
new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
};
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
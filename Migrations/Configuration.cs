namespace DotvvmApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ContosoUniversityModelBinding.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ContosoUniversityModelBinding.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContosoUniversityModelBinding.Models.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Students.AddOrUpdate(
                new Student
                {
                    FirstName = "Carson",
                    LastName = "Alexander",
                    Year = AcademicYear.Freshman
                },
                new Student
                {
                    FirstName = "Meredith",
                    LastName = "Alonso",
                    Year = AcademicYear.Freshman
                },
                new Student
                {
                    FirstName = "Arturo",
                    LastName = "Anand",
                    Year = AcademicYear.Sophomore
                },
                new Student
                {
                    FirstName = "Gytis",
                    LastName = "Barzdukas",
                    Year = AcademicYear.Sophomore
                },
                new Student
                {
                    FirstName = "Yan",
                    LastName = "Li",
                    Year = AcademicYear.Junior
                },
                new Student
                {
                    FirstName = "Peggy",
                    LastName = "Justice",
                    Year = AcademicYear.Junior
                },
                new Student
                {
                    FirstName = "Laura",
                    LastName = "Norman",
                    Year = AcademicYear.Senior
                },
                new Student
                {
                    FirstName = "Nino",
                    LastName = "Olivetto",
                    Year = AcademicYear.Senior
                }
                );

            context.SaveChanges();

        }
    }
}

namespace AdminSchool.Migrations
{
    using AdminSchool.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AdminSchool.DataAccesslayer.SutdentRegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AdminSchool.DataAccesslayer.SutdentRegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.StudentDatas.AddOrUpdate(x => x.SchoolClass,
                new StudentData()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Age = 12,
                    SchoolClass = Models.SchoolClass.Eleven,
                    FavouritTopic = Models.FavouritTopic.Geography,
                },
                new StudentData()
                {
                    FirstName = "Samantha",
                    LastName = "Eriksson",
                    Age = 9,
                    SchoolClass = Models.SchoolClass.First,
                    FavouritTopic = Models.FavouritTopic.Fysiks,
                },
                new StudentData()
                {
                    FirstName = "Ema",
                    LastName = "Ekero",
                    Age = 6,
                    SchoolClass = Models.SchoolClass.Nein,
                    FavouritTopic = Models.FavouritTopic.Literatur,
                },
                new StudentData()
                {
                    FirstName = "Jack",
                    LastName = "Banderas",
                    Age = 15,
                    SchoolClass = Models.SchoolClass.Ten,
                    FavouritTopic = Models.FavouritTopic.Sport,
                }
                );
            context.Schoolteachers.AddOrUpdate(y => y.Position,
            new SchoolTeacher()
            {
                FirstName = "John",
                LastName = "Johansson",
                Age = 50,
                Salary = 25000,
                Position = "Mathematic teacher",
            },
            new SchoolTeacher()
            {
                FirstName = "Helena",
                LastName = "Nykvist",
                Age = 35,
                Salary = 26000,
                Position = "Sport teacher"
            },
            new SchoolTeacher()
            {
                FirstName = "Adam",
                LastName = "Jansson",
                Age = 40,
                Salary = 40000,
                Position = "Admin",
            }
            );
            context.Sports.AddOrUpdate(t => t.Football,
                new Sport()
                {
                    Football = "Redteam",
                    Basketball = "Bluteam",
                    Tennis = "yellowteam",
                    Ragkpi = "Blackteam",
                    Hoky = "Whiteteam",
                },
                new Sport()
                {
                    Football = "TigerTeam",
                    Basketball ="Fastteam",
                    Tennis = "I.F.M team",
                    Ragkpi = "Tankteam",
                    Hoky = "AwesomeTeam",
                }

                
                );
        }
    }
}

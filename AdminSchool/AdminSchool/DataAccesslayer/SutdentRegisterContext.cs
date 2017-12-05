using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AdminSchool.DataAccesslayer
{
    public class SutdentRegisterContext : DbContext
    {
        public SutdentRegisterContext(): base ("School") {} //my database name
        public DbSet<Models.StudentData> StudentDatas { get; set; }
        public DbSet<Models.SchoolTeacher> Schoolteachers { get; set; }
        public DbSet<Models.Sport> Sports { get; set; }
    }
}
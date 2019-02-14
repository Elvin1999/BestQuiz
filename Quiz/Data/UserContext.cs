using Quiz.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Data
{
    class UserContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext():base("UserDB")
        {
                
        }
    }
}

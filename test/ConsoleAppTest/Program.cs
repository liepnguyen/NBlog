using Planru.Auth.Core.Persistence.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new ApplicationDbContext())
            {
                db.SaveChanges();
            }
        }
    }
}

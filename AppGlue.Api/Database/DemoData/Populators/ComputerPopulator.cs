using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppGlue.Api.Database.Entities;


namespace AppGlue.Api.Database.DemoData.Populators
{
    public class ComputerPopulator
    {
        private const int NumComputers = 1000;

        public ComputerPopulator(AppGlueDbContext db)
        {
            for (var i = 1; i <= 1000; i++)
            {
                db.Computers.Add(new Computer
                {
                    Name = $"host{i}",
                    SerialNumber = Guid.NewGuid().ToString()
                });
            }

            db.SaveChanges();
        }
    }
}

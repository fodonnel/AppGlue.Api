using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppGlue.Api.Database.DemoData.Populators;

namespace AppGlue.Api.Database.DemoData
{
    public interface IDemoDataPopulator
    {
        bool IsDataLoaded();
        void Load();
    }

    public class DemoDataPopulator : IDemoDataPopulator
    {
        private readonly AppGlueDbContext _db;

        public DemoDataPopulator(AppGlueDbContext db)
        {
            _db = db;
        }

        public bool IsDataLoaded()
        {
            return _db.Computers.Any();
        }

        public void Load()
        {
            if (IsDataLoaded())
            {
                return;
            }

            new ComputerPopulator(_db);
        }
    }
}

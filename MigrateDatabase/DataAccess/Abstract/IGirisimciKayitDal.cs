﻿using MigrateDatabase.Entities.Concrete.NewDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrateDatabase.DataAccess.Abstract
{
    public interface IGirisimciKayitDal
    {
        void Add(GirisimciKayit girisimciKayit);
    }
}

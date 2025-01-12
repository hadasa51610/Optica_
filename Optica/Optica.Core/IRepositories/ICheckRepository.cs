﻿using Optica.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica.Core.IRepositories
{
    public interface ICheckRepository:IRepository<Check>
    {
        List<Check> GetFull();
    }
}

﻿using Data.Model;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IRoleService
    {
        IEnumerable<Role> Get();
        Role Get(int Id);
        int Create(RoleVM roleVM);
        int Update(int Id, RoleVM roleVM);
        int Delete(int Id);
    }
}

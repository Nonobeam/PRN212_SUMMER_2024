﻿using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    internal interface IUser
    {
        IEnumerable<Dentist> GetDentistsByClinic(string clinicId);
        User GetUserById(int id);
    }
}

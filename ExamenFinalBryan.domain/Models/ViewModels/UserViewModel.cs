﻿using ExamenFinalBryan.domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalBryan.domain.Models.ViewModels
{
        public class UserViewModel
        {
            public IEnumerable<User> Users { get; set; }
        }
}

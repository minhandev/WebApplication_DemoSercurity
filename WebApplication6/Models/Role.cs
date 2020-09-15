﻿using System;
using System.Collections.Generic;

namespace WebApplication6.Models
{
    public partial class Role
    {
        public Role()
        {
            AccountRole = new HashSet<AccountRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AccountRole> AccountRole { get; set; }
    }
}

﻿using Accoon.Pitshop.CustomerApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accoon.Pitshop.CustomerApi.Domain.Entities
{
    public class Customer : Entity<Guid>
    {
        public Customer()
        {
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}

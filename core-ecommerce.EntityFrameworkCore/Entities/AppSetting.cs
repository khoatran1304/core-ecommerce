﻿using System;
using System.Collections.Generic;
using System.Text;

namespace core_ecommerce.EntityFrameworkCore.Entities
{
    public class AppSetting
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    }
}

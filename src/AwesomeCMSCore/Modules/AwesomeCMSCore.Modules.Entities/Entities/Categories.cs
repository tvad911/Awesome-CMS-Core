﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeCMSCore.Modules.Entities.Entities
{
    public class Categories : BaseEntity
    {
        public string CategoriesData { get; set; }
        public string CategoriesOptions { get; set; }
        public string UserId { get; set; }
    }
}

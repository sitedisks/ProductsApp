﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ProductsApp.Model
{
    public class DBConn
    {
        public class DBContext : DbContext
        {
            public DbSet<Product> Products { get; set; }
        }
    }
}
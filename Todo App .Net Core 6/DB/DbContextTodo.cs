﻿using Microsoft.EntityFrameworkCore;

namespace Todo_App_.Net_Core_6.DB
{
    public class DbContextTodo : DbContext
    {
        // definition des tables de la base de données

        public DbContextTodo(DbContextOptions options) : base(options)
        {
        }

    }
}

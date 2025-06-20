﻿using BooksApi.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BooksApi.Entities.Context
{
    public class BookDbContext(DbContextOptions<BookDbContext> options) : DbContext(options)
    {
        public DbSet<BookDetails> BookDetails { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
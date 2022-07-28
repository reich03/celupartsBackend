﻿using Microsoft.EntityFrameworkCore;

namespace CelupartsPoC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<UserDto> UsersDto { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<RequestState> RequestStates { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }
    }
}

using Building.DataLayer.Entities.Course;
using Building.DataLayer.Entities.House;
using Building.DataLayer.Entities.Order;
using Building.DataLayer.Entities.Permission;
using Building.DataLayer.Entities.User;
using Building.DataLayer.Entities.Wallet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.DataLayer.Context
{
    public class BuildingContext:DbContext
    {
        public BuildingContext(DbContextOptions<BuildingContext> options):base(options)
        {

        }


        #region User
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion

        #region Wallet
        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        #endregion

        #region Permission
        public DbSet<Permission> Permission { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }

        #endregion

        #region Course
        public DbSet<CourseGroup> CourseGroups { get; set; }
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<CourseEpisode> CourseEpisodes { get; set; }
        //public DbSet<CourseLevel> CourseLevels { get; set; }
        //public DbSet<CourseStatus> CourseStatuses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Bulletin> Bulletins { get; set; }
        #endregion

        #region House
        public DbSet<HouseInformation> HouseInformations { get; set; }
        public DbSet<HouseRole> HouseRoles { get; set; }
        public DbSet<UserToHouse> UserToHouses { get; set; }
        #endregion

        #region Order
        public DbSet<Order> Orders { get; set; }
        public DbSet<Course> Courses { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);
            modelBuilder.Entity<Role>()
                .HasQueryFilter(r => !r.IsDelete);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CourseGroup>()
                .HasQueryFilter(g => !g.IsDelete);
        }
    }
}

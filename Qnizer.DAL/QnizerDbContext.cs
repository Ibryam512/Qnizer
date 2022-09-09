using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Qnizer.DAL.Entities;
using System;

namespace Qnizer.DAL
{
    public class QnizerDbContext : IdentityDbContext<ApplicationUser>
    {
        public new DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Todo> Todos { get; set; }

        public QnizerDbContext(DbContextOptions<QnizerDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>(entity => 
            {
                entity.Property(user => user.CreatedAt)
                    .HasDefaultValue(DateTime.Now);

                entity.Property(user => user.UpdatedAt)
                    .HasDefaultValue(DateTime.Now);
            });

            modelBuilder.Entity<Todo>(entity => 
            {
                entity.Property(todo => todo.CreatedAt)
                    .HasDefaultValue(DateTime.Now);

                entity.Property(todo => todo.UpdatedAt)
                    .HasDefaultValue(DateTime.Now);

                entity.HasOne(todo => todo.User)
                    .WithMany(user => user.Todos)
                    .HasForeignKey(todo => todo.UserId);
            });

            modelBuilder.Entity<Subject>(entity => 
            {
                entity.Property(subject => subject.CreatedAt)
                    .HasDefaultValue(DateTime.Now);

                entity.Property(subject => subject.UpdatedAt)
                    .HasDefaultValue(DateTime.Now);

                entity.HasMany(subject => subject.Classes)
                    .WithOne(clss => clss.Subject)
                    .HasForeignKey(clss => clss.SubjectId);

                entity.HasMany(subject => subject.Materials)
                    .WithOne(material => material.Subject)
                    .HasForeignKey(material => material.SubjectId);
            });

            modelBuilder.Entity<Class>(entity => 
            {
                entity.Property(clss => clss.CreatedAt)
                    .HasDefaultValue(DateTime.Now);

                entity.Property(clss => clss.UpdatedAt)
                    .HasDefaultValue(DateTime.Now);

                entity.HasOne(clss => clss.User)
                    .WithMany(user => user.Classes)
                    .HasForeignKey(clss => clss.UserId);
            });

            modelBuilder.Entity<Material>(entity => 
            {
                entity.Property(material => material.CreatedAt)
                    .HasDefaultValue(DateTime.Now);

                entity.Property(material => material.UpdatedAt)
                    .HasDefaultValue(DateTime.Now);

                entity.HasOne(material => material.User)
                    .WithMany(user => user.Materials)
                    .HasForeignKey(material => material.UserId);
            });
        }
    }
}
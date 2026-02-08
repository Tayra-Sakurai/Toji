using Microsoft.EntityFrameworkCore;
using Windows.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzumasa.Models;
using System.IO;

namespace Uzumasa.Contexts
{
    public partial class UzumasaContext : DbContext
    {
        public DbSet<Datumn> Data { get; set; }

        private string DbPath { get; }

        public UzumasaContext ()
        {
            var folder = ApplicationData.Current.LocalFolder.Path;
            DbPath = Path.Combine(folder, "Uzumasa.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                $"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Datumn>(
                t =>
                {
                    t.ToTable("Data");

                    t.HasKey(e => e.Id);

                    t.Property(e => e.DateTime)
                    .IsRequired()
                    .HasConversion(
                        e => e.ToString("o"),
                        e => DateTime.Parse(e)
                    );

                    t.Property(e => e.Item)
                    .IsRequired();

                    t.Property(e => e.Cash)
                    .IsRequired()
                    .HasDefaultValue(0);
                    t.Property(e => e.Icoca)
                    .IsRequired()
                    .HasDefaultValue(0);
                    t.Property(e => e.Nanaco)
                    .IsRequired()
                    .HasDefaultValue(0);
                    t.Property(e => e.Coop)
                    .IsRequired()
                    .HasDefaultValue(0);
                }
            );
        }
    }
}

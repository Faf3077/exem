using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace knigniMagazin
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Автор> Автор { get; set; }
        public virtual DbSet<Жанр> Жанр { get; set; }
        public virtual DbSet<Издательство> Издательство { get; set; }
        public virtual DbSet<Книги> Книги { get; set; }
        public virtual DbSet<Отчет> Отчет { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Продажи> Продажи { get; set; }
        public virtual DbSet<Стеллаж> Стеллаж { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Автор>()
                .HasMany(e => e.Книги)
                .WithMany(e => e.Автор)
                .Map(m => m.ToTable("АвторКнига").MapLeftKey("IDАвтор").MapRightKey("IDКнига"));

            modelBuilder.Entity<Жанр>()
                .HasMany(e => e.Книги)
                .WithRequired(e => e.Жанр)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Издательство>()
                .HasMany(e => e.Книги)
                .WithRequired(e => e.Издательство)
                .HasForeignKey(e => e.IDИздательства)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Книги>()
                .Property(e => e.Цена)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Книги>()
                .HasMany(e => e.Продажи)
                .WithMany(e => e.Книги)
                .Map(m => m.ToTable("ПродажаКниги").MapLeftKey("IDКнига").MapRightKey("IDПродажи"));

            modelBuilder.Entity<Отчет>()
                .Property(e => e.ИтогЗаМесяц)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Продажи>()
                .HasMany(e => e.Отчет)
                .WithRequired(e => e.Продажи)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Стеллаж>()
                .HasMany(e => e.Книги)
                .WithRequired(e => e.Стеллаж)
                .WillCascadeOnDelete(false);
        }
    }
}

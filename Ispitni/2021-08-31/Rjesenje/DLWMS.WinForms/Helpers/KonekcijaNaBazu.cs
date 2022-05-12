using DLWMS.WinForms.Entiteti;
using System.Data.Entity;
using DLWMS.WinForms.IBBrojIndeksa;

namespace DLWMS.WinForms.Helpers
{
    public class KonekcijaNaBazu : DbContext
    {
        public KonekcijaNaBazu() : base("PutanjaDoBaze")
        {
        }
        
        public virtual DbSet<Student> Studenti { get; set; }
        public virtual DbSet<Spol> Spolovi { get; set; }
        public virtual DbSet<Predmet> Predmet { get; set; }
        public virtual DbSet<StudentiPredmeti> StudentiPredmeti { get; set; }
        public virtual DbSet<StudentiIspitiScan> StudentiIspitiScan { get; set; }
        public virtual DbSet<Uloga> Uloge { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
                .HasMany(x => x.Uloge)
                .WithMany(u => u.Studenti)
                .Map(su => 
                {
                    su.MapLeftKey("Student_Id");
                    su.MapRightKey("Uloga_Id");
                    su.ToTable("StudentiUloge");
                });
        }

    }
}

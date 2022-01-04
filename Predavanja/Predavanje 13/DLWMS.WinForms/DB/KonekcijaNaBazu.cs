using DLWMS.WinForms.P10;
using DLWMS.WinForms.P11;
using DLWMS.WinForms.P9;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DLWMS.WinForms.DB
{

    //DLWMSContext
    public class KonekcijaNaBazu : DbContext
    {

        public KonekcijaNaBazu() : base("DLWMSPutanja")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kandidat>().ToTable("Kandidati");
            modelBuilder.Entity<P7.Student>().ToTable("Studenti");
            modelBuilder.Entity<Spol>().ToTable("Spolovi");
            modelBuilder.Entity<Predmet>().ToTable("Predmeti");
            modelBuilder.Entity<StudentPredmet>().ToTable("StudentiPredmeti");
            modelBuilder.Entity<Uloga>().ToTable("Uloge");


            modelBuilder.Entity<P7.Student>()
                .HasMany(s => s.Uloge)
                .WithMany(u => u.Studenti)
                .Map(su => {
                    su.MapLeftKey("Student_Id");
                    su.MapRightKey("Uloga_Id");
                    su.ToTable("StudentiUloge");
                });


            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



        public DbSet<Kandidat> Kandidati { get; set; }
        public DbSet<P7.Student> Studenti { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<StudentPredmet> StudentiPredmeti { get; set; }
        public DbSet<Uloga> Uloge { get; set; }



    }
}
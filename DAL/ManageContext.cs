namespace NoteBook.DAL.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ManageContext : DbContext
    {
        public ManageContext()
            : base(Utility.Sql.Sqlhelper.sqlConnection
            (Utility.Sql.Sqlhelper.DataSourceType.plug), true)
        {
        }

        public virtual DbSet<xm_plug_v_POList> xm_plug_v_POList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<xm_plug_v_POList>()
                .Property(e => e.数量)
                .HasPrecision(30, 10);

            modelBuilder.Entity<xm_plug_v_POList>()
                .Property(e => e.单价)
                .HasPrecision(30, 10);

            modelBuilder.Entity<xm_plug_v_POList>()
                .Property(e => e.本币价税合计)
                .HasPrecision(19, 4);

            modelBuilder.Entity<xm_plug_v_POList>()
                .Property(e => e.本币无税金额)
                .HasPrecision(19, 4);
        }
    }
}

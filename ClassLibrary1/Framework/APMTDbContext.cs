namespace Model.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class APMTDbContext : DbContext
    {
        public APMTDbContext()
            : base("name=APMTDbContext")
        {
        }

        public virtual DbSet<APMT_Action> APMT_Action { get; set; }
        public virtual DbSet<APMT_Activity> APMT_Activity { get; set; }
        public virtual DbSet<APMT_Company> APMT_Company { get; set; }
        public virtual DbSet<APMT_Company_User> APMT_Company_User { get; set; }
        public virtual DbSet<APMT_Controller> APMT_Controller { get; set; }
        public virtual DbSet<APMT_Language> APMT_Language { get; set; }
        public virtual DbSet<APMT_Permission> APMT_Permission { get; set; }
        public virtual DbSet<APMT_Process> APMT_Process { get; set; }
        public virtual DbSet<APMT_Process_Role> APMT_Process_Role { get; set; }
        public virtual DbSet<APMT_ProductAdmin> APMT_ProductAdmin { get; set; }
        public virtual DbSet<APMT_Project> APMT_Project { get; set; }
        public virtual DbSet<APMT_User> APMT_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<APMT_Action>()
                .Property(e => e.ActionName)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_Action>()
                .Property(e => e.ControllerName)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_Action>()
                .HasMany(e => e.APMT_Permission)
                .WithRequired(e => e.APMT_Action)
                .HasForeignKey(e => e.ActionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Activity>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_Company>()
                .HasMany(e => e.APMT_Company_User)
                .WithOptional(e => e.APMT_Company)
                .HasForeignKey(e => e.Company_id);

            modelBuilder.Entity<APMT_Company>()
                .HasMany(e => e.APMT_Project)
                .WithOptional(e => e.APMT_Company)
                .HasForeignKey(e => e.Company_Id);

            modelBuilder.Entity<APMT_Company_User>()
                .HasMany(e => e.APMT_Process)
                .WithOptional(e => e.APMT_Company_User)
                .HasForeignKey(e => e.Creator_Id);

            modelBuilder.Entity<APMT_Company_User>()
                .HasMany(e => e.APMT_Project)
                .WithOptional(e => e.APMT_Company_User)
                .HasForeignKey(e => e.Manager_Id);

            modelBuilder.Entity<APMT_Controller>()
                .Property(e => e.ControllerName)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_Language>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_Process>()
                .Property(e => e.JsonContent)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_Process>()
                .HasMany(e => e.APMT_Activity)
                .WithOptional(e => e.APMT_Process)
                .HasForeignKey(e => e.Process_Id);

            modelBuilder.Entity<APMT_Process>()
                .HasMany(e => e.APMT_Process_Role)
                .WithOptional(e => e.APMT_Process)
                .HasForeignKey(e => e.Process_Id);

            modelBuilder.Entity<APMT_ProductAdmin>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_ProductAdmin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_ProductAdmin>()
                .HasMany(e => e.APMT_Permission)
                .WithRequired(e => e.APMT_ProductAdmin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_User>()
                .HasMany(e => e.APMT_Company)
                .WithOptional(e => e.APMT_User)
                .HasForeignKey(e => e.Admin_id);

            modelBuilder.Entity<APMT_User>()
                .HasMany(e => e.APMT_Company_User)
                .WithOptional(e => e.APMT_User)
                .HasForeignKey(e => e.User_id);
        }
    }
}

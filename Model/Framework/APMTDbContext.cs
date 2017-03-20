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

        public virtual DbSet<APMT_Activity> APMT_Activity { get; set; }
        public virtual DbSet<APMT_Activity_Status> APMT_Activity_Status { get; set; }
        public virtual DbSet<APMT_Comment> APMT_Comment { get; set; }
        public virtual DbSet<APMT_Company> APMT_Company { get; set; }
        public virtual DbSet<APMT_Company_Member> APMT_Company_Member { get; set; }
        public virtual DbSet<APMT_Files> APMT_Files { get; set; }
        public virtual DbSet<APMT_Process> APMT_Process { get; set; }
        public virtual DbSet<APMT_Process_Role> APMT_Process_Role { get; set; }
        public virtual DbSet<APMT_ProcessRoleUser_Detail> APMT_ProcessRoleUser_Detail { get; set; }
        public virtual DbSet<APMT_Project> APMT_Project { get; set; }
        public virtual DbSet<APMT_Running_Activity_Detail> APMT_Running_Activity_Detail { get; set; }
        public virtual DbSet<APMT_Running_OutputActivity_refer> APMT_Running_OutputActivity_refer { get; set; }
        public virtual DbSet<APMT_Running_OutputActivity_text> APMT_Running_OutputActivity_text { get; set; }
        public virtual DbSet<APMT_Running_OutputActivity_upload> APMT_Running_OutputActivity_upload { get; set; }
        public virtual DbSet<APMT_Running_Process_Detail> APMT_Running_Process_Detail { get; set; }
        public virtual DbSet<APMT_Running_Step_Detail> APMT_Running_Step_Detail { get; set; }
        public virtual DbSet<APMT_Running_Step_Input> APMT_Running_Step_Input { get; set; }
        public virtual DbSet<APMT_Running_Step_Output> APMT_Running_Step_Output { get; set; }
        public virtual DbSet<APMT_Step> APMT_Step { get; set; }
        public virtual DbSet<APMT_Step_Input> APMT_Step_Input { get; set; }
        public virtual DbSet<APMT_Step_Output> APMT_Step_Output { get; set; }
        public virtual DbSet<APMT_Step_Role> APMT_Step_Role { get; set; }
        public virtual DbSet<APMT_Step_To_Step> APMT_Step_To_Step { get; set; }
        public virtual DbSet<APMT_Timeline> APMT_Timeline { get; set; }
        public virtual DbSet<APMT_Type_Output> APMT_Type_Output { get; set; }
        public virtual DbSet<APMT_User_Company> APMT_User_Company { get; set; }
        public virtual DbSet<APMT_Users> APMT_Users { get; set; }
        public virtual DbSet<Company_Role> Company_Role { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<APMT_Activity>()
                .HasMany(e => e.APMT_Running_Activity_Detail)
                .WithRequired(e => e.APMT_Activity)
                .HasForeignKey(e => e.Activity_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Activity>()
                .HasMany(e => e.APMT_Running_OutputActivity_refer)
                .WithRequired(e => e.APMT_Activity)
                .HasForeignKey(e => e.Activity_output_Refer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Activity_Status>()
                .HasMany(e => e.APMT_Running_Activity_Detail)
                .WithRequired(e => e.APMT_Activity_Status)
                .HasForeignKey(e => e.Activity_Status_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Company>()
                .HasMany(e => e.APMT_Company_Member)
                .WithRequired(e => e.APMT_Company)
                .HasForeignKey(e => e.company_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Company>()
                .HasMany(e => e.APMT_Project)
                .WithRequired(e => e.APMT_Company)
                .HasForeignKey(e => e.company_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Company>()
                .HasMany(e => e.APMT_User_Company)
                .WithRequired(e => e.APMT_Company)
                .HasForeignKey(e => e.company_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Files>()
                .HasMany(e => e.APMT_Activity)
                .WithOptional(e => e.APMT_Files)
                .HasForeignKey(e => e.files_id);

            modelBuilder.Entity<APMT_Files>()
                .HasMany(e => e.APMT_Running_OutputActivity_upload)
                .WithRequired(e => e.APMT_Files)
                .HasForeignKey(e => e.Files_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Files>()
                .HasMany(e => e.APMT_Running_Step_Input)
                .WithRequired(e => e.APMT_Files)
                .HasForeignKey(e => e.Files_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Files>()
                .HasMany(e => e.APMT_Running_Step_Output)
                .WithRequired(e => e.APMT_Files)
                .HasForeignKey(e => e.Files_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Files>()
                .HasMany(e => e.APMT_Step_Input)
                .WithRequired(e => e.APMT_Files)
                .HasForeignKey(e => e.Files_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Files>()
                .HasMany(e => e.APMT_Step_Output)
                .WithRequired(e => e.APMT_Files)
                .HasForeignKey(e => e.Files_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Process>()
                .HasMany(e => e.APMT_Files)
                .WithRequired(e => e.APMT_Process)
                .HasForeignKey(e => e.process_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Process>()
                .HasMany(e => e.APMT_Step)
                .WithRequired(e => e.APMT_Process)
                .HasForeignKey(e => e.process_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Process_Role>()
                .HasMany(e => e.APMT_ProcessRoleUser_Detail)
                .WithRequired(e => e.APMT_Process_Role)
                .HasForeignKey(e => e.process_role_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Process_Role>()
                .HasMany(e => e.APMT_Step_Role)
                .WithRequired(e => e.APMT_Process_Role)
                .HasForeignKey(e => e.role_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Project>()
                .HasMany(e => e.APMT_Running_Process_Detail)
                .WithRequired(e => e.APMT_Project)
                .HasForeignKey(e => e.project_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Running_Activity_Detail>()
                .HasMany(e => e.APMT_Comment)
                .WithRequired(e => e.APMT_Running_Activity_Detail)
                .HasForeignKey(e => e.Running_Activity_Detail_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Running_Activity_Detail>()
                .HasMany(e => e.APMT_Running_OutputActivity_text)
                .WithRequired(e => e.APMT_Running_Activity_Detail)
                .HasForeignKey(e => e.running_activity_detail_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Running_Activity_Detail>()
                .HasMany(e => e.APMT_Running_OutputActivity_upload)
                .WithRequired(e => e.APMT_Running_Activity_Detail)
                .HasForeignKey(e => e.running_activity_detail_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Running_OutputActivity_upload>()
                .Property(e => e.Versions)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_Running_Process_Detail>()
                .HasMany(e => e.APMT_Timeline)
                .WithRequired(e => e.APMT_Running_Process_Detail)
                .HasForeignKey(e => e.Running_Process_Detail_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Running_Step_Detail>()
                .HasMany(e => e.APMT_Running_Step_Input)
                .WithRequired(e => e.APMT_Running_Step_Detail)
                .HasForeignKey(e => e.running_step_detail_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Running_Step_Detail>()
                .HasMany(e => e.APMT_Running_Step_Output)
                .WithRequired(e => e.APMT_Running_Step_Detail)
                .HasForeignKey(e => e.running_step_detail_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Running_Step_Input>()
                .Property(e => e.Versions)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_Running_Step_Output>()
                .Property(e => e.Versions)
                .IsUnicode(false);

            modelBuilder.Entity<APMT_Step>()
                .HasMany(e => e.APMT_Activity)
                .WithRequired(e => e.APMT_Step)
                .HasForeignKey(e => e.step_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Step>()
                .HasMany(e => e.APMT_Step_Input)
                .WithRequired(e => e.APMT_Step)
                .HasForeignKey(e => e.Step_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Step>()
                .HasMany(e => e.APMT_Step_Output)
                .WithRequired(e => e.APMT_Step)
                .HasForeignKey(e => e.Step_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Step>()
                .HasMany(e => e.APMT_Step_Role)
                .WithRequired(e => e.APMT_Step)
                .HasForeignKey(e => e.step_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Step>()
                .HasMany(e => e.APMT_Step_To_Step)
                .WithRequired(e => e.APMT_Step)
                .HasForeignKey(e => e.fromStep_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Step>()
                .HasMany(e => e.APMT_Step_To_Step1)
                .WithRequired(e => e.APMT_Step1)
                .HasForeignKey(e => e.toStep_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Step_Input>()
                .HasMany(e => e.APMT_Running_Step_Input)
                .WithRequired(e => e.APMT_Step_Input)
                .HasForeignKey(e => e.Step_Input_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Step_Output>()
                .HasMany(e => e.APMT_Running_Step_Output)
                .WithRequired(e => e.APMT_Step_Output)
                .HasForeignKey(e => e.Step_Output_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Type_Output>()
                .HasMany(e => e.APMT_Activity)
                .WithRequired(e => e.APMT_Type_Output)
                .HasForeignKey(e => e.type_output_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Users>()
                .HasMany(e => e.APMT_Company_Member)
                .WithRequired(e => e.APMT_Users)
                .HasForeignKey(e => e.users_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Users>()
                .HasMany(e => e.APMT_Process)
                .WithRequired(e => e.APMT_Users)
                .HasForeignKey(e => e.Creator_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Users>()
                .HasMany(e => e.APMT_ProcessRoleUser_Detail)
                .WithRequired(e => e.APMT_Users)
                .HasForeignKey(e => e.users_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Users>()
                .HasMany(e => e.APMT_Project)
                .WithRequired(e => e.APMT_Users)
                .HasForeignKey(e => e.manager_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Users>()
                .HasMany(e => e.APMT_Running_Activity_Detail)
                .WithRequired(e => e.APMT_Users)
                .HasForeignKey(e => e.Member_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APMT_Users>()
                .HasMany(e => e.APMT_Running_Process_Detail)
                .WithRequired(e => e.APMT_Users)
                .HasForeignKey(e => e.leader_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company_Role>()
                .HasMany(e => e.APMT_Users)
                .WithOptional(e => e.Company_Role)
                .HasForeignKey(e => e.IDRole);
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BismillahSealConsultant.DataModels;

namespace BismillahSealConsultant.DataContext
{
    public partial class sealConsultantContext : DbContext
    {
        public sealConsultantContext()
        {
        }

        public sealConsultantContext(DbContextOptions<sealConsultantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Access> Accesses { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Advance> Advances { get; set; } = null!;
        public virtual DbSet<AdvancePayback> AdvancePaybacks { get; set; } = null!;
        public virtual DbSet<Announcement> Announcements { get; set; } = null!;
        public virtual DbSet<AppLog> AppLogs { get; set; } = null!;
        public virtual DbSet<AudioAnouncement> AudioAnouncements { get; set; } = null!;
        public virtual DbSet<BreakTime> BreakTimes { get; set; } = null!;
        public virtual DbSet<Chart> Charts { get; set; } = null!;
        public virtual DbSet<ChatSchema> ChatSchemas { get; set; } = null!;
        public virtual DbSet<Deduction> Deductions { get; set; } = null!;
        public virtual DbSet<Degree> Degrees { get; set; } = null!;
        public virtual DbSet<Depatch> Depatches { get; set; } = null!;
        public virtual DbSet<DistchpatchField> DistchpatchFields { get; set; } = null!;
        public virtual DbSet<Doc> Docs { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeLogView> EmployeeLogViews { get; set; } = null!;
        public virtual DbSet<EmployeeWithLatestRate> EmployeeWithLatestRates { get; set; } = null!;
        public virtual DbSet<EntryTime> EntryTimes { get; set; } = null!;
        public virtual DbSet<Epclocal> Epclocals { get; set; } = null!;
        public virtual DbSet<EpfForeign> EpfForeigns { get; set; } = null!;
        public virtual DbSet<ExitTime> ExitTimes { get; set; } = null!;
        public virtual DbSet<ExtraEarn> ExtraEarns { get; set; } = null!;
        public virtual DbSet<Extradeduction> Extradeductions { get; set; } = null!;
        public virtual DbSet<Group> Groups { get; set; } = null!;
        public virtual DbSet<GroupEmployee> GroupEmployees { get; set; } = null!;
        public virtual DbSet<HourRule> HourRules { get; set; } = null!;
        public virtual DbSet<Industry> Industries { get; set; } = null!;
        public virtual DbSet<Leaf> Leaves { get; set; } = null!;
        public virtual DbSet<Level> Levels { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<OvertimeWorkingHour> OvertimeWorkingHours { get; set; } = null!;
        public virtual DbSet<Page> Pages { get; set; } = null!;
        public virtual DbSet<PamentSchema> PamentSchemas { get; set; } = null!;
        public virtual DbSet<PaySlipField> PaySlipFields { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<PaymentSlip> PaymentSlips { get; set; } = null!;
        public virtual DbSet<Payroll> Payrolls { get; set; } = null!;
        public virtual DbSet<PayrollByMonthStuff> PayrollByMonthStuffs { get; set; } = null!;
        public virtual DbSet<Payrolldeductionschema> Payrolldeductionschemas { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<ProjectEmployee> ProjectEmployees { get; set; } = null!;
        public virtual DbSet<ProjectTeam> ProjectTeams { get; set; } = null!;
        public virtual DbSet<Roll> Rolls { get; set; } = null!;
        public virtual DbSet<Skill> Skills { get; set; } = null!;
        public virtual DbSet<Sosco> Soscos { get; set; } = null!;
        public virtual DbSet<SubProject> SubProjects { get; set; } = null!;
        public virtual DbSet<TeamEmployee> TeamEmployees { get; set; } = null!;
        public virtual DbSet<ViewDispacfield> ViewDispacfields { get; set; } = null!;
        public virtual DbSet<Viewadmin> Viewadmins { get; set; } = null!;
        public virtual DbSet<Viewemployee> Viewemployees { get; set; } = null!;
        public virtual DbSet<WorkerHourlyRate> WorkerHourlyRates { get; set; } = null!;
        public virtual DbSet<WorkerIndustry> WorkerIndustries { get; set; } = null!;
        public virtual DbSet<WorkerPaymentDetailsBydate> WorkerPaymentDetailsBydates { get; set; } = null!;
        public virtual DbSet<WorkerReq> WorkerReqs { get; set; } = null!;
        public virtual DbSet<WorkerReqSkill> WorkerReqSkills { get; set; } = null!;
        public virtual DbSet<WorkerWorkingHour> WorkerWorkingHours { get; set; } = null!;
        public virtual DbSet<WorkingHourRuleSchema> WorkingHourRuleSchemas { get; set; } = null!;
        public virtual DbSet<WorkingHoursCorrectionRequest> WorkingHoursCorrectionRequests { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=65.109.89.252;port=14065;Database=sealConsultant;Username=postgres;Password=x67q262Cx21; Pooling=true; Timeout=300");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Access>(entity =>
            {
                entity.ToTable("Access ");

                entity.HasIndex(e => e.RollId, "IX_Access _RollID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.PageId).HasColumnName("pageID");

                entity.Property(e => e.RollId).HasColumnName("RollID");

                entity.HasOne(d => d.Roll)
                    .WithMany(p => p.Accesses)
                    .HasForeignKey(d => d.RollId)
                    .HasConstraintName("FK_Access _roll");
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Rollid).HasColumnName("rollid");
            });

            modelBuilder.Entity<Advance>(entity =>
            {
                entity.ToTable("Advance");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.ApprovedBy).HasColumnName("ApprovedBY");
            });

            modelBuilder.Entity<AdvancePayback>(entity =>
            {
                entity.ToTable("AdvancePayback");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.ToTable("Announcement");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Details).HasColumnType("character varying");

                entity.Property(e => e.Title).HasColumnType("character varying");
            });

            modelBuilder.Entity<AppLog>(entity =>
            {
                entity.ToTable("AppLog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("datetime");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            });

            modelBuilder.Entity<AudioAnouncement>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AudioUrl).HasColumnType("character varying");

                entity.Property(e => e.DateTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Title).HasColumnType("character varying");
            });

            modelBuilder.Entity<BreakTime>(entity =>
            {
                entity.ToTable("BreakTIme");

                entity.Property(e => e.BreakTimeId).ValueGeneratedNever();

                entity.Property(e => e.SchemaId).HasColumnName("SchemaID");
            });

            modelBuilder.Entity<Chart>(entity =>
            {
                entity.ToTable("chart");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Intime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("intime");

                entity.Property(e => e.Outtime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("outtime");
            });

            modelBuilder.Entity<ChatSchema>(entity =>
            {
                entity.ToTable("ChatSchema");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateEnded).HasColumnName("dateEnded");
            });

            modelBuilder.Entity<Deduction>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Name).HasColumnType("character varying");

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.ReferencePaymentId).HasColumnName("reference_payment_id");

                entity.Property(e => e.SchemaId).HasColumnName("schemaId");

                entity.Property(e => e.Type)
                    .HasColumnType("character varying")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Degree>(entity =>
            {
                entity.HasIndex(e => e.Employeeid, "IX_Degrees_employeeid");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DegreeName)
                    .HasColumnType("character varying")
                    .HasColumnName("degreeName");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.GradeResult)
                    .HasColumnType("character varying")
                    .HasColumnName("Grade_result");

                entity.Property(e => e.PassingYear)
                    .HasColumnType("character varying")
                    .HasColumnName("passing_year");

                entity.Property(e => e.Remark)
                    .HasColumnType("character varying")
                    .HasColumnName("remark");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Degrees)
                    .HasForeignKey(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Degrees_Employee");
            });

            modelBuilder.Entity<Depatch>(entity =>
            {
                entity.ToTable("Depatch");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EmplyeeId).HasColumnName("emplyeeId");

                entity.Property(e => e.Month).HasColumnName("month");
            });

            modelBuilder.Entity<DistchpatchField>(entity =>
            {
                entity.ToTable("distchpatchFields");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.DitchpathId).HasColumnName("ditchpathId");

                entity.Property(e => e.Isearning).HasColumnName("isearning");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Doc>(entity =>
            {
                entity.ToTable("docs");

                entity.HasIndex(e => e.EmployeeId, "IX_docs_employeeId");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DocmentName)
                    .HasColumnType("character varying")
                    .HasColumnName("docment_name");

                entity.Property(e => e.DocumentType)
                    .HasColumnType("character varying")
                    .HasColumnName("Document_type");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.Link)
                    .HasColumnType("character varying")
                    .HasColumnName("link");

                entity.Property(e => e.Remark)
                    .HasColumnType("character varying")
                    .HasColumnName("remark");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Docs)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_docs_Employee");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BankAcNo).HasColumnType("character varying");

                entity.Property(e => e.BankName)
                    .HasColumnType("character varying")
                    .HasColumnName("bank name");

                entity.Property(e => e.BankaccountNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("bankaccount number");

                entity.Property(e => e.Cidb)
                    .HasColumnType("character varying")
                    .HasColumnName("cidb");

                entity.Property(e => e.CidbExpDate).HasColumnName("cidb_exp_date");

                entity.Property(e => e.CurrentAddress)
                    .HasColumnType("character varying")
                    .HasColumnName("current_address");

                entity.Property(e => e.Department)
                    .HasColumnType("character varying")
                    .HasColumnName("department");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.EmergencyContact)
                    .HasColumnType("character varying")
                    .HasColumnName("emergency_contact");

                entity.Property(e => e.EmergengyContactRelation)
                    .HasColumnType("character varying")
                    .HasColumnName("emergengy_contact_relation");

                entity.Property(e => e.EmerhencyContactName)
                    .HasColumnType("character varying")
                    .HasColumnName("emerhency_contact_name");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnType("character varying")
                    .HasColumnName("employee_code");

                entity.Property(e => e.EntryCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entry_created");

                entity.Property(e => e.Epf)
                    .HasColumnType("character varying")
                    .HasColumnName("epf");

                entity.Property(e => e.FirstName)
                    .HasColumnType("character varying")
                    .HasColumnName("first_name");

                entity.Property(e => e.IcPp)
                    .HasColumnType("character varying")
                    .HasColumnName("ic_pp");

                entity.Property(e => e.JoiningDate).HasColumnName("joining date");

                entity.Property(e => e.LastName)
                    .HasColumnType("character varying")
                    .HasColumnName("last_name");

                entity.Property(e => e.LastWorkingDay).HasColumnName("last_working_day");

                entity.Property(e => e.Level).HasColumnType("character varying");

                entity.Property(e => e.MysjId)
                    .HasColumnType("character varying")
                    .HasColumnName("MYSJ_ID");

                entity.Property(e => e.Nationality)
                    .HasColumnType("character varying")
                    .HasColumnName("nationality");

                entity.Property(e => e.OtElecgibility)
                    .HasColumnType("character varying")
                    .HasColumnName("otElecgibility");

                entity.Property(e => e.Password)
                    .HasColumnType("character varying")
                    .HasColumnName("password");

                entity.Property(e => e.PemanantAddress)
                    .HasColumnType("character varying")
                    .HasColumnName("pemanant_address");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.Photo)
                    .HasColumnType("character varying")
                    .HasColumnName("photo");

                entity.Property(e => e.Remark)
                    .HasColumnType("character varying")
                    .HasColumnName("remark");

                entity.Property(e => e.RollId).HasColumnName("rollId");

                entity.Property(e => e.Socso)
                    .HasColumnType("character varying")
                    .HasColumnName("socso");

                entity.Property(e => e.TaxNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("tax_number");
            });

            modelBuilder.Entity<EmployeeLogView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeLogView");

                entity.Property(e => e.DateTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnType("character varying")
                    .HasColumnName("employee_code");

                entity.Property(e => e.FirstName)
                    .HasColumnType("character varying")
                    .HasColumnName("first_name");

                entity.Property(e => e.Item).HasColumnType("character varying");

                entity.Property(e => e.LastName)
                    .HasColumnType("character varying")
                    .HasColumnName("last_name");

                entity.Property(e => e.Level).HasColumnType("character varying");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.RollId).HasColumnName("rollId");
            });

            modelBuilder.Entity<EmployeeWithLatestRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeWithLatestRate");

                entity.Property(e => e.RateEffectiveDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<EntryTime>(entity =>
            {
                entity.ToTable("EntryTime");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.SchemaId).HasColumnName("SchemaID");
            });

            modelBuilder.Entity<Epclocal>(entity =>
            {
                entity.ToTable("EPClocal");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ByTheEmployee).HasColumnName("By_the_Employee");

                entity.Property(e => e.ByTheEnployeer).HasColumnName("BY_the_Enployeer");
            });

            modelBuilder.Entity<EpfForeign>(entity =>
            {
                entity.ToTable("EpfForeign");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ByTheEmployee).HasColumnName("By_the_Employee");

                entity.Property(e => e.ByTheEnployeer).HasColumnName("BY_the_Enployeer");
            });

            modelBuilder.Entity<ExitTime>(entity =>
            {
                entity.ToTable("ExitTime");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.SchemaId).HasColumnName("SchemaID");
            });

            modelBuilder.Entity<ExtraEarn>(entity =>
            {
                entity.ToTable("extraEarn");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FoodAllowance).HasColumnName("Food_allowance");

                entity.Property(e => e.HouseAllowance).HasColumnName("House_allowance");

                entity.Property(e => e.MobileAllowance).HasColumnName("Mobile_allowance");

                entity.Property(e => e.NightWorkAllowance).HasColumnName("Night_work_allowance");

                entity.Property(e => e.OtherAllowance).HasColumnName("Other_allowance");
            });

            modelBuilder.Entity<Extradeduction>(entity =>
            {
                entity.ToTable("extradeduction");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.Epf).HasColumnName("epf");

                entity.Property(e => e.OfficeAdvance).HasColumnName("office advance");

                entity.Property(e => e.Others).HasColumnName("others");

                entity.Property(e => e.Ppe).HasColumnName("PPE");

                entity.Property(e => e.PreviousLoan).HasColumnName("previous loan");

                entity.Property(e => e.ProbashDeposit).HasColumnName("Probash deposit");

                entity.Property(e => e.ProbashLoan).HasColumnName("Probash loan");

                entity.Property(e => e.RmarkOthers).HasColumnType("character varying");

                entity.Property(e => e.SiteAdvance).HasColumnName("site advance");

                entity.Property(e => e.Sosco).HasColumnName("sosco");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("groups");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupName)
                    .HasColumnType("character varying")
                    .HasColumnName("groupName");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");
            });

            modelBuilder.Entity<GroupEmployee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<HourRule>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name).HasColumnType("character varying");
            });

            modelBuilder.Entity<Industry>(entity =>
            {
                entity.ToTable("Industry ");

                entity.Property(e => e.IndustryId)
                    .ValueGeneratedNever()
                    .HasColumnName("Industry_Id");

                entity.Property(e => e.IndustryName)
                    .HasColumnType("character varying")
                    .HasColumnName("Industry_Name");
            });

            modelBuilder.Entity<Leaf>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("endDate");

                entity.Property(e => e.Reason)
                    .HasColumnType("character varying")
                    .HasColumnName("reason");

                entity.Property(e => e.StartDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("startDate");

                entity.Property(e => e.Type).HasColumnType("character varying");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.ToTable("Level");

                entity.Property(e => e.LevelId)
                    .ValueGeneratedNever()
                    .HasColumnName("levelId");

                entity.Property(e => e.LevelName)
                    .HasColumnType("character varying")
                    .HasColumnName("LevelNAme");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EmpId).HasColumnName("empId");

                entity.Property(e => e.Item).HasColumnType("character varying");
            });

            modelBuilder.Entity<OvertimeWorkingHour>(entity =>
            {
                entity.HasKey(e => e.OverTimeId)
                    .HasName("overtimeWorkingHour_pkey");

                entity.ToTable("overtimeWorkingHour");

                entity.Property(e => e.OverTimeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.PageName)
                    .HasColumnType("character varying")
                    .HasColumnName("pageName");

                entity.Property(e => e.Uri).HasColumnType("character varying");
            });

            modelBuilder.Entity<PamentSchema>(entity =>
            {
                entity.ToTable("PamentSchema");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.SchemaName).HasColumnType("character varying");
            });

            modelBuilder.Entity<PaySlipField>(entity =>
            {
                entity.ToTable("paySlipFields");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Date).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.Name).HasColumnType("character varying");

                entity.Property(e => e.RollId).HasColumnName("rollId");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("payments");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EmployeedId).HasColumnName("employeedId");

                entity.Property(e => e.Issuedate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("issuedate");

                entity.Property(e => e.Month)
                    .HasColumnType("character varying")
                    .HasColumnName("month");

                entity.Property(e => e.PaymentRefNumber).HasColumnName("payment_ref_number");

                entity.Property(e => e.PositionId).HasColumnName("position_id");

                entity.Property(e => e.Year)
                    .HasColumnType("character varying")
                    .HasColumnName("year");
            });

            modelBuilder.Entity<PaymentSlip>(entity =>
            {
                entity.ToTable("paymentSlip");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Note).HasColumnType("character varying");

                entity.Property(e => e.Payrollid).HasColumnName("payrollid");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<Payroll>(entity =>
            {
                entity.ToTable("payroll");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.ReletedPayrollId).HasColumnName("releted_payroll_id");

                entity.Property(e => e.SchemaId).HasColumnName("schemaId");

                entity.Property(e => e.Type)
                    .HasColumnType("character varying")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<PayrollByMonthStuff>(entity =>
            {
                entity.ToTable("payrollByMonthStuff");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Earning).HasColumnName("earning");

                entity.Property(e => e.FieldName).HasColumnType("character varying");

                entity.Property(e => e.Month).HasColumnName("month");
            });

            modelBuilder.Entity<Payrolldeductionschema>(entity =>
            {
                entity.ToTable("payrolldeductionschema");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate).HasColumnName("endDate");

                entity.Property(e => e.SinceDate).HasColumnName("sinceDate");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("projects");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsSubProject).HasColumnName("isSubProject");

                entity.Property(e => e.Location).HasColumnType("character varying");

                entity.Property(e => e.ProjectName)
                    .HasColumnType("character varying")
                    .HasColumnName("project_name");
            });

            modelBuilder.Entity<ProjectEmployee>(entity =>
            {
                entity.ToTable("projectEmployee");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateEnded)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dateEnded");

                entity.Property(e => e.DateStarted)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dateStarted");

                entity.Property(e => e.Iscurrent).HasColumnName("iscurrent");

                entity.Property(e => e.Rollid).HasColumnName("rollid");
            });

            modelBuilder.Entity<ProjectTeam>(entity =>
            {
                entity.HasKey(e => e.TeamId)
                    .HasName("ProjectTeams_pkey");

                entity.Property(e => e.TeamId).ValueGeneratedNever();

                entity.Property(e => e.GroupId).HasColumnName("groupId");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.TeamName).HasColumnType("character varying");

                entity.Property(e => e.TeamPurpose).HasColumnType("character varying");
            });

            modelBuilder.Entity<Roll>(entity =>
            {
                entity.ToTable("roll");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.LevelId).HasColumnName("levelId");

                entity.Property(e => e.Name).HasColumnType("character varying");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skill");

                entity.Property(e => e.SkillId)
                    .ValueGeneratedNever()
                    .HasColumnName("Skill_Id");

                entity.Property(e => e.SkillName)
                    .HasColumnType("character varying")
                    .HasColumnName("Skill_Name");
            });

            modelBuilder.Entity<Sosco>(entity =>
            {
                entity.ToTable("sosco");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EmployeeContribution).HasColumnName("Employee Contribution");
            });

            modelBuilder.Entity<SubProject>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProjectId).HasColumnName("projectID");

                entity.Property(e => e.SubprojectId).HasColumnName("SubprojectID");
            });

            modelBuilder.Entity<TeamEmployee>(entity =>
            {
                entity.ToTable("teamEmployee");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.TeamId).HasColumnName("teamID");
            });

            modelBuilder.Entity<ViewDispacfield>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewDispacfield");

                entity.Property(e => e.Name).HasColumnType("character varying");
            });

            modelBuilder.Entity<Viewadmin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewadmin");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasColumnType("character varying")
                    .HasColumnName("password");

                entity.Property(e => e.Roll)
                    .HasColumnType("character varying")
                    .HasColumnName("roll");

                entity.Property(e => e.Rollid).HasColumnName("rollid");
            });

            modelBuilder.Entity<Viewemployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewemployee");

                entity.Property(e => e.Cidb).HasColumnType("character varying");

                entity.Property(e => e.CurrentAddress).HasColumnType("character varying");

                entity.Property(e => e.Email).HasColumnType("character varying");

                entity.Property(e => e.EmergencyContact).HasColumnType("character varying");

                entity.Property(e => e.EmergengyContactRelation).HasColumnType("character varying");

                entity.Property(e => e.EmerhencyContactName).HasColumnType("character varying");

                entity.Property(e => e.EmployeeCode).HasColumnType("character varying");

                entity.Property(e => e.EntryCreated).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Epf).HasColumnType("character varying");

                entity.Property(e => e.FirstName).HasColumnType("character varying");

                entity.Property(e => e.IcPp).HasColumnType("character varying");

                entity.Property(e => e.LastName).HasColumnType("character varying");

                entity.Property(e => e.Nationality).HasColumnType("character varying");

                entity.Property(e => e.PemanantAddress).HasColumnType("character varying");

                entity.Property(e => e.Phone).HasColumnType("character varying");

                entity.Property(e => e.Photo).HasColumnType("character varying");

                entity.Property(e => e.Remark).HasColumnType("character varying");

                entity.Property(e => e.TaxNumber).HasColumnType("character varying");
            });

            modelBuilder.Entity<WorkerHourlyRate>(entity =>
            {
                entity.ToTable("WorkerHourlyRate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.SinceDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<WorkerIndustry>(entity =>
            {
                entity.ToTable("WorkerIndustry");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IndustryId).HasColumnName("Industry_Id");

                entity.Property(e => e.WorkerId).HasColumnName("Worker_Id");
            });

            modelBuilder.Entity<WorkerPaymentDetailsBydate>(entity =>
            {
                entity.ToTable("WorkerPaymentDetailsBydate");

                entity.HasIndex(e => new { e.Date, e.EmployeeId }, "WorkerPaymentDetailsBydate_Date_EmployeeId_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ActualHours).HasColumnName("actualHours");

                entity.Property(e => e.BreakTime).HasColumnName("breakTime");

                entity.Property(e => e.InTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.IntimeActual).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OnSite).HasColumnName("onSite");

                entity.Property(e => e.OutTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OutTimeActual).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OverTime).HasColumnName("overTime");

                entity.Property(e => e.Paid).HasColumnName("paid");

                entity.Property(e => e.Paidate).HasColumnName("paidate");

                entity.Property(e => e.RatePerHour).HasColumnType("money");

                entity.Property(e => e.TotalEarnedOnDate).HasColumnType("money");
            });

            modelBuilder.Entity<WorkerReq>(entity =>
            {
                entity.ToTable("WorkerReq");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CurrentAddress)
                    .HasColumnType("character varying")
                    .HasColumnName("current_address");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.EmergencyContact)
                    .HasColumnType("character varying")
                    .HasColumnName("emergency_contact");

                entity.Property(e => e.EmergengyContactRelation)
                    .HasColumnType("character varying")
                    .HasColumnName("emergengy_contact_relation");

                entity.Property(e => e.EmerhencyContactName)
                    .HasColumnType("character varying")
                    .HasColumnName("emerhency_contact_name");

                entity.Property(e => e.EntryCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("entry_created");

                entity.Property(e => e.FirstName)
                    .HasColumnType("character varying")
                    .HasColumnName("first_name");

                entity.Property(e => e.IcPp)
                    .HasColumnType("character varying")
                    .HasColumnName("ic_pp");

                entity.Property(e => e.LastName)
                    .HasColumnType("character varying")
                    .HasColumnName("last_name");

                entity.Property(e => e.Nationality)
                    .HasColumnType("character varying")
                    .HasColumnName("nationality");

                entity.Property(e => e.PemanantAddress)
                    .HasColumnType("character varying")
                    .HasColumnName("pemanant_address");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.Photo)
                    .HasColumnType("character varying")
                    .HasColumnName("photo");

                entity.Property(e => e.Remark)
                    .HasColumnType("character varying")
                    .HasColumnName("remark");
            });

            modelBuilder.Entity<WorkerReqSkill>(entity =>
            {
                entity.ToTable("WorkerReqSkill");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SkillId).HasColumnName("Skill_Id");
            });

            modelBuilder.Entity<WorkerWorkingHour>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.ExtraHour).HasColumnName("extraHour");

                entity.Property(e => e.InAm)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("inAm");

                entity.Property(e => e.InAmRevise)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("inAmREvise");

                entity.Property(e => e.InPm).HasColumnType("timestamp without time zone");

                entity.Property(e => e.InPmRevise)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("inPmREvise");

                entity.Property(e => e.Note).HasColumnType("character varying");

                entity.Property(e => e.OutAm).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OutAmRevise)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("outAmREvise");

                entity.Property(e => e.OutPm).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OutPmRevise)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("outPmREvise");

                entity.Property(e => e.Shift)
                    .HasColumnType("character varying")
                    .HasColumnName("shift");

                entity.Property(e => e.WokingHours).HasColumnName("wokingHours");
            });

            modelBuilder.Entity<WorkingHourRuleSchema>(entity =>
            {
                entity.HasKey(e => e.SchemaId)
                    .HasName("WorkingHourRuleSchema_pkey");

                entity.ToTable("WorkingHourRuleSchema");

                entity.Property(e => e.SchemaId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("timestamp without time zone");

                entity.Property(e => e.RuleName).HasColumnType("character varying");
            });

            modelBuilder.Entity<WorkingHoursCorrectionRequest>(entity =>
            {
                entity.ToTable("Working_Hours_Correction_Request");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("active");

                entity.Property(e => e.Inam)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("inam");

                entity.Property(e => e.Outpm)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("outpm");

                entity.Property(e => e.Resolved).HasColumnName("resolved");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

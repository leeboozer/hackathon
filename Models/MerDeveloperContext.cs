using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace hackathon.Models
{
    public partial class MercuryEntities : DbContext
    {

        #region DbSets
        public virtual DbSet<AcumaticaBillingInfo> AcumaticaBillingInfo { get; set; }
        public virtual DbSet<AddressInformation> AddressInformation { get; set; }
        public virtual DbSet<AdverseAction> AdverseAction { get; set; }
        public virtual DbSet<Alias> Alias { get; set; }
        public virtual DbSet<ApiEndpointLog> ApiEndpointLog { get; set; }
        public virtual DbSet<ApiLog> ApiLog { get; set; }
        public virtual DbSet<ApiLogError> ApiLogError { get; set; }
        public virtual DbSet<ApplicationSettings> ApplicationSettings { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<AttachmentStore> AttachmentStore { get; set; }
        public virtual DbSet<Badge> Badge { get; set; }
        public virtual DbSet<Billing> Billing { get; set; }
        public virtual DbSet<CallToAction> CallToAction { get; set; }
        public virtual DbSet<Candidate> Candidate { get; set; }
        public virtual DbSet<CandidateCallToAction> CandidateCallToAction { get; set; }
        public virtual DbSet<CandidateCause> CandidateCause { get; set; }
        public virtual DbSet<CandidateCoupon> CandidateCoupon { get; set; }
        public virtual DbSet<CandidateCouponUsage> CandidateCouponUsage { get; set; }
        public virtual DbSet<CandidateEmailOption> CandidateEmailOption { get; set; }
        public virtual DbSet<CandidateEvent> CandidateEvent { get; set; }
        public virtual DbSet<CandidateForms> CandidateForms { get; set; }
        public virtual DbSet<CandidateInterest> CandidateInterest { get; set; }
        public virtual DbSet<CandidateResponse> CandidateResponse { get; set; }
        public virtual DbSet<CandidateSecurityQuestions> CandidateSecurityQuestions { get; set; }
        public virtual DbSet<CandidateSkill> CandidateSkill { get; set; }
        public virtual DbSet<Cause> Cause { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientConfiguration> ClientConfiguration { get; set; }
        public virtual DbSet<ClientCredit> ClientCredit { get; set; }
        public virtual DbSet<ClientEmailOption> ClientEmailOption { get; set; }
        public virtual DbSet<ClientFeature> ClientFeature { get; set; }
        public virtual DbSet<ClientInterest> ClientInterest { get; set; }
        public virtual DbSet<ClientPricing> ClientPricing { get; set; }
        public virtual DbSet<ClientProductAuthorization> ClientProductAuthorization { get; set; }
        public virtual DbSet<ClientPromotion> ClientPromotion { get; set; }
        public virtual DbSet<ClientRatingRestriction> ClientRatingRestriction { get; set; }
        public virtual DbSet<ClientReport> ClientReport { get; set; }
        public virtual DbSet<ClientReportAudit> ClientReportAudit { get; set; }
        public virtual DbSet<ClientReportParameter> ClientReportParameter { get; set; }
        public virtual DbSet<ClientReportParameterValueSet> ClientReportParameterValueSet { get; set; }
        public virtual DbSet<ClientSkill> ClientSkill { get; set; }
        public virtual DbSet<ClientSsoSettings> ClientSsoSettings { get; set; }
        public virtual DbSet<ClientStaffCommission> ClientStaffCommission { get; set; }
        public virtual DbSet<ClientStaffCommissionSalesRep> ClientStaffCommissionSalesRep { get; set; }
        public virtual DbSet<ClientStates> ClientStates { get; set; }
        public virtual DbSet<ClientUser> ClientUser { get; set; }
        public virtual DbSet<ClientUserConsent> ClientUserConsent { get; set; }
        public virtual DbSet<ClientView> ClientView { get; set; }
        public virtual DbSet<ClientViewClientUser> ClientViewClientUser { get; set; }
        public virtual DbSet<Cloud> Cloud { get; set; }
        public virtual DbSet<ConsentForm> ConsentForm { get; set; }
        public virtual DbSet<ConsentFormParameter> ConsentFormParameter { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<CountySourceFee> CountySourceFee { get; set; }
        public virtual DbSet<CouponPrice> CouponPrice { get; set; }
        public virtual DbSet<CustomContent> CustomContent { get; set; }
        public virtual DbSet<CustomSort> CustomSort { get; set; }
        public virtual DbSet<CustomSortColumn> CustomSortColumn { get; set; }
        public virtual DbSet<CustomizedEmailTemplate> CustomizedEmailTemplate { get; set; }
        public virtual DbSet<CustomizedEmailTemplateAttachment> CustomizedEmailTemplateAttachment { get; set; }
        public virtual DbSet<DbPatch> DbPatch { get; set; }
        public virtual DbSet<DocumentTemplate> DocumentTemplate { get; set; }
        public virtual DbSet<EmailHistory> EmailHistory { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<Endorsement> Endorsement { get; set; }
        public virtual DbSet<EnumLookup> EnumLookup { get; set; }
        public virtual DbSet<ErrorCount> ErrorCount { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<FormStore> FormStore { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<IdAuthenticationResult> IdAuthenticationResult { get; set; }
        public virtual DbSet<IdAuthenticationResultModification> IdAuthenticationResultModification { get; set; }
        public virtual DbSet<ImageStore> ImageStore { get; set; }
        public virtual DbSet<Interest> Interest { get; set; }
        public virtual DbSet<Invitation> Invitation { get; set; }
        public virtual DbSet<InvitationAttachment> InvitationAttachment { get; set; }
        public virtual DbSet<JurisMappedCounty> JurisMappedCounty { get; set; }
        public virtual DbSet<JurisOrder> JurisOrder { get; set; }
        public virtual DbSet<JurisProcessing> JurisProcessing { get; set; }
        public virtual DbSet<JurisSourceFee> JurisSourceFee { get; set; }
        public virtual DbSet<JurisStateDistrictCounty> JurisStateDistrictCounty { get; set; }
        public virtual DbSet<JurisUpdate> JurisUpdate { get; set; }
        public virtual DbSet<JurisZipCodesMultiCounty> JurisZipCodesMultiCounty { get; set; }
        public virtual DbSet<Jurisdiction> Jurisdiction { get; set; }
        public virtual DbSet<Layout> Layout { get; set; }
        public virtual DbSet<Locking> Locking { get; set; }
        public virtual DbSet<MaintenanceWindow> MaintenanceWindow { get; set; }
        public virtual DbSet<Memberships> Memberships { get; set; }
        public virtual DbSet<NationalCrimArchive> NationalCrimArchive { get; set; }
        public virtual DbSet<NationalCrimCache> NationalCrimCache { get; set; }
        public virtual DbSet<NationalCrimCaseArchive> NationalCrimCaseArchive { get; set; }
        public virtual DbSet<NationalCrimCaseHash> NationalCrimCaseHash { get; set; }
        public virtual DbSet<NewsArticle> NewsArticle { get; set; }
        public virtual DbSet<NpnOrder> NpnOrder { get; set; }
        public virtual DbSet<NpnOrderProduct> NpnOrderProduct { get; set; }
        public virtual DbSet<NpnProduct> NpnProduct { get; set; }
        public virtual DbSet<NystatewideCounty> NystatewideCounty { get; set; }
        public virtual DbSet<OrderBatchDetail> OrderBatchDetail { get; set; }
        public virtual DbSet<OrderBatchFile> OrderBatchFile { get; set; }
        public virtual DbSet<OrderConsent> OrderConsent { get; set; }
        public virtual DbSet<OrderCrimCase> OrderCrimCase { get; set; }
        public virtual DbSet<OrderCrimCharge> OrderCrimCharge { get; set; }
        public virtual DbSet<OrderFormStore> OrderFormStore { get; set; }
        public virtual DbSet<OrderQuestionnaire> OrderQuestionnaire { get; set; }
        public virtual DbSet<OrderReference> OrderReference { get; set; }
        public virtual DbSet<OrderReportView> OrderReportView { get; set; }
        public virtual DbSet<OrderSearch> OrderSearch { get; set; }
        public virtual DbSet<OrderSharing> OrderSharing { get; set; }
        public virtual DbSet<OrderSharingExternal> OrderSharingExternal { get; set; }
        public virtual DbSet<OrderUpdate> OrderUpdate { get; set; }
        public virtual DbSet<OrderUpdateSearch> OrderUpdateSearch { get; set; }
        public virtual DbSet<PageView> PageView { get; set; }
        public virtual DbSet<PanelGroup> PanelGroup { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<Paths> Paths { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PdfDetail> PdfDetail { get; set; }
        public virtual DbSet<PdfHeader> PdfHeader { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<PositionListing> PositionListing { get; set; }
        public virtual DbSet<PositionNpnProduct> PositionNpnProduct { get; set; }
        public virtual DbSet<ProductAudit> ProductAudit { get; set; }
        public virtual DbSet<ProductAuthorization> ProductAuthorization { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionAnswer> QuestionAnswer { get; set; }
        public virtual DbSet<Questionnaire> Questionnaire { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SecurityQuestions> SecurityQuestions { get; set; }
        public virtual DbSet<SeedData> SeedData { get; set; }
        public virtual DbSet<SharingSubscription> SharingSubscription { get; set; }
        public virtual DbSet<SitecoreIntegrationLog> SitecoreIntegrationLog { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SolomonBillingInfo> SolomonBillingInfo { get; set; }
        public virtual DbSet<SortOrder> SortOrder { get; set; }
        public virtual DbSet<SourceType> SourceType { get; set; }
        public virtual DbSet<SsnTraceArchive> SsnTraceArchive { get; set; }
        public virtual DbSet<SsnTraceRecordArchive> SsnTraceRecordArchive { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<StateAbuseCode> StateAbuseCode { get; set; }
        public virtual DbSet<StateSourceFee> StateSourceFee { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Uicolumn> Uicolumn { get; set; }
        public virtual DbSet<Uitable> Uitable { get; set; }
        public virtual DbSet<UserAudit> UserAudit { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersInRoles> UsersInRoles { get; set; }
        public virtual DbSet<VolunteerPool> VolunteerPool { get; set; }
        public virtual DbSet<VolunteerPoolCalc> VolunteerPoolCalc { get; set; }
        public virtual DbSet<VolunteerPoolClientRatingRestriction> VolunteerPoolClientRatingRestriction { get; set; }
        public virtual DbSet<VolunteerPoolClientView> VolunteerPoolClientView { get; set; }
        public virtual DbSet<VolunteerPoolHistory> VolunteerPoolHistory { get; set; }
        public virtual DbSet<VolunteerPoolPosition> VolunteerPoolPosition { get; set; }
        public virtual DbSet<ZipCode> ZipCode { get; set; }

        // Unable to generate entity type for table 'dbo.JurisSourceProvider'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BAK_Questionnaire'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BAK_Question'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BAK_QuestionAnswer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BAK_CandidateResponse'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Jurisdiction_Temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SolomonTax'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.JurisOrderProcessing'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpZipCode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DupePosListing'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TaxLookup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TaxLookup_BackUp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.JurisFees'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.JurisStates'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Products'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpJurisdiction'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpJurisZipCodes_MultiCounty'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.vpcu01'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Holidays_Reporting'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.vpci01'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.vpcx01'. Please see the warning messages.
        // Unable to generate entity type for table 'ST\DCofer.Temp'. Please see the warning messages.
        #endregion DbSets

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DATLSQL11\dev.absodb.st.com,4906;Database=MerDeveloper;Trusted_Connection=False;UserId=MercuryWeb;Password=qwerty1!;MultipleActiveResultSets=True;");
            optionsBuilder.UseSqlServer(@"Server=DATLSQL11\dev.absodb.st.com,4906;Database=MerDev4;Trusted_Connection=False;User Id=MercuryWeb;Password=qwerty1!;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcumaticaBillingInfo>(entity =>
            {
                entity.ToTable("AcumaticaBillingInfo", "dbo");

                entity.Property(e => e.AcumaticaBillingInfoId).ValueGeneratedNever();

                entity.Property(e => e.ProductName).HasMaxLength(30);

                entity.Property(e => e.SterlingAccountGlcode)
                    .IsRequired()
                    .HasColumnName("SterlingAccountGLCode")
                    .HasMaxLength(10);

                entity.Property(e => e.SterlingAccountGldescription)
                    .IsRequired()
                    .HasColumnName("SterlingAccountGLDescription")
                    .HasMaxLength(100);

                entity.Property(e => e.SterlingInventoryCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AddressInformation>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK_AddressId");

                entity.ToTable("AddressInformation", "dbo");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK_AddressInformation_Candidate");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_AddressInformation_NpnOrder");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ToDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.AddressInformation)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AddressInformation_Candidate");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.AddressInformation)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AddressInformation_NpnOrder");
            });

            modelBuilder.Entity<AdverseAction>(entity =>
            {
                entity.HasKey(e => new { e.NpnOrderId, e.ClientId })
                    .HasName("PK_AdverseAction");

                entity.ToTable("AdverseAction", "dbo");

                entity.Property(e => e.AdverseActionId).ValueGeneratedOnAdd();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.Reason).HasColumnType("varchar(255)");

                entity.Property(e => e.ResumeDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnType("varchar(50)");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.AdverseAction)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdverseAction_Candidate");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AdverseAction)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdverseAction_Client");

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.AdverseAction)
                    .HasForeignKey(d => d.ClientUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdverseAction_ClientUser");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.AdverseAction)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdverseAction_NpnOrder");

                entity.HasOne(d => d.NpnProduct)
                    .WithMany(p => p.AdverseAction)
                    .HasForeignKey(d => d.NpnProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdverseAction_NpnProduct");

                entity.HasOne(d => d.OrderSharing)
                    .WithMany(p => p.AdverseAction)
                    .HasForeignKey(d => d.OrderSharingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderSharingId");
            });

            modelBuilder.Entity<Alias>(entity =>
            {
                entity.ToTable("Alias", "dbo");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK_OtherNames_Candidate");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_OtherNames_NpnOrder");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastName).HasMaxLength(30);

                entity.Property(e => e.MiddleName).HasMaxLength(30);

                entity.Property(e => e.ToDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Alias)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK_OtherNames_Candidate");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.Alias)
                    .HasForeignKey(d => d.NpnOrderId)
                    .HasConstraintName("FK_OtherNames_NpnOrder");
            });

            modelBuilder.Entity<ApiEndpointLog>(entity =>
            {
                entity.ToTable("ApiEndpointLog", "dbo");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Xml).HasColumnType("xml");
            });

            modelBuilder.Entity<ApiLog>(entity =>
            {
                entity.ToTable("ApiLog", "dbo");

                entity.Property(e => e.ApiCandidateId).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Xml).HasColumnType("xml");
            });

            modelBuilder.Entity<ApiLogError>(entity =>
            {
                entity.ToTable("ApiLogError", "dbo");

                entity.Property(e => e.ApiCandidateId).HasMaxLength(150);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LogTime).HasColumnType("datetime");

                entity.Property(e => e.Zip).HasMaxLength(10);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ApiLogError)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApiLogError_Client");
            });

            modelBuilder.Entity<ApplicationSettings>(entity =>
            {
                entity.HasKey(e => e.ApplicationSettingId)
                    .HasName("PK_ApplicationSettings");

                entity.ToTable("ApplicationSettings", "dbo");

                entity.HasIndex(e => e.SettingName)
                    .HasName("U_ApplicationSettings_Name")
                    .IsUnique();

                entity.Property(e => e.SettingDefault).HasMaxLength(3000);

                entity.Property(e => e.SettingDesc)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).HasMaxLength(3000);

                entity.Property(e => e.ValidValues).HasColumnType("varchar(500)");

                entity.Property(e => e.ValidationRegex).HasColumnType("varchar(500)");
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__Applicat__C93A4C99164452B1");

                entity.ToTable("Applications", "dbo");

                entity.Property(e => e.ApplicationId).ValueGeneratedNever();

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(235);

                entity.Property(e => e.Description).HasMaxLength(256);
            });

            modelBuilder.Entity<AttachmentStore>(entity =>
            {
                entity.HasKey(e => e.AttachmentId)
                    .HasName("PK_AttachmentId");

                entity.ToTable("AttachmentStore", "dbo");

                entity.Property(e => e.AttachmentStoreItem).IsRequired();

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AttachmentStore)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_AttachmentStore_Client");
            });

            modelBuilder.Entity<Badge>(entity =>
            {
                entity.ToTable("Badge", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_Badges_Client");

                entity.HasIndex(e => e.ImageId)
                    .HasName("IX_FK_Badges_Image");

                entity.Property(e => e.BadgeName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.BadgeTypeId).HasDefaultValueSql("0");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Badge)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Badges_Client");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Badge)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Badges_Image");
            });

            modelBuilder.Entity<Billing>(entity =>
            {
                entity.ToTable("Billing", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_fk_billingid");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Billed).HasDefaultValueSql("0");

                entity.Property(e => e.BillingAttn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.EmailId).HasMaxLength(100);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SetupFee).HasColumnType("decimal");

                entity.Property(e => e.SolomonBillingId).HasMaxLength(15);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TaxExempt).HasDefaultValueSql("0");

                entity.Property(e => e.TaxExemptId).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Client)
                    .WithOne(p => p.Billing)
                    .HasForeignKey<Billing>(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_billingid");
            });

            modelBuilder.Entity<CallToAction>(entity =>
            {
                entity.ToTable("CallToAction", "dbo");

                entity.HasIndex(e => e.CallToActionEnum)
                    .HasName("UQ__CallToAc__2C8C514C153D81E4")
                    .IsUnique();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ImageLg)
                    .HasColumnName("ImageLG")
                    .HasMaxLength(255);

                entity.Property(e => e.ImageMd)
                    .HasColumnName("ImageMD")
                    .HasMaxLength(255);

                entity.Property(e => e.ImageSm)
                    .HasColumnName("ImageSM")
                    .HasMaxLength(255);

                entity.Property(e => e.ImageXs)
                    .HasColumnName("ImageXS")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("Candidate", "dbo");

                entity.HasIndex(e => e.FirstName)
                    .HasName("IX_Candidate_FirstName");

                entity.HasIndex(e => e.ImageStoreId)
                    .HasName("IX_FK_Candidate_ImageStoreId");

                entity.HasIndex(e => e.InvitationId)
                    .HasName("IX_FK_Candidate_Invitation");

                entity.HasIndex(e => e.LastName)
                    .HasName("IX_Candidate_LastName");

                entity.HasIndex(e => e.ProfileImageStoreId)
                    .HasName("IX_FK_Candidate_ProfileImageStoreId");

                entity.HasIndex(e => e.StateCode)
                    .HasName("IX_FK_Candidate_StateCode");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_Candidate_Candidate");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.ApisourceId).HasColumnName("APISourceId");

                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.ClientCreated)
                    .HasColumnName("clientCreated")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Facebook).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstTimeLogin).HasDefaultValueSql("'FALSE'");

                entity.Property(e => e.HasViewedSkillsInterests).HasDefaultValueSql("0");

                entity.Property(e => e.IsCheckinEnabled)
                    .HasColumnName("isCheckinEnabled")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsVerified).HasDefaultValueSql("0");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasColumnType("varchar(50)");

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.MyStory).HasMaxLength(500);

                entity.Property(e => e.NeedsPasswordReset).HasDefaultValueSql("'FALSE'");

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.StateCode).HasColumnType("char(2)");

                entity.Property(e => e.Twitter).HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ZipCode).HasMaxLength(10);

                entity.HasOne(d => d.ImageStore)
                    .WithMany(p => p.CandidateImageStore)
                    .HasForeignKey(d => d.ImageStoreId)
                    .HasConstraintName("FK_Candidate_ImageStoreId");

                entity.HasOne(d => d.Invitation)
                    .WithMany(p => p.Candidate)
                    .HasForeignKey(d => d.InvitationId)
                    .HasConstraintName("FK_Candidate_Invitation");

                entity.HasOne(d => d.ProfileImageStore)
                    .WithMany(p => p.CandidateProfileImageStore)
                    .HasForeignKey(d => d.ProfileImageStoreId)
                    .HasConstraintName("FK_Candidate_ProfileImageStoreId");

                entity.HasOne(d => d.StateCodeNavigation)
                    .WithMany(p => p.Candidate)
                    .HasForeignKey(d => d.StateCode)
                    .HasConstraintName("FK_Candidate_StateCode");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Candidate)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Candidate_Candidate");
            });

            modelBuilder.Entity<CandidateCallToAction>(entity =>
            {
                entity.ToTable("CandidateCallToAction", "dbo");

                entity.Property(e => e.DateActionTaken).HasColumnType("datetime");

                entity.Property(e => e.DateShownInitially).HasColumnType("datetime");

                entity.HasOne(d => d.CallToAction)
                    .WithMany(p => p.CandidateCallToAction)
                    .HasForeignKey(d => d.CallToActionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateCallToAction_CallToAction");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateCallToAction)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateCallToAction_Candidate");
            });

            modelBuilder.Entity<CandidateCause>(entity =>
            {
                entity.ToTable("CandidateCause", "dbo");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK_CandidateCause_CandidateId");

                entity.HasIndex(e => e.CauseId)
                    .HasName("IX_FK_CandidateCause_CauseId");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateCause)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateCause_CandidateId");

                entity.HasOne(d => d.Cause)
                    .WithMany(p => p.CandidateCause)
                    .HasForeignKey(d => d.CauseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateCause_CauseId");
            });

            modelBuilder.Entity<CandidateCoupon>(entity =>
            {
                entity.ToTable("CandidateCoupon", "dbo");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK_CandidateCoupon_Candidate");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_CandidateCoupon_NpnOrder");

                entity.HasIndex(e => e.OrderSharingId)
                    .HasName("IX_FK_CandidateCoupon_OrderSharing");

                entity.Property(e => e.Amount).HasColumnType("smallmoney");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateCoupon)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateCoupon_Candidate");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.CandidateCoupon)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateCoupon_NpnOrder");

                entity.HasOne(d => d.OrderSharing)
                    .WithMany(p => p.CandidateCoupon)
                    .HasForeignKey(d => d.OrderSharingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateCoupon_OrderSharing");
            });

            modelBuilder.Entity<CandidateCouponUsage>(entity =>
            {
                entity.HasKey(e => e.CandidateBalanceId)
                    .HasName("PK__Candidat__8220A8A9782C41EA");

                entity.ToTable("CandidateCouponUsage", "dbo");

                entity.Property(e => e.Amount).HasColumnType("smallmoney");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.HasOne(d => d.CandidateCoupon)
                    .WithMany(p => p.CandidateCouponUsage)
                    .HasForeignKey(d => d.CandidateCouponId)
                    .HasConstraintName("FK_CandidateCoupon_CandidateCouponUsage");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.CandidateCouponUsage)
                    .HasForeignKey(d => d.NpnOrderId)
                    .HasConstraintName("FK_NpnOrder_CandidateCouponUsage");
            });

            modelBuilder.Entity<CandidateEmailOption>(entity =>
            {
                entity.HasKey(e => new { e.CandidateId, e.EtemplateId })
                    .HasName("PK_CandidateEmailOption");

                entity.ToTable("CandidateEmailOption", "dbo");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK_CandidateEmailOption_Candidate");

                entity.HasIndex(e => e.EtemplateId)
                    .HasName("IX_FK_CandidateEmailOption_EmailTemplate");

                entity.Property(e => e.EtemplateId).HasColumnName("ETemplate_id");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateEmailOption)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateEmailOption_Candidate");

                entity.HasOne(d => d.Etemplate)
                    .WithMany(p => p.CandidateEmailOption)
                    .HasForeignKey(d => d.EtemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateEmailOption_EmailTemplate");
            });

            modelBuilder.Entity<CandidateEvent>(entity =>
            {
                entity.ToTable("CandidateEvent", "dbo");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK_CandidateEvent_CandidateId");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_CandidateEvent_ClientId");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateEvent)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateEvent_CandidateId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CandidateEvent)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateEvent_ClientId");
            });

            modelBuilder.Entity<CandidateForms>(entity =>
            {
                entity.HasKey(e => e.CandidateFormId)
                    .HasName("PK__Candidat__2142FC13222B06A9");

                entity.ToTable("CandidateForms", "dbo");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK__Candidate__Candi__25077354");

                entity.HasIndex(e => e.FormId)
                    .HasName("IX_FK__Candidate__FormI__24134F1B");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateForms)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Candidate__Candi__25077354");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.CandidateForms)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Candidate__FormI__24134F1B");
            });

            modelBuilder.Entity<CandidateInterest>(entity =>
            {
                entity.ToTable("CandidateInterest", "dbo");

                entity.HasIndex(e => new { e.CandidateId, e.InterestId })
                    .HasName("UIX_CandidateInterest")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateInterest)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateInterest_Candidate");

                entity.HasOne(d => d.Interest)
                    .WithMany(p => p.CandidateInterest)
                    .HasForeignKey(d => d.InterestId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateInterest_Interest");
            });

            modelBuilder.Entity<CandidateResponse>(entity =>
            {
                entity.ToTable("CandidateResponse", "dbo");

                entity.Property(e => e.OrderQuestionnaireId).HasDefaultValueSql("0");

                entity.Property(e => e.Ordinal).HasDefaultValueSql("0");

                entity.Property(e => e.QuestionText).IsRequired();

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateResponse)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK_CandidateResponse_Candidate");

                entity.HasOne(d => d.OrderQuestionnaire)
                    .WithMany(p => p.CandidateResponse)
                    .HasForeignKey(d => d.OrderQuestionnaireId)
                    .HasConstraintName("FK_CandidateResponse_OrderQuestionnaire");
            });

            modelBuilder.Entity<CandidateSecurityQuestions>(entity =>
            {
                entity.HasKey(e => e.CandidateSecQuestId)
                    .HasName("PK_CandidateSecQuestId");

                entity.ToTable("CandidateSecurityQuestions", "dbo");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK_CandidateSecurityQuestions_Candidate");

                entity.HasIndex(e => e.SecurityQuestionId)
                    .HasName("IX_FK_CandidateSecurityQuestions_SecurityQuestions");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.SecurityAnswer)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateSecurityQuestions)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateSecurityQuestions_Candidate");

                entity.HasOne(d => d.SecurityQuestion)
                    .WithMany(p => p.CandidateSecurityQuestions)
                    .HasForeignKey(d => d.SecurityQuestionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateSecurityQuestions_SecurityQuestions");
            });

            modelBuilder.Entity<CandidateSkill>(entity =>
            {
                entity.ToTable("CandidateSkill", "dbo");

                entity.HasIndex(e => new { e.CandidateId, e.SkillId })
                    .HasName("UIX_CandidateSkill")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateSkill)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateSkill_Candidate");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.CandidateSkill)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CandidateSkill_Skill");
            });

            modelBuilder.Entity<Cause>(entity =>
            {
                entity.ToTable("Cause", "dbo");

                entity.Property(e => e.CauseName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client", "dbo");

                entity.HasIndex(e => e.AccountName)
                    .HasName("IX_Client")
                    .IsUnique();

                entity.HasIndex(e => e.RootClientId)
                    .HasName("IX_Client_RootClientId");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'N.Parkway'");

                entity.Property(e => e.AddressLine2).HasMaxLength(50);

                entity.Property(e => e.AnnualContractValue).HasColumnType("decimal");

                entity.Property(e => e.AnnualForecastRev)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AnnualRev)
                    .HasColumnType("decimal")
                    .HasComputedColumnSql("[AnnualContractValue]")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ChargePilot).HasDefaultValueSql("'True'");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'Atlanta'");

                entity.Property(e => e.ContactEmail).HasMaxLength(100);

                entity.Property(e => e.ContactPhone).HasColumnType("varchar(15)");

                entity.Property(e => e.CustomerType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'Pilot'");

                entity.Property(e => e.DateActivated).HasColumnType("smalldatetime");

                entity.Property(e => e.Industry)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'Housing'");

                entity.Property(e => e.IsTestAccount).HasDefaultValueSql("0");

                entity.Property(e => e.Market)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NoNProfit'");

                entity.Property(e => e.OtherPlatforms).HasMaxLength(15);

                entity.Property(e => e.RevenueReportingClientId).HasDefaultValueSql("0");

                entity.Property(e => e.SalesforceLink).HasMaxLength(1024);

                entity.Property(e => e.SolomonBillingId)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'Unknown'");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'GA'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'Setup'");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("'3/27/2013'");

                entity.Property(e => e.SwabsolveAccountId).HasColumnName("SWAbsolveAccountId");

                entity.Property(e => e.TaxZipCode)
                    .IsRequired()
                    .HasColumnName("taxZipCode")
                    .HasColumnType("char(5)");

                entity.Property(e => e.VulnerableSector).HasDefaultValueSql("'False'");

                entity.Property(e => e.Website).HasMaxLength(200);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'30080'");

                entity.HasOne(d => d.MinProductLevelNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.MinProductLevel)
                    .HasConstraintName("FK__Client__MinProdu__1216311F");

                entity.HasOne(d => d.ParentClient)
                    .WithMany(p => p.InverseParentClient)
                    .HasForeignKey(d => d.ParentClientId)
                    .HasConstraintName("FK__Client__ParentCl__7ABDCA7B");

                entity.HasOne(d => d.RootClient)
                    .WithMany(p => p.InverseRootClient)
                    .HasForeignKey(d => d.RootClientId)
                    .HasConstraintName("FK__Client__RootClie__37C6D8BB");
            });

            modelBuilder.Entity<ClientConfiguration>(entity =>
            {
                entity.ToTable("ClientConfiguration", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_ClientConfiguration_Client");

                entity.Property(e => e.AdvRatingRestrictionsEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.ApiCallbackBaseUrl).HasMaxLength(128);

                entity.Property(e => e.ApiCallbackPassword).HasMaxLength(64);

                entity.Property(e => e.ApiCallbackUserName).HasMaxLength(64);

                entity.Property(e => e.ApiLogoPath).HasMaxLength(200);

                entity.Property(e => e.DisplayExtra1).HasDefaultValueSql("0");

                entity.Property(e => e.DisplayExtra2).HasDefaultValueSql("0");

                entity.Property(e => e.DisplayExtra3).HasDefaultValueSql("0");

                entity.Property(e => e.Extra1).HasMaxLength(15);

                entity.Property(e => e.Extra2).HasMaxLength(15);

                entity.Property(e => e.Extra3).HasMaxLength(15);

                entity.Property(e => e.HitDelivery).HasColumnType("varchar(500)");

                entity.Property(e => e.IsListExtra1).HasDefaultValueSql("0");

                entity.Property(e => e.IsListExtra2).HasDefaultValueSql("0");

                entity.Property(e => e.IsListExtra3).HasDefaultValueSql("0");

                entity.Property(e => e.ListValuesExtra1).HasColumnType("varchar(2000)");

                entity.Property(e => e.ListValuesExtra2).HasColumnType("varchar(2000)");

                entity.Property(e => e.ListValuesExtra3).HasColumnType("varchar(2000)");

                entity.Property(e => e.NonHitDelivery).HasColumnType("varchar(500)");

                entity.Property(e => e.PreferredContact).HasColumnType("varchar(10)");

                entity.Property(e => e.RequireExtra1).HasDefaultValueSql("0");

                entity.Property(e => e.RequireExtra2).HasDefaultValueSql("0");

                entity.Property(e => e.RequireExtra3).HasDefaultValueSql("0");

                entity.Property(e => e.ResendAttachments).HasDefaultValueSql("1");

                entity.Property(e => e.ReusePreviousNeglectAbuseScreen).HasDefaultValueSql("0");

                entity.Property(e => e.VolOrderInstructions).HasColumnType("varchar(255)");

                entity.Property(e => e.VolOrderTitle).HasColumnType("varchar(50)");

                entity.Property(e => e.VolOrderViewsDisplay).HasDefaultValueSql("0");

                entity.Property(e => e.VolOrderViewsInstruction).HasMaxLength(255);

                entity.Property(e => e.VolOrderViewsTitle).HasMaxLength(50);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientConfiguration)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientConfiguration_Client");
            });

            modelBuilder.Entity<ClientCredit>(entity =>
            {
                entity.ToTable("ClientCredit", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_ClientCredit_Client");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_ClientCredit_NpnOrder");

                entity.HasIndex(e => e.OrderSharingId)
                    .HasName("IX_FK_ClientCredit_OrderSharing");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientCredit)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientCredit_Client");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.ClientCredit)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientCredit_NpnOrder");

                entity.HasOne(d => d.OrderSharing)
                    .WithMany(p => p.ClientCredit)
                    .HasForeignKey(d => d.OrderSharingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientCredit_OrderSharing");
            });

            modelBuilder.Entity<ClientEmailOption>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.EtemplateId })
                    .HasName("PK_ClientEmailOption");

                entity.ToTable("ClientEmailOption", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_ClientEmailOption_Client");

                entity.HasIndex(e => e.EtemplateId)
                    .HasName("IX_FK_ClientEmailOption_EmailTemplate");

                entity.Property(e => e.EtemplateId).HasColumnName("ETemplate_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientEmailOption)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientEmailOption_Client");

                entity.HasOne(d => d.Etemplate)
                    .WithMany(p => p.ClientEmailOption)
                    .HasForeignKey(d => d.EtemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientEmailOption_EmailTemplate");
            });

            modelBuilder.Entity<ClientFeature>(entity =>
            {
                entity.ToTable("ClientFeature", "dbo");

                entity.Property(e => e.ClientFeatureId).HasColumnName("ClientFeatureID");

                entity.Property(e => e.AuthorizationValue).HasMaxLength(20);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientFeature)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ClientFea__Clien__34CB3BD6");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.ClientFeature)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ClientFea__Featu__35BF600F");
            });

            modelBuilder.Entity<ClientInterest>(entity =>
            {
                entity.ToTable("ClientInterest", "dbo");

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientInterest)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientInterest_Client");

                entity.HasOne(d => d.Interest)
                    .WithMany(p => p.ClientInterest)
                    .HasForeignKey(d => d.InterestId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientInterest_Interest");
            });

            modelBuilder.Entity<ClientPricing>(entity =>
            {
                entity.ToTable("ClientPricing", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_ClientPricing_Client");

                entity.HasIndex(e => e.NpnProductId)
                    .HasName("IX_FK_ClientPricing_ClientPricing");

                entity.Property(e => e.Amount).HasColumnType("smallmoney");

                entity.Property(e => e.EnteredBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PassBackAmount).HasColumnType("decimal");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientPricing)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientPricing_Client");

                entity.HasOne(d => d.NpnProduct)
                    .WithMany(p => p.ClientPricing)
                    .HasForeignKey(d => d.NpnProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientPricing_ClientPricing");
            });

            modelBuilder.Entity<ClientProductAuthorization>(entity =>
            {
                entity.ToTable("ClientProductAuthorization", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_ClientProductAuthorization_Client");

                entity.HasIndex(e => e.ProductAuthorizationId)
                    .HasName("IX_FK_ClientProductAuthorization_ProductAuthorization");

                entity.Property(e => e.ActivationKey).HasMaxLength(100);

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientProductAuthorization)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientProductAuthorization_Client");

                entity.HasOne(d => d.ProductAuthorization)
                    .WithMany(p => p.ClientProductAuthorization)
                    .HasForeignKey(d => d.ProductAuthorizationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientProductAuthorization_ProductAuthorization");
            });

            modelBuilder.Entity<ClientPromotion>(entity =>
            {
                entity.ToTable("ClientPromotion", "dbo");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_ClientPromotion_Name");

                entity.Property(e => e.Discount).HasColumnType("decimal");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientPromotion)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientPromotion_Client");
            });

            modelBuilder.Entity<ClientRatingRestriction>(entity =>
            {
                entity.ToTable("ClientRatingRestriction", "dbo");

                entity.HasIndex(e => new { e.ClientId, e.Name })
                    .HasName("UK_ClientId_Name")
                    .IsUnique();

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'#FFFFFF'");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientRatingRestriction)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientRatingRestrictionId_Client");
            });

            modelBuilder.Entity<ClientReport>(entity =>
            {
                entity.ToTable("ClientReport", "dbo");

                entity.Property(e => e.Description).HasMaxLength(1500);

                entity.Property(e => e.Parameters).HasMaxLength(500);

                entity.Property(e => e.ReportCodeName).HasMaxLength(100);

                entity.Property(e => e.ReportName).HasMaxLength(100);
            });

            modelBuilder.Entity<ClientReportAudit>(entity =>
            {
                entity.ToTable("ClientReportAudit", "dbo");

                entity.Property(e => e.DateRangeName).IsRequired();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ParametersJson).IsRequired();

                entity.Property(e => e.RunDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientReportAudit)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientReportAudit_Client");

                entity.HasOne(d => d.ClientReport)
                    .WithMany(p => p.ClientReportAudit)
                    .HasForeignKey(d => d.ClientReportId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientReportAudit_ClientReport");

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.ClientReportAudit)
                    .HasForeignKey(d => d.ClientUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientReportAudit_ClientUser");
            });

            modelBuilder.Entity<ClientReportParameter>(entity =>
            {
                entity.ToTable("ClientReportParameter", "dbo");

                entity.HasIndex(e => new { e.ClientReportId, e.Ordinal })
                    .HasName("UX_ClientReportParameter")
                    .IsUnique();

                entity.Property(e => e.ClientReportId).IsRequired();

                entity.Property(e => e.Ordinal).IsRequired();

                entity.Property(e => e.ParameterName).HasMaxLength(50);

                entity.Property(e => e.UicontrolType)
                    .HasColumnName("UIControlType")
                    .HasMaxLength(50);

                entity.Property(e => e.UserParameterName).HasMaxLength(50);

                entity.Property(e => e.ValidValues).HasMaxLength(500);

                entity.HasOne(d => d.ClientReport)
                    .WithMany(p => p.ClientReportParameter)
                    .HasForeignKey(d => d.ClientReportId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientReportParameter_ClientReport");
            });

            modelBuilder.Entity<ClientReportParameterValueSet>(entity =>
            {
                entity.ToTable("ClientReportParameterValueSet", "dbo");

                entity.Property(e => e.UserValueName).HasMaxLength(50);

                entity.Property(e => e.ValueName).HasMaxLength(100);

                entity.HasOne(d => d.ClientReportParameter)
                    .WithMany(p => p.ClientReportParameterValueSet)
                    .HasForeignKey(d => d.ClientReportParameterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientReportParameterValueSet_ClientReportParameter");
            });

            modelBuilder.Entity<ClientSkill>(entity =>
            {
                entity.ToTable("ClientSkill", "dbo");

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientSkill)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientSkill_Client");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.ClientSkill)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientSkill_Skill");
            });

            modelBuilder.Entity<ClientSsoSettings>(entity =>
            {
                entity.ToTable("ClientSsoSettings", "dbo");

                entity.Property(e => e.ClientSsosettingsId).HasColumnName("ClientSSOSettingsId");

                entity.Property(e => e.ApiCandidateIdJsonPath).HasMaxLength(255);

                entity.Property(e => e.ClientBaseAddress).HasMaxLength(255);

                entity.Property(e => e.ClientCertApi).HasMaxLength(255);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientSsoSettings)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientSsoSettings_Client");
            });

            modelBuilder.Entity<ClientStaffCommission>(entity =>
            {
                entity.ToTable("ClientStaffCommission", "dbo");

                entity.Property(e => e.CommissionAppPartner).HasDefaultValueSql("0");

                entity.Property(e => e.CommissionAppReseller).HasDefaultValueSql("0");

                entity.Property(e => e.Email).HasMaxLength(80);

                entity.Property(e => e.Extension).HasMaxLength(20);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PrimaryAm).HasColumnName("PrimaryAM");

                entity.Property(e => e.PrimaryCse).HasColumnName("PrimaryCSE");

                entity.Property(e => e.SecondaryAm).HasColumnName("SecondaryAM");

                entity.Property(e => e.SecondaryCse).HasColumnName("SecondaryCSE");

                entity.Property(e => e.TimeZone).HasMaxLength(50);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientStaffCommission)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientStaffCommission_Client");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.ClientStaffCommission)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_ClientStaffCommission_PartnerId");
            });

            modelBuilder.Entity<ClientStaffCommissionSalesRep>(entity =>
            {
                entity.ToTable("ClientStaffCommissionSalesRep", "dbo");

                entity.HasIndex(e => e.ClientStaffCommissionId)
                    .HasName("IX_FK_ClientStaffCommissionSalesRep_ClientStaffCommission");

                entity.HasIndex(e => e.SalesRepId)
                    .HasName("IX_FK_ClientStaffCommissionSalesRep_Staff");

                entity.HasOne(d => d.ClientStaffCommission)
                    .WithMany(p => p.ClientStaffCommissionSalesRep)
                    .HasForeignKey(d => d.ClientStaffCommissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientStaffCommissionSalesRep_ClientStaffCommission");

                entity.HasOne(d => d.SalesRep)
                    .WithMany(p => p.ClientStaffCommissionSalesRep)
                    .HasForeignKey(d => d.SalesRepId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientStaffCommissionSalesRep_Staff");
            });

            modelBuilder.Entity<ClientStates>(entity =>
            {
                entity.HasKey(e => e.ClientStateId)
                    .HasName("PK_ClientStates");

                entity.ToTable("ClientStates", "dbo");

                entity.HasIndex(e => new { e.ClientId, e.StateCode })
                    .HasName("IX_ClientStates")
                    .IsUnique();

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasColumnType("char(2)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientStates)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientStates_Client");

                entity.HasOne(d => d.StateCodeNavigation)
                    .WithMany(p => p.ClientStates)
                    .HasForeignKey(d => d.StateCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientStates_States");
            });

            modelBuilder.Entity<ClientUser>(entity =>
            {
                entity.ToTable("ClientUser", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_ClientUser_Client");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_ClientUser_Users");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'N.Parkway'");

                entity.Property(e => e.AddressLine2).HasMaxLength(50);

                entity.Property(e => e.AllViews).HasDefaultValueSql("0");

                entity.Property(e => e.ChangePassword).HasDefaultValueSql("'False'");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'Atlanta'");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.FacebookLink).HasMaxLength(200);

                entity.Property(e => e.FacebookPassword).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'DEFAULTFName'");

                entity.Property(e => e.IsEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'DEFAULTLName'");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'0000000000'");

                entity.Property(e => e.Salutation).HasMaxLength(10);

                entity.Property(e => e.ShowAccount)
                    .HasColumnName("showAccount")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShowAddress)
                    .HasColumnName("showAddress")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowDob)
                    .HasColumnName("showDOB")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShowEmail)
                    .HasColumnName("showEmail")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowExtra1)
                    .HasColumnName("showExtra1")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowExtra2)
                    .HasColumnName("showExtra2")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowExtra3)
                    .HasColumnName("showExtra3")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowInvitationDate)
                    .HasColumnName("showInvitationDate")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowLastAdjudicationDate)
                    .HasColumnName("showLastAdjudicationDate")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShowLastNpnOrderId)
                    .HasColumnName("showLastNpnOrderId")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShowLastScreen)
                    .HasColumnName("showLastScreen")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowLastUpdate)
                    .HasColumnName("showLastUpdate")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowLevelScreen)
                    .HasColumnName("showLevelScreen")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowName)
                    .HasColumnName("showName")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowPhone)
                    .HasColumnName("showPhone")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowPosition)
                    .HasColumnName("showPosition")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowRatingRestrictions)
                    .HasColumnName("showRatingRestrictions")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowShared)
                    .HasColumnName("showShared")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowStatus)
                    .HasColumnName("showStatus")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.ShowVolunteerSince)
                    .HasColumnName("showVolunteerSince")
                    .HasDefaultValueSql("'False'");

                entity.Property(e => e.SmsPhone).HasMaxLength(20);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'GA'");

                entity.Property(e => e.SterlingWestUserName).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.TwitterLink).HasMaxLength(200);

                entity.Property(e => e.TwitterPassword).HasMaxLength(20);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'30080'");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientUser)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientUser_Client");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClientUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientUser_Users");
            });

            modelBuilder.Entity<ClientUserConsent>(entity =>
            {
                entity.ToTable("ClientUserConsent", "dbo");

                entity.HasIndex(e => new { e.ClientUserId, e.VersionNumber })
                    .HasName("UX_ClientUserId_VersionNumber")
                    .IsUnique();

                entity.Property(e => e.ConsentDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.ClientUserConsent)
                    .HasForeignKey(d => d.ClientUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientUserConsent_ClientUser");
            });

            modelBuilder.Entity<ClientView>(entity =>
            {
                entity.ToTable("ClientView", "dbo");

                entity.HasIndex(e => new { e.ClientId, e.Name })
                    .HasName("UX_ClientView")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientView)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientView_Client");
            });

            modelBuilder.Entity<ClientViewClientUser>(entity =>
            {
                entity.ToTable("ClientViewClientUser", "dbo");

                entity.HasIndex(e => new { e.ClientViewId, e.ClientUserId })
                    .HasName("UX_ClientViewClientUser")
                    .IsUnique();

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.ClientViewClientUser)
                    .HasForeignKey(d => d.ClientUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientViewClientUser_ClientUser");

                entity.HasOne(d => d.ClientView)
                    .WithMany(p => p.ClientViewClientUser)
                    .HasForeignKey(d => d.ClientViewId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ClientViewClientUser_ClientView");
            });

            modelBuilder.Entity<Cloud>(entity =>
            {
                entity.ToTable("Cloud", "dbo");

                entity.Property(e => e.DateEntered).HasColumnType("date");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Cloud)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_UserCloud");
            });

            modelBuilder.Entity<ConsentForm>(entity =>
            {
                entity.ToTable("ConsentForm", "dbo");

                entity.Property(e => e.MvcAction).HasMaxLength(100);

                entity.Property(e => e.MvcArea).HasMaxLength(100);

                entity.Property(e => e.MvcController).HasMaxLength(100);

                entity.Property(e => e.StateCode).HasMaxLength(2);

                entity.HasOne(d => d.NpnProduct)
                    .WithMany(p => p.ConsentForm)
                    .HasForeignKey(d => d.NpnProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ConsentForm_NpnProduct");
            });

            modelBuilder.Entity<ConsentFormParameter>(entity =>
            {
                entity.ToTable("ConsentFormParameter", "dbo");

                entity.Property(e => e.ColumnName).HasColumnType("varchar(50)");

                entity.Property(e => e.DefaultValue).HasColumnType("varchar(50)");

                entity.Property(e => e.DisplayName).HasColumnType("varchar(50)");

                entity.Property(e => e.TableName).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("Content", "dbo");

                entity.HasIndex(e => new { e.ContentPageId, e.ContentSectionId, e.ContentTypeId })
                    .HasName("uc_ContentArea")
                    .IsUnique();

                entity.Property(e => e.Heading)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IsCustomizableClient).HasDefaultValueSql("0");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Replacements)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TemplateHtml)
                    .HasColumnName("TemplateHTML")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CountySourceFee>(entity =>
            {
                entity.HasKey(e => new { e.State, e.County })
                    .HasName("PK_CountySourceFee");

                entity.ToTable("CountySourceFee", "dbo");

                entity.Property(e => e.State).HasColumnType("varchar(2)");

                entity.Property(e => e.County).HasColumnType("varchar(50)");

                entity.Property(e => e.SourceFee).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<CouponPrice>(entity =>
            {
                entity.ToTable("CouponPrice", "dbo");

                entity.Property(e => e.CouponPriceId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("smallmoney");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("nchar(100)");
            });

            modelBuilder.Entity<CustomContent>(entity =>
            {
                entity.ToTable("CustomContent", "dbo");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.Heading)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.TimesUsed).HasDefaultValueSql("0");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CustomContent)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("fk_ClientId");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.CustomContent)
                    .HasForeignKey(d => d.ContentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_ContentId");
            });

            modelBuilder.Entity<CustomSort>(entity =>
            {
                entity.ToTable("CustomSort", "dbo");

                entity.Property(e => e.CustomSortName).HasMaxLength(50);

                entity.Property(e => e.FilterFieldName).HasMaxLength(50);

                entity.Property(e => e.FilterFieldValue).HasMaxLength(50);

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.CustomSort)
                    .HasForeignKey(d => d.ClientUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CustomSort_ClientUser");
            });

            modelBuilder.Entity<CustomSortColumn>(entity =>
            {
                entity.ToTable("CustomSortColumn", "dbo");

                entity.Property(e => e.UicolumnId).HasColumnName("UIColumnId");

                entity.HasOne(d => d.CustomSort)
                    .WithMany(p => p.CustomSortColumn)
                    .HasForeignKey(d => d.CustomSortId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CustomSortColumn_CustomSort");

                entity.HasOne(d => d.SortOrder)
                    .WithMany(p => p.CustomSortColumn)
                    .HasForeignKey(d => d.SortOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CustomSortColumn_SortOrder");

                entity.HasOne(d => d.Uicolumn)
                    .WithMany(p => p.CustomSortColumn)
                    .HasForeignKey(d => d.UicolumnId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CustomSortColumn_UIColumn");
            });

            modelBuilder.Entity<CustomizedEmailTemplate>(entity =>
            {
                entity.HasKey(e => e.CustomizedTemplateId)
                    .HasName("PK__Customiz__6D217C302959892A");

                entity.ToTable("CustomizedEmailTemplate", "dbo");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DescriptionPrevious).IsRequired();

                entity.Property(e => e.EtemplateId).HasColumnName("ETemplate_id");

                entity.Property(e => e.LayoutId).HasDefaultValueSql("1");

                entity.Property(e => e.SendFromClient).HasDefaultValueSql("0");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SubjectPrevious)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CustomizedEmailTemplate)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__Customize__Clien__2C35F5D5");

                entity.HasOne(d => d.Etemplate)
                    .WithMany(p => p.CustomizedEmailTemplate)
                    .HasForeignKey(d => d.EtemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Customize__ETemp__2B41D19C");

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.CustomizedEmailTemplate)
                    .HasForeignKey(d => d.LayoutId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CustomizedEmailTemplate_Layout");
            });

            modelBuilder.Entity<CustomizedEmailTemplateAttachment>(entity =>
            {
                entity.ToTable("CustomizedEmailTemplateAttachment", "dbo");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.CustomizedEmailTemplateAttachment)
                    .HasForeignKey(d => d.AttachmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CustomizedEmailTemplateAttachment_Attachment");

                entity.HasOne(d => d.CustomizedTemplate)
                    .WithMany(p => p.CustomizedEmailTemplateAttachment)
                    .HasForeignKey(d => d.CustomizedTemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CustomizedEmailTemplateAttachment_CustomizedEmailTemplate");
            });

            modelBuilder.Entity<DbPatch>(entity =>
            {
                entity.HasKey(e => new { e.Major, e.Minor, e.Patch })
                    .HasName("PK_DbPatch");

                entity.ToTable("DbPatch", "dbo");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DocumentTemplate>(entity =>
            {
                entity.HasKey(e => e.DocTemplateId)
                    .HasName("PK_DocumentTemplate");

                entity.ToTable("DocumentTemplate", "dbo");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<EmailHistory>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_EmailHistory");

                entity.ToTable("EmailHistory", "dbo");

                entity.HasIndex(e => e.EmailTemplateId)
                    .HasName("IX_FK_EmailHistory_EmailTemplate1");

                entity.Property(e => e.BccAddress).HasMaxLength(255);

                entity.Property(e => e.CcAddress).HasMaxLength(255);

                entity.Property(e => e.FromAddress).HasMaxLength(255);

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(250);

                entity.Property(e => e.ToAddress).HasMaxLength(500);

                entity.HasOne(d => d.EmailTemplate)
                    .WithMany(p => p.EmailHistory)
                    .HasForeignKey(d => d.EmailTemplateId)
                    .HasConstraintName("FK_EmailHistory_EmailTemplate1");
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.HasKey(e => e.EtemplateId)
                    .HasName("PK_EmailTemplate");

                entity.ToTable("EmailTemplate", "dbo");

                entity.Property(e => e.EtemplateId).HasColumnName("ETemplate_id");

                entity.Property(e => e.ClientToggleable).HasDefaultValueSql("0");

                entity.Property(e => e.IsCustomizable).HasDefaultValueSql("0");

                entity.Property(e => e.IsCustomizableStaff).HasDefaultValueSql("0");

                entity.Property(e => e.LayoutId).HasDefaultValueSql("1");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SendFromClientEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.EmailTemplate)
                    .HasForeignKey(d => d.LayoutId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmailTemplate_Layout");
            });

            modelBuilder.Entity<Endorsement>(entity =>
            {
                entity.ToTable("Endorsement", "dbo");

                entity.HasIndex(e => e.NpnProductId)
                    .HasName("IX_FK_Endorsement_NpnProduct");

                entity.Property(e => e.EndorsementName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.HasOne(d => d.NpnProduct)
                    .WithMany(p => p.Endorsement)
                    .HasForeignKey(d => d.NpnProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Endorsement_NpnProduct");
            });

            modelBuilder.Entity<EnumLookup>(entity =>
            {
                entity.HasKey(e => new { e.EnumSet, e.Ordinal })
                    .HasName("PK_EnumLookup");

                entity.ToTable("EnumLookup", "dbo");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ErrorCount>(entity =>
            {
                entity.ToTable("ErrorCount", "dbo");

                entity.Property(e => e.ErrorTime).HasColumnType("datetime");

                entity.Property(e => e.Message).HasColumnType("varchar(500)");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.ToTable("Feature", "dbo");

                entity.Property(e => e.AuthorizationLabel).HasMaxLength(20);

                entity.Property(e => e.AuthorizationRequirement).HasDefaultValueSql("2");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<FormStore>(entity =>
            {
                entity.HasKey(e => e.FormId)
                    .HasName("PK__FormStor__FB05B7DD1C722D53");

                entity.ToTable("FormStore", "dbo");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_FK__FormStore__FormS__1E5A75C5");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FormStoreItem).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FormStore)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__FormStore__FormS__1E5A75C5");
            });

            modelBuilder.Entity<Holidays>(entity =>
            {
                entity.HasKey(e => e.HolidayId)
                    .HasName("PK_Holidays");

                entity.ToTable("Holidays", "dbo");

                entity.HasIndex(e => e.ActualDate)
                    .HasName("IX_Holidays_ActualDate");

                entity.HasIndex(e => e.ObservedDate)
                    .HasName("IX_Holidays_ObservedDate");

                entity.HasIndex(e => new { e.HolidayYear, e.HolidayMonth })
                    .HasName("IX_Holidays_YearMonth");

                entity.Property(e => e.HolidayId).HasColumnName("HolidayID");

                entity.Property(e => e.ActualDate).HasColumnType("datetime");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.FederalHoliday).HasDefaultValueSql("0");

                entity.Property(e => e.HolidayName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ObservedDate).HasColumnType("datetime");

                entity.Property(e => e.SterlingHoliday).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<IdAuthenticationResult>(entity =>
            {
                entity.ToTable("IdAuthenticationResult", "dbo");

                entity.HasIndex(e => new { e.NpnOrderId, e.ModificationConsentDate, e.Score })
                    .HasName("IX_IdAuthenticationResult_Idx1");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AuthenticationGuid)
                    .IsRequired()
                    .HasMaxLength(36);

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.Dlnumber)
                    .HasColumnName("DLNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(6);

                entity.Property(e => e.ImageSubmissionConsentDate).HasColumnType("datetime");

                entity.Property(e => e.IssuanceDate).HasColumnType("date");

                entity.Property(e => e.IssuingState).HasMaxLength(2);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.ModificationConsentDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessingCompletedOn).HasColumnType("datetime");

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.SubmittedOn).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Zip).HasMaxLength(11);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.IdAuthenticationResult)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IdAuthenticationResult_Candidate");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.IdAuthenticationResult)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IdAuthenticationResult_NpnOrder");
            });

            modelBuilder.Entity<IdAuthenticationResultModification>(entity =>
            {
                entity.ToTable("IdAuthenticationResultModification", "dbo");

                entity.Property(e => e.InitialValue).HasMaxLength(200);

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ModifiedValue)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.IdAuthenticationResult)
                    .WithMany(p => p.IdAuthenticationResultModification)
                    .HasForeignKey(d => d.IdAuthenticationResultId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IdAuthenticationResultModification_IdAuthenticationResult");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.IdAuthenticationResultModification)
                    .HasForeignKey(d => d.NpnOrderId)
                    .HasConstraintName("FK_IdAuthenticationResultModification_NpnOrder");
            });

            modelBuilder.Entity<ImageStore>(entity =>
            {
                entity.HasKey(e => e.ImageId)
                    .HasName("PK__ImageSto__7516F70C2DE6D218");

                entity.ToTable("ImageStore", "dbo");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_FK__ImageStor__Image__2FCF1A8A");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ImageStoreItem).IsRequired();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ImageStore)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ImageStor__Image__2FCF1A8A");
            });

            modelBuilder.Entity<Interest>(entity =>
            {
                entity.ToTable("Interest", "dbo");

                entity.HasIndex(e => new { e.InterestName, e.InterestCategory })
                    .HasName("uc_InterestName_InterestCategory")
                    .IsUnique();

                entity.Property(e => e.InterestCategory)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InterestName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Invitation>(entity =>
            {
                entity.ToTable("Invitation", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_Invitation_Client");

                entity.HasIndex(e => e.PositionId)
                    .HasName("IX_FK_Invitation_Position");

                entity.HasIndex(e => e.PositionListingId)
                    .HasName("IX_FK_Invitation_PositionListing");

                entity.Property(e => e.Bcc)
                    .HasColumnName("BCC")
                    .HasMaxLength(250);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(250);

                entity.Property(e => e.DateSent).HasColumnType("smalldatetime");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastSent).HasColumnType("datetime");

                entity.Property(e => e.Shared).HasDefaultValueSql("'False'");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Invitation)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Invitation_Client");

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.Invitation)
                    .HasForeignKey(d => d.ClientUserId)
                    .HasConstraintName("FK__Invitatio__Creat__6AC759D4");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Invitation)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Invitation_Position");

                entity.HasOne(d => d.PositionListing)
                    .WithMany(p => p.Invitation)
                    .HasForeignKey(d => d.PositionListingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Invitation_PositionListing");
            });

            modelBuilder.Entity<InvitationAttachment>(entity =>
            {
                entity.ToTable("InvitationAttachment", "dbo");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.InvitationAttachment)
                    .HasForeignKey(d => d.AttachmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InvitationAttachment_Attachment");

                entity.HasOne(d => d.Invitation)
                    .WithMany(p => p.InvitationAttachment)
                    .HasForeignKey(d => d.InvitationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InvitationAttachment_Invitation");
            });

            modelBuilder.Entity<JurisMappedCounty>(entity =>
            {
                entity.ToTable("JurisMappedCounty", "dbo");

                entity.Property(e => e.CourtName).HasColumnType("varchar(100)");

                entity.Property(e => e.MappedCounty)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OffenseCounty).HasColumnType("varchar(50)");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<JurisOrder>(entity =>
            {
                entity.ToTable("JurisOrder", "dbo");

                entity.HasIndex(e => e.JurisId)
                    .HasName("IX_FK_JurisOrder_Juris");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_JurisOrder_NpnOrder");

                entity.Property(e => e.Municipality).HasColumnType("varchar(50)");

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.RegulatedJuris).HasDefaultValueSql("0");

                entity.Property(e => e.State).HasColumnType("varchar(50)");

                entity.Property(e => e.SterlingWestProductId).HasDefaultValueSql("0");

                entity.HasOne(d => d.Juris)
                    .WithMany(p => p.JurisOrder)
                    .HasForeignKey(d => d.JurisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JurisOrder_Juris");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.JurisOrder)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JurisOrder_NpnOrder");

                entity.HasOne(d => d.SourceType)
                    .WithMany(p => p.JurisOrder)
                    .HasForeignKey(d => d.SourceTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JurisOrder_SourceType");
            });

            modelBuilder.Entity<JurisProcessing>(entity =>
            {
                entity.HasKey(e => e.State)
                    .HasName("PK_JurisProcessing");

                entity.ToTable("JurisProcessing", "dbo");

                entity.Property(e => e.State).HasColumnType("char(2)");

                entity.Property(e => e.RegulatedJuris).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<JurisSourceFee>(entity =>
            {
                entity.HasKey(e => new { e.JurisType, e.JurisRoot, e.JurisDesc })
                    .HasName("PK_JurisSourceFee_1");

                entity.ToTable("JurisSourceFee", "dbo");

                entity.Property(e => e.JurisRoot).HasColumnType("varchar(10)");

                entity.Property(e => e.JurisDesc).HasColumnType("varchar(40)");

                entity.Property(e => e.AltJurisFee)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CivilJurisFee)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.JurisFee).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<JurisStateDistrictCounty>(entity =>
            {
                entity.ToTable("JurisStateDistrictCounty", "dbo");

                entity.Property(e => e.JurisStateDistrictCountyId).ValueGeneratedNever();

                entity.Property(e => e.CountyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<JurisUpdate>(entity =>
            {
                entity.ToTable("JurisUpdate", "dbo");

                entity.HasIndex(e => e.JurisId)
                    .HasName("IX_FK_JurisUpdate_JurisId");

                entity.HasIndex(e => e.OrderUpdateId)
                    .HasName("IX_FK_JurisUpdate_OrderUpdateId");

                entity.HasIndex(e => e.SourceTypeId)
                    .HasName("IX_FK_JurisUpdate_SourceTypeId");

                entity.Property(e => e.Municipality).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.SourceTypeId).HasDefaultValueSql("1");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.HasOne(d => d.Juris)
                    .WithMany(p => p.JurisUpdate)
                    .HasForeignKey(d => d.JurisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JurisUpdate_JurisId");

                entity.HasOne(d => d.OrderUpdate)
                    .WithMany(p => p.JurisUpdate)
                    .HasForeignKey(d => d.OrderUpdateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JurisUpdate_OrderUpdateId");

                entity.HasOne(d => d.SourceType)
                    .WithMany(p => p.JurisUpdate)
                    .HasForeignKey(d => d.SourceTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JurisUpdate_SourceTypeId");
            });

            modelBuilder.Entity<JurisZipCodesMultiCounty>(entity =>
            {
                entity.HasKey(e => e.JurisZipCodeId)
                    .HasName("PK_JurisZipCodes_MultiCounty");

                entity.ToTable("JurisZipCodes_MultiCounty", "dbo");

                entity.HasIndex(e => e.ZipCode)
                    .HasName("IX_JurisZipCodes_MultiCounty_ZipCode");

                entity.HasIndex(e => new { e.ZipCode, e.State, e.County })
                    .HasName("UX_JurisZipCodes_MultiCounty")
                    .IsUnique();

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnType("char(2)");
            });

            modelBuilder.Entity<Jurisdiction>(entity =>
            {
                entity.HasKey(e => e.JurisId)
                    .HasName("PK_Juris");

                entity.ToTable("Jurisdiction", "dbo");

                entity.Property(e => e.JurisId).ValueGeneratedNever();

                entity.Property(e => e.JurisDesc)
                    .IsRequired()
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.JurisRoot)
                    .IsRequired()
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Layout>(entity =>
            {
                entity.ToTable("Layout", "dbo");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.Shell).HasColumnType("text");
            });

            modelBuilder.Entity<Locking>(entity =>
            {
                entity.ToTable("Locking", "dbo");

                entity.Property(e => e.LockingId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MaintenanceWindow>(entity =>
            {
                entity.ToTable("MaintenanceWindow", "dbo");

                entity.Property(e => e.CreatedByAutomation).HasDefaultValueSql("0");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.RecurringType).HasDefaultValueSql("0");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Memberships>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Membersh__1788CC4C3C74E891");

                entity.ToTable("Memberships", "dbo");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("IX_MembershipApplication");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasMaxLength(256);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowsStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Memberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("MembershipApplication");
            });

            modelBuilder.Entity<NationalCrimArchive>(entity =>
            {
                entity.HasKey(e => e.NationCrimArchiveId)
                    .HasName("PK_NationalCrimArchive");

                entity.ToTable("NationalCrimArchive", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_NationalCrimArchive_NpnOrder");

                entity.Property(e => e.NationalCrimData)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.NationalCrimArchive)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NationalCrimArchive_NpnOrder");
            });

            modelBuilder.Entity<NationalCrimCache>(entity =>
            {
                entity.HasKey(e => new { e.NationalCrimCacheId, e.FirstName, e.LastName })
                    .HasName("PK_NationalCrimCache");

                entity.ToTable("NationalCrimCache", "dbo");

                entity.HasIndex(e => e.DateOfBirth)
                    .HasName("ix_NationalCrimCache_DOB");

                entity.Property(e => e.NationalCrimCacheId).ValueGeneratedOnAdd();

                entity.Property(e => e.FirstName).HasColumnType("varchar(30)");

                entity.Property(e => e.LastName).HasColumnType("varchar(40)");

                entity.Property(e => e.ResponseXml)
                    .IsRequired()
                    .HasColumnName("ResponseXML")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<NationalCrimCaseArchive>(entity =>
            {
                entity.ToTable("NationalCrimCaseArchive", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_NationalCrimCaseArchive_NpnOrder");

                entity.Property(e => e.CaseNumbers).HasColumnType("varchar(500)");

                entity.Property(e => e.County).HasColumnType("varchar(50)");

                entity.Property(e => e.CourtName).HasColumnType("varchar(100)");

                entity.Property(e => e.DateOfBirth).HasColumnType("varchar(15)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(50)");

                entity.Property(e => e.LastName).HasColumnType("varchar(50)");

                entity.Property(e => e.MiddleName).HasColumnType("varchar(50)");

                entity.Property(e => e.State).HasColumnType("varchar(50)");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.NationalCrimCaseArchive)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NationalCrimCaseArchive_NpnOrder");
            });

            modelBuilder.Entity<NationalCrimCaseHash>(entity =>
            {
                entity.ToTable("NationalCrimCaseHash", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_NationalCrimCaseHash_NpnOrderId");

                entity.HasIndex(e => e.OrderUpdateId)
                    .HasName("IX_FK_NationalCrimCaseHash_OrderUpdateId");

                entity.Property(e => e.CaseNumbers).HasColumnType("varchar(500)");

                entity.Property(e => e.County).HasMaxLength(100);

                entity.Property(e => e.CourtName).HasMaxLength(100);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.HashValue)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NewCase).HasDefaultValueSql("0");

                entity.Property(e => e.State).HasMaxLength(100);

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.NationalCrimCaseHash)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NationalCrimCaseHash_NpnOrderId");

                entity.HasOne(d => d.OrderUpdate)
                    .WithMany(p => p.NationalCrimCaseHash)
                    .HasForeignKey(d => d.OrderUpdateId)
                    .HasConstraintName("FK_NationalCrimCaseHash_OrderUpdateId");
            });

            modelBuilder.Entity<NewsArticle>(entity =>
            {
                entity.HasKey(e => e.NewsId)
                    .HasName("PK_NewsArticle");

                entity.ToTable("NewsArticle", "dbo");

                entity.HasIndex(e => e.ImageStoreId)
                    .HasName("IX_FK_NewsArticle_ImageStore");

                entity.Property(e => e.Author)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'Unknown'");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'Unknown'");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ImageStore)
                    .WithMany(p => p.NewsArticle)
                    .HasForeignKey(d => d.ImageStoreId)
                    .HasConstraintName("FK_NewsArticle_ImageStore");
            });

            modelBuilder.Entity<NpnOrder>(entity =>
            {
                entity.ToTable("NpnOrder", "dbo");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK_NpnOrder_Candidate");

                entity.HasIndex(e => e.InvitationId)
                    .HasName("IX_FK_NpnOrder_Invitation");

                entity.HasIndex(e => e.OrderClientUserId)
                    .HasName("IX_FK_NpnOrder_OrderClientUserId");

                entity.HasIndex(e => e.PaymentId)
                    .HasName("IX_fk_paymentid");

                entity.HasIndex(e => e.PositionListingId)
                    .HasName("IX_FK_NpnOrder_PositionListing");

                entity.Property(e => e.AbsolveOrderTypeId).HasDefaultValueSql("0");

                entity.Property(e => e.AbsolveSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.AmountCoupon)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AmountOrganization).HasColumnType("smallmoney");

                entity.Property(e => e.AmountTax).HasColumnType("smallmoney");

                entity.Property(e => e.ApisourceId).HasColumnName("APISourceId");

                entity.Property(e => e.AuthenticationAttempts).HasDefaultValueSql("0");

                entity.Property(e => e.BeforeDonationTotal).HasColumnType("smallmoney");

                entity.Property(e => e.CreditReportAccessDate).HasColumnType("datetime");

                entity.Property(e => e.CreditReportViewable).HasDefaultValueSql("'False'");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDue).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("'1900-1-1'");

                entity.Property(e => e.Donation).HasColumnType("smallmoney");

                entity.Property(e => e.EmailAddr)
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("'Unknown'");

                entity.Property(e => e.EstimatedCompleteDate).HasColumnType("datetime");

                entity.Property(e => e.Extra1).HasMaxLength(50);

                entity.Property(e => e.Extra2).HasMaxLength(50);

                entity.Property(e => e.Extra3).HasMaxLength(50);

                entity.Property(e => e.FinalTotal).HasColumnType("smallmoney");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("'Unknown'");

                entity.Property(e => e.Gender).HasDefaultValueSql("0");

                entity.Property(e => e.HoldDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("'Unknown'");

                entity.Property(e => e.MiddleName).HasColumnType("varchar(30)");

                entity.Property(e => e.MvrfirstName)
                    .HasColumnName("MVRFirstName")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.MvrlastName)
                    .HasColumnName("MVRLastName")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Mvrlicense)
                    .HasColumnName("MVRLicense")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.MvrmiddleName)
                    .HasColumnName("MVRMiddleName")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Mvrstate)
                    .HasColumnName("MVRState")
                    .HasColumnType("char(2)");

                entity.Property(e => e.NextOrderUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'Unknown'");

                entity.Property(e => e.ProcessStatusId).HasDefaultValueSql("0");

                entity.Property(e => e.PromoCode).HasMaxLength(32);

                entity.Property(e => e.ResubmitAttemptCount).HasDefaultValueSql("0");

                entity.Property(e => e.SalesTaxRate).HasColumnType("decimal");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SubTotal).HasColumnType("smallmoney");

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.SuffixName).HasColumnType("varchar(6)");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.NpnOrder)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NpnOrder_Candidate");

                entity.HasOne(d => d.HoldSubmitClientUser)
                    .WithMany(p => p.NpnOrderHoldSubmitClientUser)
                    .HasForeignKey(d => d.HoldSubmitClientUserId)
                    .HasConstraintName("FK_NpnOrder_HoldSubmitClientUserId");

                entity.HasOne(d => d.Invitation)
                    .WithMany(p => p.NpnOrder)
                    .HasForeignKey(d => d.InvitationId)
                    .HasConstraintName("FK_NpnOrder_Invitation");

                entity.HasOne(d => d.OrderClientUser)
                    .WithMany(p => p.NpnOrderOrderClientUser)
                    .HasForeignKey(d => d.OrderClientUserId)
                    .HasConstraintName("FK_NpnOrder_OrderClientUserId");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.NpnOrder)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("fk_paymentid");

                entity.HasOne(d => d.PositionListing)
                    .WithMany(p => p.NpnOrderPositionListing)
                    .HasForeignKey(d => d.PositionListingId)
                    .HasConstraintName("FK_NpnOrder_PositionListing");

                entity.HasOne(d => d.VolPositionListing)
                    .WithMany(p => p.NpnOrderVolPositionListing)
                    .HasForeignKey(d => d.VolPositionListingId)
                    .HasConstraintName("FK_NpnOrder_VolPositionListing");
            });

            modelBuilder.Entity<NpnOrderProduct>(entity =>
            {
                entity.ToTable("NpnOrderProduct", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_NpnOrderProduct_NpnOrder");

                entity.HasIndex(e => e.NpnProductId)
                    .HasName("IX_FK_NpnOrderProduct_NPNProducts");

                entity.HasIndex(e => new { e.NpnOrderId, e.NpnProductId })
                    .HasName("IX_NpnOrderId_NPNProductsId");

                entity.Property(e => e.IsRemoved).HasDefaultValueSql("0");

                entity.Property(e => e.PartialTax).HasColumnType("smallmoney");

                entity.Property(e => e.Price)
                    .HasColumnType("smallmoney")
                    .HasComputedColumnSql("[Quantity]*[UnitPrice]")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Total).HasColumnType("smallmoney");

                entity.Property(e => e.UnitDiscount).HasColumnType("smallmoney");

                entity.Property(e => e.UnitPrice).HasColumnType("smallmoney");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.NpnOrderProduct)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NpnOrderProduct_NpnOrder");

                entity.HasOne(d => d.NpnProduct)
                    .WithMany(p => p.NpnOrderProduct)
                    .HasForeignKey(d => d.NpnProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NpnOrderProduct_NPNProducts");
            });

            modelBuilder.Entity<NpnProduct>(entity =>
            {
                entity.ToTable("NpnProduct", "dbo");

                entity.Property(e => e.NpnProductId).ValueGeneratedNever();

                entity.Property(e => e.AltProductPrice)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.ProductAbbr).HasColumnType("varchar(6)");

                entity.Property(e => e.ProductDesc)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ProductPrice).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<NystatewideCounty>(entity =>
            {
                entity.HasKey(e => e.County)
                    .HasName("PK_NYStatewideCounty");

                entity.ToTable("NYStatewideCounty", "dbo");

                entity.Property(e => e.County).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<OrderBatchDetail>(entity =>
            {
                entity.ToTable("OrderBatchDetail", "dbo");

                entity.Property(e => e.AddressLn1).HasMaxLength(100);

                entity.Property(e => e.AddressLn2).HasMaxLength(100);

                entity.Property(e => e.AliasNames).HasMaxLength(250);

                entity.Property(e => e.ApiCandidateId).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.Country).HasMaxLength(3);

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(80);

                entity.Property(e => e.Extra1).HasMaxLength(50);

                entity.Property(e => e.Extra2).HasMaxLength(50);

                entity.Property(e => e.Extra3).HasMaxLength(50);

                entity.Property(e => e.Mvrlicense)
                    .HasColumnName("MVRLicense")
                    .HasMaxLength(32);

                entity.Property(e => e.Mvrstate)
                    .HasColumnName("MVRState")
                    .HasColumnType("char(2)");

                entity.Property(e => e.NameFirst).HasMaxLength(30);

                entity.Property(e => e.NameLast).HasMaxLength(40);

                entity.Property(e => e.NameMiddle).HasMaxLength(30);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(9);

                entity.Property(e => e.State).HasMaxLength(20);

                entity.Property(e => e.ZipCode).HasMaxLength(10);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.OrderBatchDetail)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_OrderBatchDetail_Client");

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.OrderBatchDetail)
                    .HasForeignKey(d => d.ClientUserId)
                    .HasConstraintName("FK_OrderBatchDetail_ClientUser");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderBatchDetail)
                    .HasForeignKey(d => d.NpnOrderId)
                    .HasConstraintName("FK_OrderBatchDetail_NpnOrder");

                entity.HasOne(d => d.OrderBatchFile)
                    .WithMany(p => p.OrderBatchDetail)
                    .HasForeignKey(d => d.OrderBatchFileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderBatchDetail_OrderBatchFile");

                entity.HasOne(d => d.PositionListing)
                    .WithMany(p => p.OrderBatchDetail)
                    .HasForeignKey(d => d.PositionListingId)
                    .HasConstraintName("FK_OrderBatchDetail_PositionListing");
            });

            modelBuilder.Entity<OrderBatchFile>(entity =>
            {
                entity.ToTable("OrderBatchFile", "dbo");

                entity.Property(e => e.BatchFile).IsRequired();

                entity.Property(e => e.DateProcessingEnd).HasColumnType("datetime");

                entity.Property(e => e.DateProcessingStart).HasColumnType("datetime");

                entity.Property(e => e.DateStandardConsent).HasColumnType("datetime");

                entity.Property(e => e.DateSummaryOfRightsConsent).HasColumnType("datetime");

                entity.Property(e => e.DateUpload).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastRowProcessed).HasDefaultValueSql("0");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.OrderBatchFile)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_OrderBatchFile_Client");

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.OrderBatchFile)
                    .HasForeignKey(d => d.ClientUserId)
                    .HasConstraintName("FK_OrderBatchFile_ClientUser");

                entity.HasOne(d => d.PositionListing)
                    .WithMany(p => p.OrderBatchFile)
                    .HasForeignKey(d => d.PositionListingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderBatchFile_PositionListing");
            });

            modelBuilder.Entity<OrderConsent>(entity =>
            {
                entity.ToTable("OrderConsent", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_OrderConsent_NpnOrderId");

                entity.Property(e => e.DateOfConsent).HasColumnType("datetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.OrderConsent)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__OrderCons__Candi__18633BFB");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.OrderConsent)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__OrderCons__Clien__167AF389");

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.OrderConsent)
                    .HasForeignKey(d => d.ClientUserId)
                    .HasConstraintName("FK__OrderCons__Clien__176F17C2");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderConsent)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__OrderCons__NpnOr__19576034");
            });

            modelBuilder.Entity<OrderCrimCase>(entity =>
            {
                entity.ToTable("OrderCrimCase", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_OrderCrimCase_NpnOrderId");

                entity.Property(e => e.County).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(50)");

                entity.Property(e => e.LastName).HasColumnType("varchar(50)");

                entity.Property(e => e.MiddleName).HasColumnType("varchar(50)");

                entity.Property(e => e.SourceId)
                    .HasColumnName("SourceID")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.State).HasColumnType("varchar(2)");

                entity.Property(e => e.Suffix).HasColumnType("varchar(5)");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderCrimCase)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CriminalCase_NpnOrder");
            });

            modelBuilder.Entity<OrderCrimCharge>(entity =>
            {
                entity.HasKey(e => new { e.OrderCrimCaseId, e.OrderCrimChargeId })
                    .HasName("PK_CriminalCharge");

                entity.ToTable("OrderCrimCharge", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_OrderCrimCharge_NpnOrderId");

                entity.Property(e => e.OrderCrimChargeId).ValueGeneratedOnAdd();

                entity.Property(e => e.CaseNumber).HasColumnType("varchar(150)");

                entity.Property(e => e.CaseType).HasColumnType("varchar(550)");

                entity.Property(e => e.Charge).HasColumnType("varchar(550)");

                entity.Property(e => e.ChargeType).HasColumnType("varchar(550)");

                entity.Property(e => e.CourtName).HasColumnType("varchar(550)");

                entity.Property(e => e.Disposition).HasColumnType("varchar(700)");

                entity.Property(e => e.OffenseCounty).HasColumnType("varchar(100)");

                entity.Property(e => e.StatuteNumber).HasColumnType("varchar(150)");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderCrimCharge)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CriminalCharge_NpnOrder");

                entity.HasOne(d => d.OrderCrimCase)
                    .WithMany(p => p.OrderCrimCharge)
                    .HasForeignKey(d => d.OrderCrimCaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CriminalCharge_CriminalCase");
            });

            modelBuilder.Entity<OrderFormStore>(entity =>
            {
                entity.ToTable("OrderFormStore", "dbo");

                entity.HasIndex(e => new { e.NpnOrderId, e.FormId })
                    .HasName("UIX_OrderFormStore_OrderId_FormId")
                    .IsUnique();

                entity.HasIndex(e => new { e.NpnOrderId, e.FormTypeId })
                    .HasName("UIX_OrderFormStore_OrderId_FormTypeId")
                    .IsUnique();

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.OrderFormStore)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderFormStore_FormStore");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderFormStore)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderFormStore_NpnOrder");
            });

            modelBuilder.Entity<OrderQuestionnaire>(entity =>
            {
                entity.ToTable("OrderQuestionnaire", "dbo");

                entity.Property(e => e.QuestionnaireInstructions)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.QuestionnaireName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.QuestionnaireTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.OrderQuestionnaire)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK_OrderQuestionnaire_Candidate");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.OrderQuestionnaire)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_OrderQuestionnaire_Client");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderQuestionnaire)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderQuestionnaire_NpnOrder");
            });

            modelBuilder.Entity<OrderReference>(entity =>
            {
                entity.ToTable("OrderReference", "dbo");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK_PersonalProfessionalReferences_Candidate");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_PersonalProfessionalReferences_NpnOrder");

                entity.Property(e => e.Email).HasMaxLength(80);

                entity.Property(e => e.KnownAsFirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.KnownAsLastName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.KnownAsMiddleName).HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReferenceName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Relationship).HasColumnType("varchar(20)");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.OrderReference)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PersonalProfessionalReferences_Candidate");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderReference)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PersonalProfessionalReferences_NpnOrder");
            });

            modelBuilder.Entity<OrderReportView>(entity =>
            {
                entity.ToTable("OrderReportView", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_OrderReportView_NpnOrder");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderReportView)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderReportView_NpnOrder");
            });

            modelBuilder.Entity<OrderSearch>(entity =>
            {
                entity.ToTable("OrderSearch", "dbo");

                entity.HasIndex(e => e.AliasId)
                    .HasName("IX_FK_OrderSearch_Alias");

                entity.HasIndex(e => e.JurisOrderId)
                    .HasName("IX_FK_OrderSearch_JurisOrder");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_OrderSearch_NpnOrder");

                entity.HasIndex(e => e.NpnOrderProductId)
                    .HasName("IX_FK_OrderSearch_NpnOrderProduct");

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.HasOne(d => d.Alias)
                    .WithMany(p => p.OrderSearch)
                    .HasForeignKey(d => d.AliasId)
                    .HasConstraintName("FK_OrderSearch_Alias");

                entity.HasOne(d => d.JurisOrder)
                    .WithMany(p => p.OrderSearch)
                    .HasForeignKey(d => d.JurisOrderId)
                    .HasConstraintName("FK_OrderSearch_JurisOrder");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderSearch)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderSearch_NpnOrder");

                entity.HasOne(d => d.NpnOrderProduct)
                    .WithMany(p => p.OrderSearch)
                    .HasForeignKey(d => d.NpnOrderProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderSearch_NpnOrderProduct");

                entity.HasOne(d => d.NpnProduct)
                    .WithMany(p => p.OrderSearch)
                    .HasForeignKey(d => d.NpnProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderSearch_NPNProducts");

                entity.HasOne(d => d.OrderReference)
                    .WithMany(p => p.OrderSearch)
                    .HasForeignKey(d => d.OrderReferenceId)
                    .HasConstraintName("FK_OrderSearch_OrderReferenceId");
            });

            modelBuilder.Entity<OrderSharing>(entity =>
            {
                entity.ToTable("OrderSharing", "dbo");

                entity.HasIndex(e => e.BadgeId)
                    .HasName("IX_FK_OrderSharing_BadgeId");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK_OrderSharing_Candidate");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_OrderSharing_Client");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_OrderSharing_NpnOrder");

                entity.HasIndex(e => new { e.ClientId, e.CalculatedScore, e.Type, e.IsHidden, e.EligibleStatusId })
                    .HasName("IX_OrderSharing_ClientIdEligibleStatusId");

                entity.Property(e => e.AdjudicationDate).HasColumnType("datetime");

                entity.Property(e => e.ApiStatusId).HasDefaultValueSql("0");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EligibleDate).HasColumnType("datetime");

                entity.Property(e => e.EligibleStatusId).HasDefaultValueSql("0");

                entity.Property(e => e.IsHidden).HasDefaultValueSql("0");

                entity.HasOne(d => d.Badge)
                    .WithMany(p => p.OrderSharing)
                    .HasForeignKey(d => d.BadgeId)
                    .HasConstraintName("FK_OrderSharing_BadgeId");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.OrderSharing)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderSharing_Candidate");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.OrderSharing)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderSharing_Client");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderSharing)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderSharing_NpnOrder");
            });

            modelBuilder.Entity<OrderSharingExternal>(entity =>
            {
                entity.ToTable("OrderSharingExternal", "dbo");

                entity.Property(e => e.CandidateComment).HasMaxLength(1000);

                entity.Property(e => e.CcAddress).HasMaxLength(100);

                entity.Property(e => e.EmailFailDate).HasColumnType("datetime");

                entity.Property(e => e.EmailSent).HasDefaultValueSql("0");

                entity.Property(e => e.EmailSentDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShareConsentDate).HasColumnType("datetime");

                entity.Property(e => e.ToAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.OrderSharingExternal)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderSharingExternal_Candidate");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderSharingExternal)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderSharingExternal_NpnOrder");
            });

            modelBuilder.Entity<OrderUpdate>(entity =>
            {
                entity.ToTable("OrderUpdate", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_OrderUpdate_NPNOrderId");

                entity.Property(e => e.AbsolveOrderTypeId).HasDefaultValueSql("0");

                entity.Property(e => e.DateAbsolveComplete).HasColumnType("datetime");

                entity.Property(e => e.DateAbsolveSubmit).HasColumnType("datetime");

                entity.Property(e => e.DateMips)
                    .HasColumnName("DateMIPS")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.OrderUpdate)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderUpdate_NPNOrderId");
            });

            modelBuilder.Entity<OrderUpdateSearch>(entity =>
            {
                entity.ToTable("OrderUpdateSearch", "dbo");

                entity.HasIndex(e => e.JurisUpdateId)
                    .HasName("IX_FK_OrderUpdateSearch_JurisUpdate");

                entity.HasIndex(e => e.NpnOrderProductId)
                    .HasName("IX_FK_OrderUpdateSearch_NpnOrderProduct");

                entity.HasIndex(e => e.OrderUpdateId)
                    .HasName("IX_FK_OrderUpdateSearch_OrderUpdate");

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.HasOne(d => d.JurisUpdate)
                    .WithMany(p => p.OrderUpdateSearch)
                    .HasForeignKey(d => d.JurisUpdateId)
                    .HasConstraintName("FK_OrderUpdateSearch_JurisUpdate");

                entity.HasOne(d => d.NpnOrderProduct)
                    .WithMany(p => p.OrderUpdateSearch)
                    .HasForeignKey(d => d.NpnOrderProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderUpdateSearch_NpnOrderProduct");

                entity.HasOne(d => d.OrderUpdate)
                    .WithMany(p => p.OrderUpdateSearch)
                    .HasForeignKey(d => d.OrderUpdateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderUpdateSearch_OrderUpdate");
            });

            modelBuilder.Entity<PageView>(entity =>
            {
                entity.ToTable("PageView", "dbo");

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ViewDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<PanelGroup>(entity =>
            {
                entity.ToTable("PanelGroup", "dbo");

                entity.HasIndex(e => new { e.SectionId, e.Ordinal })
                    .HasName("uc_SectionOrdinal")
                    .IsUnique();

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Response)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.ToTable("Partner", "dbo");

                entity.Property(e => e.PartnerName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Paths>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__Paths__CD67DC581A14E395");

                entity.ToTable("Paths", "dbo");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("IX_FK__Paths__Applicati__267ABA7A");

                entity.Property(e => e.PathId).HasDefaultValueSql("newid()");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Paths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__Paths__Applicati__267ABA7A");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment", "dbo");

                entity.Property(e => e.Added)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Amount).HasColumnType("smallmoney");

                entity.Property(e => e.AppCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ApprovalCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Avsmatch)
                    .HasColumnName("AVSMatch")
                    .HasMaxLength(20);

                entity.Property(e => e.CardBrandSelected)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Ccnum)
                    .IsRequired()
                    .HasColumnName("CCNum")
                    .HasMaxLength(20);

                entity.Property(e => e.Cctype)
                    .IsRequired()
                    .HasColumnName("CCType")
                    .HasMaxLength(25);

                entity.Property(e => e.CustomerEmail).HasMaxLength(150);

                entity.Property(e => e.CustomerId).HasMaxLength(50);

                entity.Property(e => e.Cvvmatch)
                    .IsRequired()
                    .HasColumnName("CVVMatch")
                    .HasMaxLength(20);

                entity.Property(e => e.ExpMonth)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ExpYear)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.HostedSecureId)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RawInput)
                    .HasColumnName("rawInput")
                    .HasColumnType("xml");

                entity.Property(e => e.Rurl)
                    .IsRequired()
                    .HasColumnName("RUrl")
                    .HasMaxLength(150);

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SolomonBillingId)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'Unknown'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.TransId)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.TransactionEnd)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TransactionStart)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<PdfDetail>(entity =>
            {
                entity.ToTable("PdfDetail", "dbo");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateProcessingEnd).HasColumnType("datetime");

                entity.Property(e => e.DateProcessingStart).HasColumnType("datetime");

                entity.HasOne(d => d.PdfHeader)
                    .WithMany(p => p.PdfDetail)
                    .HasForeignKey(d => d.PdfHeaderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PdfDetail_PdfHeader");
            });

            modelBuilder.Entity<PdfHeader>(entity =>
            {
                entity.ToTable("PdfHeader", "dbo");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateProcessingEnd).HasColumnType("datetime");

                entity.Property(e => e.DateProcessingExpire).HasColumnType("datetime");

                entity.Property(e => e.DateProcessingStart).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.PdfHeader)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PdfHeader_Client");

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.PdfHeader)
                    .HasForeignKey(d => d.ClientUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PdfHeader_ClientUser");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("Position", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_Position_Client");

                entity.Property(e => e.MinRenewalMonths).HasDefaultValueSql("10");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RegulatedJuris).HasDefaultValueSql("0");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Position)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Position_Client");
            });

            modelBuilder.Entity<PositionListing>(entity =>
            {
                entity.ToTable("PositionListing", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_PositionListing_Client");

                entity.HasIndex(e => e.PositionId)
                    .HasName("IX_FK_PositionListing_Position");

                entity.HasIndex(e => e.PromoCode)
                    .HasName("UX_PromoCode")
                    .IsUnique();

                entity.Property(e => e.HideOnClientOrder).HasDefaultValueSql("0");

                entity.Property(e => e.HideOnInvite).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ProductFeeRate).HasColumnType("decimal");

                entity.Property(e => e.PromoCode)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.SourceFeeRate).HasColumnType("decimal");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.PositionListing)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PositionListing_Client");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.PositionListing)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PositionListing_Position");
            });

            modelBuilder.Entity<PositionNpnProduct>(entity =>
            {
                entity.HasKey(e => e.PositionProductId)
                    .HasName("PK_PositionNpnProduct");

                entity.ToTable("PositionNpnProduct", "dbo");

                entity.HasIndex(e => e.NpnProductId)
                    .HasName("IX_FK_PositionNpnProduct_NpnProduct");

                entity.HasIndex(e => e.PositionId)
                    .HasName("IX_FK_PositionNpnProduct_Position");

                entity.HasIndex(e => new { e.PositionId, e.NpnProductId })
                    .HasName("UK_PositionNpnProduct_PositionProduct")
                    .IsUnique();

                entity.Property(e => e.StateCode).HasColumnType("char(2)");

                entity.HasOne(d => d.NpnProduct)
                    .WithMany(p => p.PositionNpnProduct)
                    .HasForeignKey(d => d.NpnProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PositionNpnProduct_NpnProduct");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.PositionNpnProduct)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PositionNpnProduct_Position");
            });

            modelBuilder.Entity<ProductAudit>(entity =>
            {
                entity.ToTable("ProductAudit", "dbo");

                entity.HasOne(d => d.NpnProduct)
                    .WithMany(p => p.ProductAudit)
                    .HasForeignKey(d => d.NpnProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__ProductAu__NpnPr__519197B6");
            });

            modelBuilder.Entity<ProductAuthorization>(entity =>
            {
                entity.ToTable("ProductAuthorization", "dbo");

                entity.HasIndex(e => e.NpnProductId)
                    .HasName("IX_FK_ProductAuthorization_NpnProduct");

                entity.HasIndex(e => e.StateCode)
                    .HasName("IX_FK_ProductAuthorization_State");

                entity.Property(e => e.StateCode).HasColumnType("char(2)");

                entity.HasOne(d => d.NpnProduct)
                    .WithMany(p => p.ProductAuthorization)
                    .HasForeignKey(d => d.NpnProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductAuthorization_NpnProduct");

                entity.HasOne(d => d.StateCodeNavigation)
                    .WithMany(p => p.ProductAuthorization)
                    .HasForeignKey(d => d.StateCode)
                    .HasConstraintName("FK_ProductAuthorization_State");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question", "dbo");

                entity.HasIndex(e => new { e.QuestionnaireId, e.Ordinal })
                    .HasName("UN_Questionnaire_Ordinal")
                    .IsUnique();

                entity.Property(e => e.QuestionText).IsRequired();

                entity.HasOne(d => d.Questionnaire)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.QuestionnaireId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Question_Questionnaire");
            });

            modelBuilder.Entity<QuestionAnswer>(entity =>
            {
                entity.ToTable("QuestionAnswer", "dbo");

                entity.Property(e => e.AnswerText).IsRequired();

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionAnswer)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_QuestionAnswer_Question");
            });

            modelBuilder.Entity<Questionnaire>(entity =>
            {
                entity.ToTable("Questionnaire", "dbo");

                entity.Property(e => e.QuestionnaireInstructions)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.QuestionnaireName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.QuestionnaireTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Questionnaire)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Questionnaire_Client");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__Roles__8AFACE1A1FCDBCEB");

                entity.ToTable("Roles", "dbo");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("IX_RoleApplication");

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("RoleApplication");
            });

            modelBuilder.Entity<SecurityQuestions>(entity =>
            {
                entity.HasKey(e => e.SecurityQuestionId)
                    .HasName("PK_SecurityQuestions");

                entity.ToTable("SecurityQuestions", "dbo");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<SeedData>(entity =>
            {
                entity.HasKey(e => e.SeedDataId)
                    .HasName("PK__SeedData__0C7C13F318AD54BE");

                entity.ToTable("SeedData", "dbo");

                entity.Property(e => e.Address).HasMaxLength(60);

                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Facebook).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Mvrlicense).HasColumnName("MVRLicense");

                entity.Property(e => e.Ssn).HasColumnName("SSN");

                entity.Property(e => e.State).HasColumnType("varchar(50)");

                entity.Property(e => e.Twitter).HasMaxLength(255);

                entity.Property(e => e.Zip).HasMaxLength(10);
            });

            modelBuilder.Entity<SharingSubscription>(entity =>
            {
                entity.ToTable("SharingSubscription", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("UQ_SharingSubscription_NpnOrderId")
                    .IsUnique();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.PartialTax).HasColumnType("smallmoney");

                entity.Property(e => e.Price)
                    .HasColumnType("smallmoney")
                    .HasComputedColumnSql("[Quantity]*[UnitPrice]")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Total).HasColumnType("smallmoney");

                entity.Property(e => e.UnitDiscount).HasColumnType("smallmoney");

                entity.Property(e => e.UnitPrice).HasColumnType("smallmoney");

                entity.HasOne(d => d.NpnOrder)
                    .WithOne(p => p.SharingSubscriptionNavigation)
                    .HasForeignKey<SharingSubscription>(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_SharingSubscription_NpnOrder");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.SharingSubscription)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("fk_SharingSubscription_Payment");
            });

            modelBuilder.Entity<SitecoreIntegrationLog>(entity =>
            {
                entity.ToTable("SitecoreIntegrationLog", "dbo");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateRequest).HasColumnType("datetime");

                entity.Property(e => e.Result).HasColumnType("ntext");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skill", "dbo");

                entity.HasIndex(e => new { e.SkillName, e.SkillCategory })
                    .HasName("uc_SkillName_SkillCategory")
                    .IsUnique();

                entity.Property(e => e.SkillCategory)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SolomonBillingInfo>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_SolomonBillingInfo");

                entity.ToTable("SolomonBillingInfo", "dbo");

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.ProductName).HasColumnType("nchar(30)");

                entity.Property(e => e.SterlingAccountGlcode)
                    .IsRequired()
                    .HasColumnName("SterlingAccountGLCode")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.SterlingAccountGldescription)
                    .IsRequired()
                    .HasColumnName("SterlingAccountGLDescription")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.SterlingInventoryCode)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<SortOrder>(entity =>
            {
                entity.ToTable("SortOrder", "dbo");

                entity.Property(e => e.SortOrderName).HasMaxLength(64);
            });

            modelBuilder.Entity<SourceType>(entity =>
            {
                entity.ToTable("SourceType", "dbo");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<SsnTraceArchive>(entity =>
            {
                entity.ToTable("SsnTraceArchive", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_SsnTraceArchive_NpnOrder");

                entity.Property(e => e.SsnTraceData)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.SsnTraceArchive)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SsnTraceArchive_NpnOrder");
            });

            modelBuilder.Entity<SsnTraceRecordArchive>(entity =>
            {
                entity.ToTable("SsnTraceRecordArchive", "dbo");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_FK_SsnTraceRecordArchive_NpnOrder");

                entity.Property(e => e.Address).HasColumnType("varchar(100)");

                entity.Property(e => e.City).HasColumnType("varchar(50)");

                entity.Property(e => e.DateOfBirth).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(50)");

                entity.Property(e => e.IssueDates).HasColumnType("varchar(50)");

                entity.Property(e => e.IssueState).HasColumnType("varchar(50)");

                entity.Property(e => e.LastName).HasColumnType("varchar(50)");

                entity.Property(e => e.MiddleName).HasColumnType("varchar(50)");

                entity.Property(e => e.State).HasColumnType("varchar(50)");

                entity.Property(e => e.Zip).HasColumnType("varchar(10)");

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.SsnTraceRecordArchive)
                    .HasForeignKey(d => d.NpnOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SsnTraceRecordArchive_NpnOrder");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("Staff", "dbo");

                entity.HasIndex(e => e.EmulateUserId)
                    .HasName("IX_FK_Emulate_Users");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_Staff_Users");

                entity.Property(e => e.DateEntered).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneExt)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.HasOne(d => d.EmulateUser)
                    .WithMany(p => p.StaffEmulateUser)
                    .HasForeignKey(d => d.EmulateUserId)
                    .HasConstraintName("FK_Emulate_Users");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StaffUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Staff_Users");
            });

            modelBuilder.Entity<StateAbuseCode>(entity =>
            {
                entity.ToTable("StateAbuseCode", "dbo");

                entity.HasIndex(e => e.Code)
                    .HasName("IX_StateAbuseCode")
                    .IsUnique();

                entity.HasIndex(e => e.DateAssigned)
                    .HasName("IX_StateAbuseCode_DateAssigned");

                entity.HasIndex(e => e.NpnOrderId)
                    .HasName("IX_StateAbuseCode_NpnOrderId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.VersionStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.NpnOrder)
                    .WithMany(p => p.StateAbuseCode)
                    .HasForeignKey(d => d.NpnOrderId)
                    .HasConstraintName("FK_StateAbuseCode_NpnOrder");
            });

            modelBuilder.Entity<StateSourceFee>(entity =>
            {
                entity.HasKey(e => e.State)
                    .HasName("PK_StateSourceFee");

                entity.ToTable("StateSourceFee", "dbo");

                entity.Property(e => e.State).HasColumnType("varchar(10)");

                entity.Property(e => e.SourceFee).HasColumnType("smallmoney");

                entity.Property(e => e.StateName).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.HasKey(e => e.StateCode)
                    .HasName("PK__States__D515E98B1EA48E88");

                entity.ToTable("States", "dbo");

                entity.Property(e => e.StateCode).HasColumnType("char(2)");

                entity.Property(e => e.IsBatchUploadState).HasDefaultValueSql("0");

                entity.Property(e => e.MvrRegex).HasMaxLength(100);

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Uicolumn>(entity =>
            {
                entity.ToTable("UIColumn", "dbo");

                entity.Property(e => e.UicolumnId).HasColumnName("UIColumnId");

                entity.Property(e => e.UicolumnName)
                    .HasColumnName("UIColumnName")
                    .HasMaxLength(64);

                entity.Property(e => e.UicolumnText)
                    .HasColumnName("UIColumnText")
                    .HasMaxLength(64);

                entity.Property(e => e.UitableId).HasColumnName("UITableId");

                entity.HasOne(d => d.Uitable)
                    .WithMany(p => p.Uicolumn)
                    .HasForeignKey(d => d.UitableId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UIColumn_UITable");
            });

            modelBuilder.Entity<Uitable>(entity =>
            {
                entity.ToTable("UITable", "dbo");

                entity.Property(e => e.UitableId).HasColumnName("UITableId");

                entity.Property(e => e.UitableName)
                    .HasColumnName("UITableName")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<UserAudit>(entity =>
            {
                entity.ToTable("UserAudit", "dbo");

                entity.HasIndex(e => e.UserName)
                    .HasName("IX_FK_UserAudit_Users");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.NewValue1).HasMaxLength(100);

                entity.Property(e => e.NewValue2).HasMaxLength(100);

                entity.Property(e => e.NewValue3).HasMaxLength(100);

                entity.Property(e => e.OldValue1).HasMaxLength(100);

                entity.Property(e => e.OldValue2).HasMaxLength(100);

                entity.Property(e => e.OldValue3).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.UserAudit)
                    .HasPrincipalKey(p => p.UserName)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserAudit_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4C47E69B3D");

                entity.ToTable("Users", "dbo");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("IX_UserApplication");

                entity.HasIndex(e => e.UserName)
                    .HasName("IX_Users_UserName_Unique")
                    .IsUnique();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("UserApplication");
            });

            modelBuilder.Entity<UsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__UsersInR__AF2760AD4BB72C21");

                entity.ToTable("UsersInRoles", "dbo");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_UsersInRoleRole");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("UsersInRoleRole");
            });

            modelBuilder.Entity<VolunteerPool>(entity =>
            {
                entity.ToTable("VolunteerPool", "dbo");

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_FK_VolunteerPool_CandidateId");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_VolunteerPool_ClientId");

                entity.HasIndex(e => e.InvitationId)
                    .HasName("IX_FK_VolunteerPool_InvitationId");

                entity.HasIndex(e => e.OrderSharingId)
                    .HasName("IX_FK_VolunteerPool_OrderSharingId");

                entity.HasIndex(e => e.StateCode)
                    .HasName("IX_FK_VolunteerPool_StateCode");

                entity.Property(e => e.Address).HasMaxLength(60);

                entity.Property(e => e.Address2).HasMaxLength(60);

                entity.Property(e => e.ApicandidateId)
                    .HasColumnName("APICandidateId")
                    .HasMaxLength(50);

                entity.Property(e => e.BgcheckStatus).HasColumnName("BGCheckStatus");

                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Extra1).HasMaxLength(50);

                entity.Property(e => e.Extra2).HasMaxLength(50);

                entity.Property(e => e.Extra3).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastScreen).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Level).HasMaxLength(200);

                entity.Property(e => e.NextRenewal).HasColumnType("datetime");

                entity.Property(e => e.OriginalBgcheckDate)
                    .HasColumnName("OriginalBGCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PromoCode).HasMaxLength(32);

                entity.Property(e => e.StateCode).HasColumnType("char(2)");

                entity.Property(e => e.VolunteerSince).HasColumnType("date");

                entity.Property(e => e.ZipCode).HasMaxLength(10);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.VolunteerPool)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK_VolunteerPool_CandidateId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.VolunteerPool)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VolunteerPool_ClientId");

                entity.HasOne(d => d.ClientUser)
                    .WithMany(p => p.VolunteerPool)
                    .HasForeignKey(d => d.ClientUserId)
                    .HasConstraintName("FK__Volunteer__Creat__69D3359B");

                entity.HasOne(d => d.Invitation)
                    .WithMany(p => p.VolunteerPool)
                    .HasForeignKey(d => d.InvitationId)
                    .HasConstraintName("FK_VolunteerPool_InvitationId");

                entity.HasOne(d => d.OrderSharing)
                    .WithMany(p => p.VolunteerPool)
                    .HasForeignKey(d => d.OrderSharingId)
                    .HasConstraintName("FK_VolunteerPool_OrderSharingId");

                entity.HasOne(d => d.StateCodeNavigation)
                    .WithMany(p => p.VolunteerPool)
                    .HasForeignKey(d => d.StateCode)
                    .HasConstraintName("FK_VolunteerPool_StateCode");
            });

            modelBuilder.Entity<VolunteerPoolCalc>(entity =>
            {
                entity.HasKey(e => e.VolunteerPoolId)
                    .HasName("PK__Voluntee__77C052C264AF5922");

                entity.ToTable("VolunteerPoolCalc", "dbo");

                entity.HasIndex(e => e.ClientId)
                    .HasName("ix_VolunteerPoolCalc_ClientID");

                entity.HasIndex(e => new { e.ClientId, e.RootClientId })
                    .HasName("VolunteerPoolCalc_ClientId");

                entity.HasIndex(e => new { e.ClientId, e.StatusId })
                    .HasName("VolunteerPoolCalc_Status");

                entity.HasIndex(e => new { e.ClientId, e.LastName, e.FirstName })
                    .HasName("VolunteerPoolCalc_Name");

                entity.Property(e => e.VolunteerPoolId).ValueGeneratedNever();

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.ApicandidateId)
                    .HasColumnName("APICandidateId")
                    .HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.ClientRatingRestrictionEndDate).HasColumnType("datetime");

                entity.Property(e => e.ClientRatingRestrictionNote).HasMaxLength(500);

                entity.Property(e => e.CreateType).HasMaxLength(150);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Extra1).HasMaxLength(50);

                entity.Property(e => e.Extra2).HasMaxLength(50);

                entity.Property(e => e.Extra3).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.HasBgprocessing).HasColumnName("HasBGProcessing");

                entity.Property(e => e.InvitationDate).HasColumnType("date");

                entity.Property(e => e.LastAdjudicationDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastScreen).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("date");

                entity.Property(e => e.LastUpdateDisplay).HasMaxLength(30);

                entity.Property(e => e.Level).HasMaxLength(200);

                entity.Property(e => e.MyStory).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Position).HasMaxLength(500);

                entity.Property(e => e.StateCode).HasColumnType("char(2)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VolunteerSince).HasColumnType("date");

                entity.Property(e => e.ZipCode).HasMaxLength(10);

                entity.HasOne(d => d.ClientRatingRestriction)
                    .WithMany(p => p.VolunteerPoolCalc)
                    .HasForeignKey(d => d.ClientRatingRestrictionId)
                    .HasConstraintName("FK_VolunteerPoolCalc_ClientRatingRestriction");
            });

            modelBuilder.Entity<VolunteerPoolClientRatingRestriction>(entity =>
            {
                entity.ToTable("VolunteerPoolClientRatingRestriction", "dbo");

                entity.HasIndex(e => e.VolunteerPoolId)
                    .HasName("IX_VolunteerPoolClientRatingRestriction_VolunteerPoolId");

                entity.HasIndex(e => new { e.VolunteerPoolId, e.RemovedDate })
                    .HasName("UQ_VolunteerPoolClientRatingRestriction_VolunteerPoolId_DateRemoved")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.RemovedDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AddedByClientUser)
                    .WithMany(p => p.VolunteerPoolClientRatingRestrictionAddedByClientUser)
                    .HasForeignKey(d => d.AddedByClientUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VolunteerPoolClientRatingRestriction_ClientUserAdded");

                entity.HasOne(d => d.ClientRatingRestriction)
                    .WithMany(p => p.VolunteerPoolClientRatingRestriction)
                    .HasForeignKey(d => d.ClientRatingRestrictionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VolunteerPoolClientRatingRestriction_ClientRatingRestriction");

                entity.HasOne(d => d.RemovedByClientUser)
                    .WithMany(p => p.VolunteerPoolClientRatingRestrictionRemovedByClientUser)
                    .HasForeignKey(d => d.RemovedByClientUserId)
                    .HasConstraintName("FK_VolunteerPoolClientRatingRestriction_ClientUserRemoved");

                entity.HasOne(d => d.VolunteerPool)
                    .WithMany(p => p.VolunteerPoolClientRatingRestriction)
                    .HasForeignKey(d => d.VolunteerPoolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VolunteerPoolClientRatingRestriction_VolunteerPool");
            });

            modelBuilder.Entity<VolunteerPoolClientView>(entity =>
            {
                entity.ToTable("VolunteerPoolClientView", "dbo");

                entity.HasIndex(e => e.VolunteerPoolId)
                    .HasName("IX_VolunteerPoolClientView_VolunteerPoolId");

                entity.HasIndex(e => new { e.CandidateId, e.ClientId })
                    .HasName("IX_VolunteerPoolClientView_CandidateIdClientId");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.VolunteerPoolClientView)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK_VolunteerPoolClientView_Candidate");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.VolunteerPoolClientView)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VolunteerPoolClientView_Client");

                entity.HasOne(d => d.ClientView)
                    .WithMany(p => p.VolunteerPoolClientView)
                    .HasForeignKey(d => d.ClientViewId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VolunteerPoolClientView_ClientView");

                entity.HasOne(d => d.VolunteerPool)
                    .WithMany(p => p.VolunteerPoolClientView)
                    .HasForeignKey(d => d.VolunteerPoolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VolunteerPoolClientView_VolunteerPool");
            });

            modelBuilder.Entity<VolunteerPoolHistory>(entity =>
            {
                entity.ToTable("VolunteerPoolHistory", "dbo");

                entity.Property(e => e.AttachmentNames).HasColumnType("varchar(2000)");

                entity.Property(e => e.ClientUserName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.VolunteerPoolHistory)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Volunteer__Candi__7FF780E4");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.VolunteerPoolHistory)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__Volunteer__Clien__00EBA51D");

                entity.HasOne(d => d.VolunteerPool)
                    .WithMany(p => p.VolunteerPoolHistory)
                    .HasForeignKey(d => d.VolunteerPoolId)
                    .HasConstraintName("FK__Volunteer__Volun__7F035CAB");
            });

            modelBuilder.Entity<VolunteerPoolPosition>(entity =>
            {
                entity.ToTable("VolunteerPoolPosition", "dbo");

                entity.HasIndex(e => e.PositionId)
                    .HasName("IX_FK_VolunteerPoolPosition_PositionId");

                entity.HasIndex(e => e.VolunteerPoolId)
                    .HasName("IX_FK_VolunteerPoolPosition_VolunteerPoolId");

                entity.HasIndex(e => new { e.VolunteerPoolId, e.PositionId })
                    .HasName("U_VolunteerPoolPosition")
                    .IsUnique();

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.VolunteerPoolPosition)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VolunteerPoolPosition_PositionId");

                entity.HasOne(d => d.VolunteerPool)
                    .WithMany(p => p.VolunteerPoolPosition)
                    .HasForeignKey(d => d.VolunteerPoolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VolunteerPoolPosition_VolunteerPoolId");
            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.HasKey(e => e.ZipCode1)
                    .HasName("PK_ZipCode");

                entity.ToTable("ZipCode", "dbo");

                entity.Property(e => e.ZipCode1)
                    .HasColumnName("ZipCode")
                    .HasMaxLength(10);

                entity.Property(e => e.Latitude).HasColumnType("decimal");

                entity.Property(e => e.Longitude).HasColumnType("decimal");

                entity.Property(e => e.StateCode).HasMaxLength(2);
            });
        }
    }
}
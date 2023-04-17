using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using App.SoftPOS.MTIs;
using Volo.Abp.EntityFrameworkCore.Modeling;
using App.SoftPOS.DownloadParameters;
using App.SoftPOS.ISOMsgs;
using App.SoftPOS.PosTerminals;
using App.SoftPOS.Categories;
using App.SoftPOS.RetailerDatas;
using App.SoftPOS.CardSchemas;
using App.SoftPOS.MessageTexts;
using App.SoftPOS.TerminalConnections;
using App.SoftPOS.DeviceSpecifics;
using App.SoftPOS.AIDLists;
using App.SoftPOS.AIDDatas;
using App.SoftPOS.RevokeCertificates;
using App.SoftPOS.PublicKeys;

namespace App.SoftPOS.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class SoftPOSDbContext :
    AbpDbContext<SoftPOSDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    // MTI Management
    public DbSet<MTI> MTIs { get; set; }
    public DbSet<DownloadParameter> DownloadParameters { get; set; }
    public DbSet<ISOMsg> ISOMsgs { get; set; }

    //Segments
    public DbSet<PosTerminal> PosTerminals { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<RD_Seg01> RD_Seg01s { get; set; }
    public DbSet<RD_Seg02> RD_Seg02s { get; set; }
    public DbSet<RD_Seg03> RD_Seg03s { get; set; }
    public DbSet<RD_Seg04> RD_Seg04s { get; set; }
    public DbSet<CS_Seg01> CS_Seg01s { get; set; }
    public DbSet<CS_Seg02> CS_Seg02s { get; set; }
    public DbSet<CS_Seg03> CS_Seg03s { get; set; }
    public DbSet<MT_Seg01> MT_Seg01s { get; set; }
    public DbSet<PK_Seg01> PK_Seg01s { get; set; }
    public DbSet<TC_Seg01> TC_Seg01s { get; set; }
    public DbSet<DS_Seg01> DS_Seg01s { get; set; }
    public DbSet<AL_Seg01> AL_Seg01s { get; set; }
    public DbSet<AD_Seg01> AD_Seg01s { get; set; }
    public DbSet<RC_Seg01> RC_Seg01s { get; set; }
    #endregion

    public SoftPOSDbContext(DbContextOptions<SoftPOSDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        builder.Entity<MTI>(b =>
        {
           b.ToTable(SoftPOSConsts.DbTablePrefix + "MTIs", SoftPOSConsts.DbSchema);
           b.ConfigureByConvention(); //auto configure for the base class props
           b.Property(x => x.MTI_Code_Req).IsRequired();
        });

        builder.Entity<DownloadParameter>(b =>
        {
           b.ToTable(SoftPOSConsts.DbTablePrefix + "DownloadParameters", SoftPOSConsts.DbSchema);
           b.ConfigureByConvention(); //auto configure for the base class props
           b.Property(x => x.RecordNumber).IsRequired().HasMaxLength(9);
        });

        builder.Entity<ISOMsg>(b =>
        {
           b.ToTable(SoftPOSConsts.DbTablePrefix + "ISOMsg", SoftPOSConsts.DbSchema);
           b.ConfigureByConvention(); //auto configure for the base class props
           b.Property(x => x.BufferMsg).IsRequired();
        });
        // segments DB
        builder.Entity<PosTerminal>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "PosTerminal", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Terminal_ID).IsRequired();
        });

        builder.Entity<Category>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "Category", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Category_ID).IsRequired();
            b.HasOne<PosTerminal>().WithMany().HasForeignKey(x => x.Terminal_ID);
        });
        // --- Retailer Data ---
        builder.Entity<RD_Seg01>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "RD_Seg01", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        builder.Entity<RD_Seg02>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "RD_Seg02", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        builder.Entity<RD_Seg03>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "RD_Seg03", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        builder.Entity<RD_Seg04>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "RD_Seg04", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        // --- Card Scheme ---
        builder.Entity<CS_Seg01>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "CS_Seg01", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        builder.Entity<CS_Seg02>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "CS_Seg02", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        builder.Entity<CS_Seg03>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "CS_Seg03", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        // --- Message Text ---
        builder.Entity<MT_Seg01>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "MT_Seg01", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        // --- Public Key ---
        builder.Entity<PK_Seg01>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "PK_Seg01", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        // --- Terminal Connection ---
        builder.Entity<TC_Seg01>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "TC_Seg01", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        // --- Device Specific ---
        builder.Entity<DS_Seg01>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "DS_Seg01", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        // --- AID List ---
        builder.Entity<AL_Seg01>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "AL_Seg01", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        // --- AID Data --
        builder.Entity<AD_Seg01>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "AD_Seg01", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });
        // --- Revoke Certificates --- 
        builder.Entity<RC_Seg01>(b =>
        {
            b.ToTable(SoftPOSConsts.DbTablePrefix + "RC_Seg01", SoftPOSConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Segment_ID).IsRequired();
            b.HasOne<Category>().WithMany().HasForeignKey(x => x.Category_ID);
        });

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(SoftPOSConsts.DbTablePrefix + "YourEntities", SoftPOSConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
    }
}

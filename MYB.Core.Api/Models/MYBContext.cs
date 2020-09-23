using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MYB.Core.Api.DTO;

namespace MYB.Core.Api.Models
{
    public partial class MYBContext : DbContext
    {
        public MYBContext()
        {
        }

        public MYBContext(DbContextOptions<MYBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Attribute> Attribute { get; set; }
        public virtual DbSet<AttributeData> AttributeData { get; set; }
        public virtual DbSet<AttributeGroup> AttributeGroup { get; set; }
        public virtual DbSet<AttributeType> AttributeType { get; set; }
        public virtual DbSet<Committee> Committee { get; set; }
        public virtual DbSet<Constituency> Constituency { get; set; }
        public virtual DbSet<ConstituencyCouncil> ConstituencyCouncil { get; set; }
        public virtual DbSet<ConstituencyType> ConstituencyType { get; set; }
        public virtual DbSet<ContactMedium> ContactMedium { get; set; }
        public virtual DbSet<ContactNumber> ContactNumber { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Function> Function { get; set; }
        public virtual DbSet<FunctionGroup> FunctionGroup { get; set; }
        public virtual DbSet<FunctionStatus> FunctionStatus { get; set; }
        public virtual DbSet<FunctionTypeStatusCode> FunctionTypeStatusCode { get; set; }
        public virtual DbSet<LookUp> LookUp { get; set; }
        public virtual DbSet<Organisation> Organisation { get; set; }
        public virtual DbSet<OrganisationFunction> OrganisationFunction { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Title> Title { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=172.24.16.154;Database=MYB;Trusted_Connection=false;User ID=myb_web;Password=YX8Iq1BfInhVU5R");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.OrganisationId)
                    .HasName("IX_Address");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Address4)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryPoint)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MybentityId).HasColumnName("MYBEntityID");

                entity.Property(e => e.MybtableId).HasColumnName("MYBTableID");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Pcl)
                    .HasColumnName("PCL")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Pcr)
                    .HasColumnName("PCR")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Town)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Web)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Web2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.OrganisationId)
                    .HasConstraintName("FK_Address_Organisation");
            });

            modelBuilder.Entity<Attribute>(entity =>
            {
                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Attribute1)
                    .HasColumnName("Attribute")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeSubGroupId).HasColumnName("AttributeSubGroupID");

                entity.Property(e => e.AttributeTypeId).HasColumnName("AttributeTypeID");

                entity.Property(e => e.DataTypeCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LookUpId).HasColumnName("LookUpID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OrganisationTypeId).HasColumnName("OrganisationTypeID");

                entity.Property(e => e.OuidtypeId).HasColumnName("OUIDTypeID");

                entity.Property(e => e.Relationship)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.ReverseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RollOver).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Unit)
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttributeData>(entity =>
            {
                entity.HasIndex(e => e.AttributeDataId)
                    .HasName("IX_AttributeData_5");

                entity.HasIndex(e => e.AttributeId)
                    .HasName("IX_AttributeData_1");

                entity.HasIndex(e => e.DataYear)
                    .HasName("IX_AttributeData_3");

                entity.HasIndex(e => e.Entity)
                    .HasName("IX_AttributeData");

                entity.HasIndex(e => e.EntityId)
                    .HasName("IX_AttributeData_2");

                entity.HasIndex(e => e.IsCurrent)
                    .HasName("IX_AttributeData_7");

                entity.HasIndex(e => e.Year)
                    .HasName("IX_AttributeData_6");

                entity.Property(e => e.AttributeDataId).HasColumnName("AttributeDataID");

                entity.Property(e => e.AttributeAbbreviation)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeData1)
                    .HasColumnName("AttributeData")
                    .HasMaxLength(5500)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.EditorialContactId).HasColumnName("EditorialContactID");

                entity.Property(e => e.Entity).HasDefaultValueSql("((1))");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.IsCurrent)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdated).HasColumnType("smalldatetime");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Profile)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.AttributeData)
                    .HasForeignKey(d => d.AttributeId)
                    .HasConstraintName("FK_AttributeData_Attribute");

                entity.HasOne(d => d.EntityNavigation)
                    .WithMany(p => p.AttributeData)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttributeData_Organisation");
            });

            modelBuilder.Entity<AttributeGroup>(entity =>
            {
                entity.HasIndex(e => e.DisplayOrder)
                    .HasName("IX_AttributeGroup");

                entity.HasIndex(e => e.OrganisationTypeId)
                    .HasName("IX_AttributeGroup_1");

                entity.Property(e => e.AttributeGroupId).HasColumnName("AttributeGroupID");

                entity.Property(e => e.AttributeGroup1)
                    .HasColumnName("AttributeGroup")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OrganisationTypeId).HasColumnName("OrganisationTypeID");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<AttributeType>(entity =>
            {
                entity.Property(e => e.AttributeTypeId).HasColumnName("AttributeTypeID");

                entity.Property(e => e.AttributeType1)
                    .HasColumnName("AttributeType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<Committee>(entity =>
            {
                entity.HasKey(e => e.Committee1);

                entity.Property(e => e.Committee1)
                    .HasColumnName("Committee")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");
            });

            modelBuilder.Entity<Constituency>(entity =>
            {
                entity.Property(e => e.ConstituencyId).HasColumnName("ConstituencyID");

                entity.Property(e => e.Constituency1)
                    .HasColumnName("Constituency")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ConstituencyTypeCode)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<ConstituencyCouncil>(entity =>
            {
                entity.HasKey(e => new { e.ConstituencyId, e.CouncilId });

                entity.Property(e => e.ConstituencyId).HasColumnName("ConstituencyID");

                entity.Property(e => e.CouncilId).HasColumnName("CouncilID");

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<ConstituencyType>(entity =>
            {
                entity.HasKey(e => e.ConstituencyTypeCode);

                entity.Property(e => e.ConstituencyTypeCode)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<ContactMedium>(entity =>
            {
                entity.Property(e => e.ContactMediumId).HasColumnName("ContactMediumID");

                entity.Property(e => e.ContactMedium1)
                    .HasColumnName("ContactMedium")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<ContactNumber>(entity =>
            {
                entity.HasIndex(e => e.EntityId)
                    .HasName("IX_ContactNumber");

                entity.HasIndex(e => e.EntityTypeId)
                    .HasName("IX_ContactNumber_1");

                entity.HasIndex(e => e.IsMain)
                    .HasName("IX_ContactNumber_2");

                entity.HasIndex(e => e.OrganisationId)
                    .HasName("IX_ContactNumber_3");

                entity.Property(e => e.ContactNumberId).HasColumnName("ContactNumberID");

                entity.Property(e => e.ContactMediumId).HasColumnName("ContactMediumID");

                entity.Property(e => e.ContactNumber1)
                    .HasColumnName("ContactNumber")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.EntityTypeId).HasColumnName("EntityTypeID");

                entity.Property(e => e.Label)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("index_690101499")
                    .IsUnique();

                entity.Property(e => e.Country1)
                    .HasColumnName("Country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<Function>(entity =>
            {
                entity.HasIndex(e => e.FunctionTypeId)
                    .HasName("IX_Function");

                entity.HasIndex(e => e.OrganisationTypeId)
                    .HasName("IX_Function_1");

                entity.HasIndex(e => e.PublishingSequence)
                    .HasName("IX_Function_2");

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.DirectorateId).HasColumnName("directorateID");

                entity.Property(e => e.Function1)
                    .HasColumnName("Function")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionTypeId).HasColumnName("FunctionTypeID");

                entity.Property(e => e.MailingName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OrganisationTypeId).HasColumnName("OrganisationTypeID");

                entity.Property(e => e.PublishingName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<FunctionGroup>(entity =>
            {
                entity.Property(e => e.FunctionGroupId).HasColumnName("FunctionGroupID");

                entity.Property(e => e.FunctionGroup1)
                    .HasColumnName("FunctionGroup")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<FunctionStatus>(entity =>
            {
                entity.HasKey(e => e.FunctionStatusCode);

                entity.Property(e => e.FunctionStatusCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionStatus1)
                    .HasColumnName("FunctionStatus")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<FunctionTypeStatusCode>(entity =>
            {
                entity.HasKey(e => new { e.FunctionTypeId, e.FunctionStatusCode });

                entity.Property(e => e.FunctionTypeId).HasColumnName("FunctionTypeID");

                entity.Property(e => e.FunctionStatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<LookUp>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.HasIndex(e => e.LookUpId)
                    .HasName("IX_LookUp");

                entity.HasIndex(e => e.ParentUid)
                    .HasName("IX_LookUp_1");

                entity.HasIndex(e => e.PubSeq)
                    .HasName("IX_LookUp_2");

                entity.HasIndex(e => e.Uid)
                    .HasName("IX_LookUp_3");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.DataDescription)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DataValue)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.LookUpId).HasColumnName("LookUpID");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ParentUid).HasColumnName("ParentUID");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<Organisation>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .HasName("IX_Organisation_3");

                entity.HasIndex(e => e.AdministrativeRegion)
                    .HasName("IX_Organisation_2");

                entity.HasIndex(e => e.OrganisationId)
                    .HasName("IX_Organisation_4");

                entity.HasIndex(e => e.OrganisationTypeId)
                    .HasName("IX_Organisation");

                entity.HasIndex(e => e.PublishingSequence)
                    .HasName("IX_Organisation_1");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AdministrativeRegion)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.EditorialContactId).HasColumnName("EditorialContactID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Foiemail)
                    .HasColumnName("FOIEmail")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.LocalName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MybentityId).HasColumnName("MYBEntityID");

                entity.Property(e => e.MybtableId).HasColumnName("MYBTableID");

                entity.Property(e => e.NextElection).HasColumnType("smalldatetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Organisation1)
                    .HasColumnName("Organisation")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OrganisationTypeId).HasColumnName("OrganisationTypeID");

                entity.Property(e => e.PublishedName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrganisationFunction>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .HasName("IX_OrganisationFunction_3");

                entity.HasIndex(e => e.ConstituencyId)
                    .HasName("IX_OrganisationFunction_4");

                entity.HasIndex(e => e.EditorialContactId)
                    .HasName("IX_OrganisationFunction_5");

                entity.HasIndex(e => e.FunctionStatusCode)
                    .HasName("IX_OrganisationFunction_6");

                entity.HasIndex(e => e.OrganisationId)
                    .HasName("IX_OrganisationFunction");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IX_OrganisationFunction_1");

                entity.HasIndex(e => e.PublishingSequence)
                    .HasName("IX_OrganisationFunction_2");

                entity.Property(e => e.OrganisationFunctionId).HasColumnName("OrganisationFunctionID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.ConstituencyId).HasColumnName("ConstituencyID");

                entity.Property(e => e.ContactMedium)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EditorialContactId).HasColumnName("EditorialContactID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionStatusCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated).HasColumnType("smalldatetime");

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Note)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionFilled).HasColumnType("datetime");

                entity.Property(e => e.Profile)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .HasName("IX_Person");

                entity.HasIndex(e => e.Gender)
                    .HasName("IX_Person_3");

                entity.HasIndex(e => e.MybentityId)
                    .HasName("IX_Person_1");

                entity.HasIndex(e => e.MybtableId)
                    .HasName("IX_Person_2");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.AdditionalResponsibility)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.DeliveryPoint)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Forename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Initial)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion)
                    .HasColumnName("msrepl_tran_version")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MybentityId).HasColumnName("MYBEntityID");

                entity.Property(e => e.MybtableId).HasColumnName("MYBTableID");

                entity.Property(e => e.NoEmail).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoTpemail)
                    .HasColumnName("NoTPEmail")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Note)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToBurst).HasDefaultValueSql("((0))");

                entity.Property(e => e.Web)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Web2)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.HasKey(e => e.PTitleId)
                    .HasName("PK_title");

                entity.Property(e => e.PTitleId).HasColumnName("p_title_id");

                entity.Property(e => e.DateAmended)
                    .HasColumnName("date_amended")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateArchived)
                    .HasColumnName("date_archived")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeletedFlag).HasColumnName("deleted_flag");

                entity.Property(e => e.FAmendedBy).HasColumnName("f_amended_by");

                entity.Property(e => e.FTitleId).HasColumnName("f_title_id");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");

                entity.Property(e => e.OldTitleId).HasColumnName("old_title_id");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.TitleDescription)
                    .IsRequired()
                    .HasColumnName("title_description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleOrder)
                    .HasColumnName("title_order")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<MYB.Core.Api.DTO.CouncilDTO> CouncilDTO { get; set; }

        public DbSet<MYB.Core.Api.DTO.CouncilEntryDTO> CouncilEntryDTO { get; set; }

        public DbSet<MYB.Core.Api.DTO.PersonDTO> PersonDTO { get; set; }

        public DbSet<MYB.Core.Api.DTO.CouncillorEntryDTO> CouncillorDTO { get; set; }
    }
}

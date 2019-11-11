﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATMR.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SOSTechATMREntities : DbContext
    {
        public SOSTechATMREntities()
            : base("name=SOSTechATMREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AppLog> AppLogs { get; set; }
        public virtual DbSet<AppMessageAttachment> AppMessageAttachments { get; set; }
        public virtual DbSet<AppMessage> AppMessages { get; set; }
        public virtual DbSet<AppModuleSMTP> AppModuleSMTPs { get; set; }
        public virtual DbSet<AppNotification> AppNotifications { get; set; }
        public virtual DbSet<AppRole> AppRoles { get; set; }
        public virtual DbSet<AppSecurityQuestion> AppSecurityQuestions { get; set; }
        public virtual DbSet<AppSettingNotification> AppSettingNotifications { get; set; }
        public virtual DbSet<AppSMTP> AppSMTPs { get; set; }
        public virtual DbSet<AppUserPermission> AppUserPermissions { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<BenefitType> BenefitTypes { get; set; }
        public virtual DbSet<BonusType> BonusTypes { get; set; }
        public virtual DbSet<CertificateSetting> CertificateSettings { get; set; }
        public virtual DbSet<Certification> Certifications { get; set; }
        public virtual DbSet<CrmContactCompany> CrmContactCompanies { get; set; }
        public virtual DbSet<CrmContact> CrmContacts { get; set; }
        public virtual DbSet<CrmContactType> CrmContactTypes { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<ExtraFieldSection> ExtraFieldSections { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<TaxType> TaxTypes { get; set; }
        public virtual DbSet<UserSecurity> UserSecurities { get; set; }
        public virtual DbSet<AppModule> AppModules { get; set; }
        public virtual DbSet<AppSetting> AppSettings { get; set; }
        public virtual DbSet<AppUserExtra> AppUserExtras { get; set; }
        public virtual DbSet<CrmContactAddress> CrmContactAddresses { get; set; }
        public virtual DbSet<CrmContactEmail> CrmContactEmails { get; set; }
        public virtual DbSet<CrmContactPhone> CrmContactPhones { get; set; }
    }
}

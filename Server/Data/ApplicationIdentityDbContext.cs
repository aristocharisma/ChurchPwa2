using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChurchPwa2.Shared.DwellModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChurchPwa2.Server.Data
{
    public class ApplicationIdentityDbContext : IdentityDbContext 
    {
        public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options) : base(options)
        {
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public virtual DbSet<AccessType> AccessTypes { get; set; }
        public virtual DbSet<ConfigurationValueClass> ConfigurationValues { get; set; }
        public virtual DbSet<Elder> Elders { get; set; }
        public virtual DbSet<Family> Families { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupSecurity> GroupSecurities { get; set; }
        public virtual DbSet<GroupUser> GroupUsers { get; set; }
        public virtual DbSet<Grouping> Groupings { get; set; }
        public virtual DbSet<GroupingAttachment> GroupingAttachments { get; set; }
        public virtual DbSet<GroupingRole> GroupingRoles { get; set; }
        public virtual DbSet<LoginHistory> LoginHistories { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageAttachment> MessageAttachments { get; set; }
        public virtual DbSet<MessageCreditsUsed> MessageCreditsUseds { get; set; }
        public virtual DbSet<MessageQueueItem> MessageQueueItems { get; set; }
        public virtual DbSet<MessageType> MessageTypes { get; set; }
        public virtual DbSet<Organisation> Organisations { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonGrouping> PersonGroupings { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SecurityItem> SecurityItems { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Suburb> Suburbs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserOrganisation> UserOrganisations { get; set; }
        public virtual DbSet<ViewElder> ViewElders { get; set; }
        public virtual DbSet<ViewFamily> ViewFamilies { get; set; }
        public virtual DbSet<ViewFamilyMemberCount> ViewFamilyMemberCounts { get; set; }
        public virtual DbSet<ViewFamilyNamesUnique> ViewFamilyNamesUniques { get; set; }
        public virtual DbSet<ViewGrouping> ViewGroupings { get; set; }
        public virtual DbSet<ViewKidsReport> ViewKidsReports { get; set; }
        public virtual DbSet<ViewMessage> ViewMessages { get; set; }
        public virtual DbSet<ViewMessageQueueItem> ViewMessageQueueItems { get; set; }
        public virtual DbSet<ViewPerson> ViewPersons { get; set; }
        public virtual DbSet<ViewPersonGrouping> ViewPersonGroupings { get; set; }
        public virtual DbSet<ViewPersonGroupsList> ViewPersonGroupsLists { get; set; }
        public virtual DbSet<ViewPersonNameUnique> ViewPersonNameUniques { get; set; }
        public virtual DbSet<ViewPricing> ViewPricings { get; set; }
        public virtual DbSet<ViewSmssendHistory> ViewSmssendHistories { get; set; }
        public virtual DbSet<ViewSpouse> ViewSpouses { get; set; }
        public virtual DbSet<ViewUser> ViewUsers { get; set; }
        public virtual DbSet<ViewUserGroupSecurity> ViewUserGroupSecurities { get; set; }
        public virtual DbSet<ViewUserGroupSecurityItem> ViewUserGroupSecurityItems { get; set; }
        public virtual DbSet<ViewUserGroupUser> ViewUserGroupUsers { get; set; }
        public virtual DbSet<ViewUserMenuItem> ViewUserMenuItems { get; set; }
        public virtual DbSet<ViewUserSecurityItem> ViewUserSecurityItems { get; set; }
    }
}
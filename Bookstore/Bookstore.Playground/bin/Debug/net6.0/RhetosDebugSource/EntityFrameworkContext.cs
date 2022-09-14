﻿// <autogenerated />
namespace Common
{
    #pragma warning disable // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;
    using Autofac;
    /*CommonUsing*/

    public class EntityFrameworkContext : System.Data.Entity.DbContext
    {
        private readonly Rhetos.Utilities.RhetosAppOptions _rhetosAppOptions;

        public EntityFrameworkContext(
            Rhetos.Persistence.IPersistenceTransaction persistenceTransaction,
            Rhetos.Dom.DefaultConcepts.Persistence.EntityFrameworkMetadata metadata,
            System.Data.Entity.DbConfiguration entityFrameworkConfiguration, // EntityFrameworkConfiguration is provided as an IoC dependency for EntityFrameworkContext in order to initialize the global DbConfiguration before using DbContext.
            Rhetos.Utilities.RhetosAppOptions rhetosAppOptions)
            : base(new System.Data.Entity.Core.EntityClient.EntityConnection(metadata.MetadataWorkspace, persistenceTransaction.Connection), false)
        {
            _rhetosAppOptions = rhetosAppOptions;
            Initialize();
            Database.UseTransaction(persistenceTransaction.Transaction);
        }

        private void Initialize()
        {
            System.Data.Entity.Database.SetInitializer<EntityFrameworkContext>(null); // Prevent EF from creating database objects.

            this.Configuration.UseDatabaseNullSemantics = _rhetosAppOptions.EntityFrameworkUseDatabaseNullSemantics;
            /*EntityFrameworkContextInitialize*/

            this.Database.CommandTimeout = Rhetos.Utilities.SqlUtility.SqlCommandTimeout;
        }

        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_Book> Bookstore_Book { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_BookInfo> Bookstore_BookInfo { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_BookTopic> Bookstore_BookTopic { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_ChildrensBook> Bookstore_ChildrensBook { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_Comment> Bookstore_Comment { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_Department> Bookstore_Department { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_EducationRecord> Bookstore_EducationRecord { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_Employee> Bookstore_Employee { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_EmployeeDepartments> Bookstore_EmployeeDepartments { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_ForeignBook> Bookstore_ForeignBook { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_Manager> Bookstore_Manager { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_NumberOfTopicsCalculation> Bookstore_NumberOfTopicsCalculation { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_Person> Bookstore_Person { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_Review> Bookstore_Review { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_TestDeactivatable> Bookstore_TestDeactivatable { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_Topic> Bookstore_Topic { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_AutoCodeCache> Common_AutoCodeCache { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Claim> Common_Claim { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_ExclusiveLock> Common_ExclusiveLock { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_FilterId> Common_FilterId { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_KeepSynchronizedMetadata> Common_KeepSynchronizedMetadata { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Log> Common_Log { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_LogReader> Common_LogReader { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_LogRelatedItem> Common_LogRelatedItem { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_LogRelatedItemReader> Common_LogRelatedItemReader { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Principal> Common_Principal { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_PrincipalHasRole> Common_PrincipalHasRole { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_PrincipalPermission> Common_PrincipalPermission { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_RelatedEventsSource> Common_RelatedEventsSource { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Role> Common_Role { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_RoleInheritsRole> Common_RoleInheritsRole { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_RolePermission> Common_RolePermission { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.ConceptsDemo_TestEntity> ConceptsDemo_TestEntity { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.HardcodedExample_Genre> HardcodedExample_Genre { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Queries_BookInfoThroughExternalFile> Queries_BookInfoThroughExternalFile { get; set; }
        /*EntityFrameworkContextMembers*/
    }

    public class EntityFrameworkConfiguration : System.Data.Entity.DbConfiguration
    {
        public EntityFrameworkConfiguration()
        {
            SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);

            AddInterceptor(new Rhetos.Dom.DefaultConcepts.ContainsIdsInterceptor());
            AddInterceptor(new Rhetos.Dom.DefaultConcepts.Persistence.FullTextSearchInterceptor());
            /*EntityFrameworkConfiguration*/

            System.Data.Entity.DbConfiguration.SetConfiguration(this);
        }
    }

    #pragma warning restore // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.
}

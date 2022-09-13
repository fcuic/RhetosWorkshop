﻿// <autogenerated />
namespace System.Linq
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

    public static class QueryExtensions
    {
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.Book> ToSimple(this IQueryable<Common.Queryable.Bookstore_Book> query)
        {
            return query.Select(item => new Bookstore.Book
            {
                ID = item.ID,
                Changed = item.Changed,
                Code = item.Code,
                Inserted = item.Inserted,
                NumberOfPages = item.NumberOfPages,
                Title = item.Title,
                AuthorID = item.AuthorID/*DataStructureInfo AssignSimpleProperty Bookstore.Book*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.BookInfo> ToSimple(this IQueryable<Common.Queryable.Bookstore_BookInfo> query)
        {
            return query.Select(item => new Bookstore.BookInfo
            {
                ID = item.ID,
                NumberOfComments = item.NumberOfComments/*DataStructureInfo AssignSimpleProperty Bookstore.BookInfo*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.BookTopic> ToSimple(this IQueryable<Common.Queryable.Bookstore_BookTopic> query)
        {
            return query.Select(item => new Bookstore.BookTopic
            {
                ID = item.ID,
                BookID = item.BookID,
                TopicID = item.TopicID/*DataStructureInfo AssignSimpleProperty Bookstore.BookTopic*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.ChildrensBook> ToSimple(this IQueryable<Common.Queryable.Bookstore_ChildrensBook> query)
        {
            return query.Select(item => new Bookstore.ChildrensBook
            {
                ID = item.ID,
                AgeFrom = item.AgeFrom,
                AgeTo = item.AgeTo/*DataStructureInfo AssignSimpleProperty Bookstore.ChildrensBook*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.Comment> ToSimple(this IQueryable<Common.Queryable.Bookstore_Comment> query)
        {
            return query.Select(item => new Bookstore.Comment
            {
                ID = item.ID,
                BookID = item.BookID,
                Text = item.Text/*DataStructureInfo AssignSimpleProperty Bookstore.Comment*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.Department> ToSimple(this IQueryable<Common.Queryable.Bookstore_Department> query)
        {
            return query.Select(item => new Bookstore.Department
            {
                ID = item.ID,
                Code = item.Code,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Bookstore.Department*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.EducationRecord> ToSimple(this IQueryable<Common.Queryable.Bookstore_EducationRecord> query)
        {
            return query.Select(item => new Bookstore.EducationRecord
            {
                ID = item.ID,
                Date = item.Date,
                Description = item.Description,
                EmployeeID = item.EmployeeID/*DataStructureInfo AssignSimpleProperty Bookstore.EducationRecord*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.Employee> ToSimple(this IQueryable<Common.Queryable.Bookstore_Employee> query)
        {
            return query.Select(item => new Bookstore.Employee
            {
                ID = item.ID,
                Name = item.Name,
                VatNumber = item.VatNumber/*DataStructureInfo AssignSimpleProperty Bookstore.Employee*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.EmployeeDepartments> ToSimple(this IQueryable<Common.Queryable.Bookstore_EmployeeDepartments> query)
        {
            return query.Select(item => new Bookstore.EmployeeDepartments
            {
                ID = item.ID,
                DepartmentID = item.DepartmentID,
                EmployeeID = item.EmployeeID/*DataStructureInfo AssignSimpleProperty Bookstore.EmployeeDepartments*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.ExpectedBookRating> ToSimple(this IQueryable<Common.Queryable.Bookstore_ExpectedBookRating> query)
        {
            return query.Select(item => new Bookstore.ExpectedBookRating
            {
                ID = item.ID,
                Rating = item.Rating/*DataStructureInfo AssignSimpleProperty Bookstore.ExpectedBookRating*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.ExternalCustomer> ToSimple(this IQueryable<Common.Queryable.Bookstore_ExternalCustomer> query)
        {
            return query.Select(item => new Bookstore.ExternalCustomer
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.ExternalCustomer*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.ForeignBook> ToSimple(this IQueryable<Common.Queryable.Bookstore_ForeignBook> query)
        {
            return query.Select(item => new Bookstore.ForeignBook
            {
                ID = item.ID,
                OriginalLanguage = item.OriginalLanguage,
                TranslatorID = item.TranslatorID/*DataStructureInfo AssignSimpleProperty Bookstore.ForeignBook*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.Manager> ToSimple(this IQueryable<Common.Queryable.Bookstore_Manager> query)
        {
            return query.Select(item => new Bookstore.Manager
            {
                ID = item.ID,
                Benefits = item.Benefits,
                Bonuses = item.Bonuses/*DataStructureInfo AssignSimpleProperty Bookstore.Manager*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.NumberOfTopicsCalculation> ToSimple(this IQueryable<Common.Queryable.Bookstore_NumberOfTopicsCalculation> query)
        {
            return query.Select(item => new Bookstore.NumberOfTopicsCalculation
            {
                ID = item.ID,
                NumberOfTopics = item.NumberOfTopics/*DataStructureInfo AssignSimpleProperty Bookstore.NumberOfTopicsCalculation*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.Person> ToSimple(this IQueryable<Common.Queryable.Bookstore_Person> query)
        {
            return query.Select(item => new Bookstore.Person
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Person*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.TestDeactivatable> ToSimple(this IQueryable<Common.Queryable.Bookstore_TestDeactivatable> query)
        {
            return query.Select(item => new Bookstore.TestDeactivatable
            {
                ID = item.ID,
                Active = item.Active,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.TestDeactivatable*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.Topic> ToSimple(this IQueryable<Common.Queryable.Bookstore_Topic> query)
        {
            return query.Select(item => new Bookstore.Topic
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Topic*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.AutoCodeCache> ToSimple(this IQueryable<Common.Queryable.Common_AutoCodeCache> query)
        {
            return query.Select(item => new Common.AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Grouping = item.Grouping,
                LastCode = item.LastCode,
                MinDigits = item.MinDigits,
                Prefix = item.Prefix,
                Property = item.Property/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Claim> ToSimple(this IQueryable<Common.Queryable.Common_Claim> query)
        {
            return query.Select(item => new Common.Claim
            {
                ID = item.ID,
                Active = item.Active,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.ExclusiveLock> ToSimple(this IQueryable<Common.Queryable.Common_ExclusiveLock> query)
        {
            return query.Select(item => new Common.ExclusiveLock
            {
                ID = item.ID,
                LockFinish = item.LockFinish,
                LockStart = item.LockStart,
                ResourceID = item.ResourceID,
                ResourceType = item.ResourceType,
                UserName = item.UserName,
                Workstation = item.Workstation/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.FilterId> ToSimple(this IQueryable<Common.Queryable.Common_FilterId> query)
        {
            return query.Select(item => new Common.FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.KeepSynchronizedMetadata> ToSimple(this IQueryable<Common.Queryable.Common_KeepSynchronizedMetadata> query)
        {
            return query.Select(item => new Common.KeepSynchronizedMetadata
            {
                ID = item.ID,
                Context = item.Context,
                Source = item.Source,
                Target = item.Target/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Log> ToSimple(this IQueryable<Common.Queryable.Common_Log> query)
        {
            return query.Select(item => new Common.Log
            {
                ID = item.ID,
                Action = item.Action,
                ContextInfo = item.ContextInfo,
                Created = item.Created,
                Description = item.Description,
                ItemId = item.ItemId,
                TableName = item.TableName,
                UserName = item.UserName,
                Workstation = item.Workstation/*DataStructureInfo AssignSimpleProperty Common.Log*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogReader> ToSimple(this IQueryable<Common.Queryable.Common_LogReader> query)
        {
            return query.Select(item => new Common.LogReader
            {
                ID = item.ID,
                Action = item.Action,
                ContextInfo = item.ContextInfo,
                Created = item.Created,
                Description = item.Description,
                ItemId = item.ItemId,
                TableName = item.TableName,
                UserName = item.UserName,
                Workstation = item.Workstation/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItem> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItem> query)
        {
            return query.Select(item => new Common.LogRelatedItem
            {
                ID = item.ID,
                ItemId = item.ItemId,
                LogID = item.LogID,
                Relation = item.Relation,
                TableName = item.TableName/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItemReader> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItemReader> query)
        {
            return query.Select(item => new Common.LogRelatedItemReader
            {
                ID = item.ID,
                ItemId = item.ItemId,
                LogID = item.LogID,
                Relation = item.Relation,
                TableName = item.TableName/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Principal> ToSimple(this IQueryable<Common.Queryable.Common_Principal> query)
        {
            return query.Select(item => new Common.Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalHasRole> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalHasRole> query)
        {
            return query.Select(item => new Common.PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalPermission> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalPermission> query)
        {
            return query.Select(item => new Common.PrincipalPermission
            {
                ID = item.ID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized,
                PrincipalID = item.PrincipalID/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RelatedEventsSource> ToSimple(this IQueryable<Common.Queryable.Common_RelatedEventsSource> query)
        {
            return query.Select(item => new Common.RelatedEventsSource
            {
                ID = item.ID,
                Action = item.Action,
                ContextInfo = item.ContextInfo,
                Created = item.Created,
                Description = item.Description,
                ItemId = item.ItemId,
                LogID = item.LogID,
                RelatedToItem = item.RelatedToItem,
                RelatedToTable = item.RelatedToTable,
                Relation = item.Relation,
                TableName = item.TableName,
                UserName = item.UserName,
                Workstation = item.Workstation/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Role> ToSimple(this IQueryable<Common.Queryable.Common_Role> query)
        {
            return query.Select(item => new Common.Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RoleInheritsRole> ToSimple(this IQueryable<Common.Queryable.Common_RoleInheritsRole> query)
        {
            return query.Select(item => new Common.RoleInheritsRole
            {
                ID = item.ID,
                PermissionsFromID = item.PermissionsFromID,
                UsersFromID = item.UsersFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RolePermission> ToSimple(this IQueryable<Common.Queryable.Common_RolePermission> query)
        {
            return query.Select(item => new Common.RolePermission
            {
                ID = item.ID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HardcodedExample.Genre> ToSimple(this IQueryable<Common.Queryable.HardcodedExample_Genre> query)
        {
            return query.Select(item => new HardcodedExample.Genre
            {
                ID = item.ID,
                Description = item.Description,
                IsFiction = item.IsFiction,
                Label = item.Label,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty HardcodedExample.Genre*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Queries.BookInfoThroughExternalFile> ToSimple(this IQueryable<Common.Queryable.Queries_BookInfoThroughExternalFile> query)
        {
            return query.Select(item => new Queries.BookInfoThroughExternalFile
            {
                ID = item.ID,
                NumberOfComments = item.NumberOfComments/*DataStructureInfo AssignSimpleProperty Queries.BookInfoThroughExternalFile*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.BooksAuthorsAndTopicsGrid> ToSimple(this IQueryable<Common.Queryable.Bookstore_BooksAuthorsAndTopicsGrid> query)
        {
            return query.Select(item => new Bookstore.BooksAuthorsAndTopicsGrid
            {
                ID = item.ID,
                AuthorName = item.AuthorName,
                BookName = item.BookName,
                Extension_NumberOfTopicsCalculationNumberOfTopics = item.Extension_NumberOfTopicsCalculationNumberOfTopics/*DataStructureInfo AssignSimpleProperty Bookstore.BooksAuthorsAndTopicsGrid*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Queries.BookGrid> ToSimple(this IQueryable<Common.Queryable.Queries_BookGrid> query)
        {
            return query.Select(item => new Queries.BookGrid
            {
                ID = item.ID,
                AuthorName = item.AuthorName,
                Code = item.Code,
                NameOfTranslator = item.NameOfTranslator,
                NumberOfComments = item.NumberOfComments,
                Title = item.Title/*DataStructureInfo AssignSimpleProperty Queries.BookGrid*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.MyClaim> ToSimple(this IQueryable<Common.Queryable.Common_MyClaim> query)
        {
            return query.Select(item => new Common.MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            });
        }
        /*QueryExtensionsMembers*/

        /// <summary>
        /// A specific overload of the 'ToSimple' method cannot be targeted from a generic method using generic type.
        /// This method uses reflection instead to find the specific 'ToSimple' method.
        /// </summary>
        public static IQueryable<TEntity> GenericToSimple<TEntity>(this IQueryable<IEntity> i)
            where TEntity : class, IEntity
	    {
            var method = typeof(QueryExtensions).GetMethod("ToSimple", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public, null, new Type[] { i.GetType() }, null);
            if (method == null)
                throw new Rhetos.FrameworkException("Cannot find 'ToSimple' method for argument type '" + i.GetType().ToString() + "'.");
            return (IQueryable<TEntity>)Rhetos.Utilities.ExceptionsUtility.InvokeEx(method, null, new object[] { i });
        }

        /// <summary>Converts the objects to simple object and the IEnumerable to List or Array, if not already.</summary>
        public static void LoadSimpleObjects<TEntity>(ref IEnumerable<TEntity> items)
            where TEntity: class, IEntity
        {
            if (items is IQueryable<IQueryableEntity<TEntity>> query)
                items = query.GenericToSimple<TEntity>().ToList(); // The IQueryable function allows ORM optimizations.
            else if (items is IEnumerable<IQueryableEntity<TEntity>> navigationItems)
                items = navigationItems.Select(item => item.ToSimple()).ToList();
            else
            {
                Rhetos.Utilities.CsUtility.Materialize(ref items);
                var itemsList = (IList<TEntity>)items;
                for (int i = 0; i < itemsList.Count(); i++)
                {
                    var navigationItem = itemsList[i] as IQueryableEntity<TEntity>;
                    if (navigationItem != null)
                        itemsList[i] = navigationItem.ToSimple();
                }
            }
        }
    }

    #pragma warning restore // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.
}
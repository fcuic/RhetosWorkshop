using ConsoleDump;
using Rhetos;
using Rhetos.Dom.DefaultConcepts;
using Rhetos.Logging;
using Rhetos.Utilities;
using System.Data.Entity;

ConsoleLogger.MinLevel = EventType.Info; // Use EventType.Trace for more detailed log.
string rhetosHostAssemblyPath = @"C:\RhetosWorkshop\Bookstore\src\Bookstore.Service\bin\Debug\net6.0\Bookstore.Service.dll";
using (var scope = LinqPadRhetosHost.CreateScope(rhetosHostAssemblyPath))
{
    var context = scope.Resolve<Common.ExecutionContext>();
    context.UserInfo.UserName.Dump(); //Write the user
    var repository = context.Repository;

    // Query data from the `Common.Claim` table:

    //var claims = repository.Common.Claim.Query()
    //    .Where(c => c.ClaimResource.StartsWith("Common.") && c.ClaimRight == "New")
    //    .ToSimple(); // Removes ORM navigation properties from the loaded objects.

    //claims.ToString().Dump("Common.Claims SQL query");
    //claims.Dump("Common.Claims items");

    //// Add and remove a `Common.Principal`:

    //var testUser = new Common.Principal { Name = "Test123", ID = Guid.NewGuid() };
    //repository.Common.Principal.Insert(new[] { testUser });
    //repository.Common.Principal.Delete(new[] { testUser });

    // Print logged events for the `Common.Principal`:

    #region Day2Demo

    //repository.Common.LogReader.Query()
    //    .Where(log => log.TableName == "Common.Principal" && log.ItemId == testUser.ID)
    //    .ToList()
    //    .Dump("Common.Principal log");

    //var allBooks = repository.Bookstore.Book.Load();
    //allBooks.Dump();

    //var someBooks = repository.Bookstore.Book.Load(book => book.Title.StartsWith("The"));
    //someBooks.Dump();

    //var query = repository.Bookstore.Book.Query();

    //var query2 = query
    //    .Where(b => b.Title.StartsWith("H"))
    //    .Select(b => new { b.Title, b.Author.Name });

    //// Entity Framework overrides ToString to return the generated SQL query.
    //query.ToString().Dump("Generated SQL (query)");
    //query2.ToString().Dump("Generated SQL (query2)");

    //// ToList will force Entity Framework to load the data from the database.
    //var items = query2.ToList();
    //items.Dump();

    #endregion

    #region AssignmentDay2
    //var query3 = allBooks.Select(b => new { b.Title, b.AuthorID });

    //var query4 = repository.Bookstore.Book
    //    .Query()
    //    .Select(b => new { b.Title, b.AuthorID })
    //    .ToString()
    //    .Dump();

    //var actionParameter = new Bookstore.InsertBooks
    //{
    //    NumberOfBooks = 3,
    //    Title = "Vuco"
    //};

    //repository.Bookstore.InsertBooks.Execute(actionParameter);

    //scope.CommitAndClose(); //Necessary for Insert Action!

    #endregion

    #region Day3DemoAndAssignment

    //Item Filter

    //var filterBooks = new Bookstore.LongBooks();
    //var query = repository.Bookstore.Book.Query(filterBooks);
    //query.ToString().Dump();
    //query.ToSimple().ToList().Dump();

    ////ComposableFilterBy

    //var filterParameter = new Bookstore.ComposableFilter
    //{
    //    MinimumPages = 50,
    //    ForeignBooksOnly = false
    //};

    //var query2 = repository.Bookstore.Book.Query(filterParameter);
    //query2.ToString().Dump();
    //query2.ToSimple().ToList().Dump();

    ////Predefined Filter

    //var vucoFilter = new FilterCriteria("Title", "StartsWith", "Vuco");
    //repository.Bookstore.Book.Query(vucoFilter).Dump();

    //FilterBy

    var filterByParameter = new Bookstore.ComplexSearch
    {
        MinimumPages = 50,
        ForeignBooksOnly = true,
        MaskTitles = true
    };
    Bookstore.Book[] query3 = repository.Bookstore.Book.Load(filterByParameter).Dump();


    #endregion


    Console.WriteLine("Done.");
}

//scope.CommitAndClose(); // Database transaction is rolled back by default.
using Microsoft.AspNetCore.Mvc;
using Rhetos;
using Rhetos.Processing;
using Rhetos.Processing.DefaultCommands;

namespace Bookstore.Service.Controllers
{
    [Route("Demo/[action]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IProcessingEngine _processingEngine;
        private readonly IUnitOfWork _unitOfWork;
        private readonly Common.ExecutionContext _executionContext;

        public DemoController(IRhetosComponent<IProcessingEngine> processingEngine, IRhetosComponent<IUnitOfWork> unitOfWork, IRhetosComponent<Common.ExecutionContext> executionContext)
        {
            _processingEngine = processingEngine.Value;
            _unitOfWork = unitOfWork.Value;
            _executionContext = executionContext.Value;
        }

        [HttpGet]
        public string ReadBooks() 
        {
            var readCommandInfo = new ReadCommandInfo { DataSource = "Bookstore.Book", ReadTotalCount = true };
            var result = _processingEngine.Execute(readCommandInfo);
            return $"{result.TotalCount} books.";
        }

        [HttpGet]
        public string WriteBook() 
        {
            var newBook = new Bookstore.Book { Title = "NewBook" };
            var saveCommandInfo = new SaveEntityCommandInfo { Entity = "Bookstore.Book", DataToInsert = new[] { newBook } };
            _processingEngine.Execute(saveCommandInfo);
            _unitOfWork.CommitAndClose();
            return "1 book inserted.";
        }

        //My testing of querying from the db (Not mandatory)
        [HttpGet]
        public List<string> GetChildrenBooksNames() 
        {
            var childrenBooks = _executionContext.Repository.Bookstore.ChildrensBook.Query()
                .Select(x => x.Base.Title).ToList();
            return childrenBooks;
        }

    }
}

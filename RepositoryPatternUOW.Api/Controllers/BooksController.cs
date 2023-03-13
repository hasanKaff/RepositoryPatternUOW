using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternUOW.Core;
using RepositoryPatternUOW.Core.Consts;
using RepositoryPatternUOW.Core.Models;
using RepositoryPatternUOW.Core.Repositories;

namespace RepositoryPatternUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetById()
        {
            return Ok(_unitOfWork.Books.GetById(1));
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync()
        {
            return Ok(await _unitOfWork.Books.GetByIdAsync(1));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_unitOfWork.Books.GetAll());
        }

        [HttpGet("GetByName")]
        public IActionResult GetByName()
        {
            return Ok(_unitOfWork.Books.Find(x => x.Title.ToLower().Contains("English".ToLower()), new[] { "Author" }));
        }

        [HttpGet("GetAllWithAuthors")]
        public IActionResult GetAllWithAuthors()
        {
            return Ok(_unitOfWork.Books.FindAll(x => x.Title.ToLower().Contains("Arabic".ToLower()), new[] { "Author" }));
        }

        [HttpGet("GetAllOrderedWithAuthors")]
        public IActionResult GetAllOrderedWithAuthors()
        {
            return Ok(_unitOfWork.Books.FindAll(x => x.Title.ToLower().Contains("Arabic".ToLower()), null, null, b => b.Id, OrderBy.Decending));
        }

        [HttpPost("AddOne")]
        public IActionResult AddOne()
        {
            var book = _unitOfWork.Books.Add(new Book { Title = "New Book", AuthorId = 2 });
            _unitOfWork.Complete();
            return Ok(book);
        }
    }
}

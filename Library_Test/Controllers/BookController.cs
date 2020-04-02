using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Library_Test.Entities;
using Library_Test.Interface;

namespace Library_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBook<Books> _book;
        private IErrorLogger _logger;
        public BookController(IBook<Books> book, IErrorLogger logger)
        {
            _book = book;
            _logger = logger;
        }

        [HttpGet, Route("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            try
            {
                IEnumerable<BookTest> books = _book.GetAllBooks();
                if (books != null)
                    return Ok(books);
                else
                    return NoContent();
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpPost, Route("CreateBookByAdmin")]
        public IActionResult CreateBookByAdmin([FromBody] List<BookTest> book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            { 
                string Token = String.Empty;
                try
                {
                    Token = Request.Headers["Admin"];
                    if (Token == "1")
                    {
                        _logger.WriteActivity(book.ToString());
                        foreach (var item in book)
                        {
                            var newBook = new Books()
                            {
                                BookId = Guid.NewGuid(),
                                Title = item.Title,
                                Isbn = item.Isbn,
                                PublishYear = item.PublishYear,
                                CoverPrice = item.CoverPrice,
                                AvailabilityStatus = "Check-In"
                            };
                        
                            _book.Add(newBook);
                        }
                       
                        return Ok(book);
                    }
                    else
                    {
                        _logger.WriteActivity("Not Authorised");
                        return Unauthorized();
                    }

                }
                catch (Exception ex)
                {
                    _logger.WriteLog(ex);
                    return BadRequest();
                }
            }

        }

        [HttpGet, Route("SearchForBooks")]
        public IActionResult SearchForBooks(string searchId)
        {
            try
            {
                _logger.WriteActivity(searchId.ToString());
                string search = searchId.Trim().ToString();
                IEnumerable<Books> books = _book.SearchForBooks(searchId);
                if (books != null)
                    return Ok(books);
                else
                    return NoContent();
            }
            catch (Exception ex)
            {

                _logger.WriteLog(ex);
                return BadRequest();
            }

        }
    }
}

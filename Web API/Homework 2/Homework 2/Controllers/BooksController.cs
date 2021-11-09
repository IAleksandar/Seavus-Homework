using Homework_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Book>> GetAllBooks() 
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, StaticDb.Books);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error has occured !");
            }
        }

        [HttpGet("id")]
        public ActionResult<Book> GetByIndex(int index)
        {
            try
            {
                if(index < 0)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Negative number");
                }
                if(index >= StaticDb.Books.Count)
                {
                    return StatusCode(StatusCodes.Status404NotFound, "Invalid index");
                }
                return StatusCode(StatusCodes.Status200OK, StaticDb.Books[index]);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error has occured !");
            }
        }

        [HttpGet("filter")] 
        public ActionResult<List<Book>> FilterBook(string titleFilter, string authorFilter)
        {
            try
            {
                if(string.IsNullOrEmpty(titleFilter) && string.IsNullOrEmpty(authorFilter))
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "You have to send at least one filter parameter !");
                }
                if (string.IsNullOrEmpty(titleFilter))
                {
                    List<Book> filteredBooksAuthor = StaticDb.Books.Where(x => x.Author.ToLower().Contains(authorFilter.ToLower())).ToList();
                    return StatusCode(StatusCodes.Status200OK, filteredBooksAuthor);
                }
                if (string.IsNullOrEmpty(authorFilter))
                {
                    List<Book> filteredBooksTitle = StaticDb.Books.Where(x => x.Title.ToLower().Contains(titleFilter.ToLower())).ToList();
                    return Ok(filteredBooksTitle);
                }
                List<Book> filteredBook = StaticDb.Books.Where(x => x.Title.ToLower().Contains(titleFilter.ToLower())
                                             && x.Author.ToLower().Contains(authorFilter.ToLower())).ToList();
                return Ok(filteredBook);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error has occured !");
            }
        }

        [HttpPost("post")]
        public IActionResult AddBook([FromBody] Book book)
        {
            try
            {
                StaticDb.Books.Add(book);
                return StatusCode(StatusCodes.Status201Created, "Book was added");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error has occured !");
            }
        }

        [HttpPost("postTitles")]
        public IActionResult GetTitles([FromBody] List<Book> books)
        {
            try
            {
                List<string> bookTitles = new List<string>();
                foreach (Book book in books)
                {
                    bookTitles.Add(book.Title);
                }
                return StatusCode(StatusCodes.Status200OK, bookTitles);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error has occured");
            }
        }
    }


}

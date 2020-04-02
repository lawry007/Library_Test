using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Library_Test.Entities;
using Library_Test.Interface;
using Library_Test.Helpers;

namespace Library_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _user;
        private IErrorLogger _logger;
        public UserController(IUser user, IErrorLogger logger)
        {
            _user = user;
            _logger = logger;
        }
        [HttpPost, Route("CheckOutBooks")]
        public IActionResult CheckOutBooks([FromBody] List<CheckOut> book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                string Token = String.Empty;
                Token = Request.Headers["Username"];
                if (Token == "User")
                {
                    try
                    {
                        foreach (var item in book)
                        {
                            var newUser = new Users()
                            {
                                UserId = Guid.NewGuid(),
                                FullName = item.FullName,
                                Email = item.Email,
                                PhoneNumber = item.PhoneNumber,
                                NationalIdentificationNumber = item.NationalIdentificationNumber,
                                DateOfCheckout = DateTime.Now,
                                ExpectedDateOfReturn = DateTimeExtensions.AddWorkdays(DateTime.Now, 10),
                                HasReturnedBook = false
                            };
                            _user.Add(newUser);
                        }
                        return Ok(book);

                    }
                    catch (Exception)
                    {

                        return BadRequest();
                    }
                }
                else
                {
                    return Unauthorized();
                }

            }

        }


        [HttpPost, Route("CheckInBooks")]
        public IActionResult CheckInBooks([FromBody] List<CheckIn> book)
        {
            double Amount = 200.00;
            DateTime checkInDate = DateTime.Now;
            double AmountToPay;
            if (!ModelState.IsValid)
                return BadRequest();
            else
            {
                string Token = String.Empty;
                Token = Request.Headers["Username"];
                if (Token == "User")
                {
                    try
                    {
                        foreach (var item in book)
                        {
                            var newCheckIn = new CheckIn()
                            {
                                UserId = item.UserId,
                                BookId = item.BookId
                            };
                            var result = (Users)_user.GetExpectedCheckOut(newCheckIn);

                            if (checkInDate > result.ExpectedDateOfReturn)
                            {
                                int a = DateTimeExtensions.GetWorkingDays(result.ExpectedDateOfReturn, checkInDate);
                                AmountToPay = Amount * a;

                            }
                            var updateEnt = new Users()
                            {
                                UserId = result.UserId,
                                FullName = result.FullName,
                                Email = result.Email,
                                PhoneNumber = result.PhoneNumber,
                                NationalIdentificationNumber = result.NationalIdentificationNumber,
                                DateOfCheckout = result.DateOfCheckout,
                                ExpectedDateOfReturn = result.ExpectedDateOfReturn,
                                HasReturnedBook = true
                            };
                            _user.CheckInBooks(updateEnt);
                            return Ok();
                        }
                        return Ok();
                    }
                    catch (Exception)
                    {
                        return BadRequest();
                    }
                }
                else
                {
                    return Unauthorized();
                }

            }

        }


        [HttpGet, Route("ViewBookDetails")]
        public IActionResult ViewBookDetails(Guid UserId)
        {
            try
            {
                IEnumerable<dynamic> user = _user.GetBooksByMostRecentActivity(UserId);
                if (user != null)
                    return Ok(user);
                else
                    return NotFound();
            }
            catch (Exception)
            {

                throw;
            }

        }

    }


}
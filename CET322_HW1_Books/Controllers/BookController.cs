using Microsoft.AspNetCore.Mvc;
using CET322_HW1_Books.Models;
using System;
using System.Collections.Generic;


namespace CET322_HW1_Books.Controllers
{
    public class BookController : Controller
    {
        private static List<Book> books = new List<Book>
    {
        new Book { Name = "Suç ve Ceza", Author = "Dostoyevski", PageNumber = 100, DueDate = DateTime.Now.AddDays(5) },  
        new Book { Name = "Sefiller", Author = "Vitor Hugo", PageNumber = 150, DueDate = DateTime.Now },              
        new Book { Name = "1984", Author = "George Orwell", PageNumber = 200, DueDate = DateTime.Now.AddDays(-5) } 
    };

        public IActionResult Detail(int id)
        {
            if (id < 0 || id >= books.Count)
            {
                return NotFound();
            }

            var book = books[id];
            return View(book);
        }
    }

}

using Homework_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_2
{
    public static class StaticDb
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book(){ Title = "War and Piece", Author = "Leo Tolstoy" },
            new Book(){ Title = "Song of Solomon", Author = "Toni Morrison" },
            new Book(){ Title = "Ulysses", Author = "James Joyce" },
            new Book(){ Title = "The shadow of the Wind", Author = "Carlos Ruiz Zafon" },
            new Book(){ Title = "The Lord of the Rings", Author = "J.R.R. Tolkien" },
            new Book(){ Title = "The Satanic Verses", Author = "Salaman Rushdie" }
        };
    }
}

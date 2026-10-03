using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bookstore.Models
{
    //Q1: Why did the property "Id" become a Primary Key without any explicit configuration?
    //In Entity Framework, there are certain conventions—such as naming an ID property "ID" or "BookID"—that cause it to be treated as a primary key.

    //--------------------------------------------------------------------
    //Q2: Why is "Country" nullable in the database while "Price" is not?
    //In Entity Framework, reference types (like string) are nullable by default, while value types (like decimal) are not.


    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}

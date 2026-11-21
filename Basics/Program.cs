
using System;

namespace Basics
{
    // Q01 & Q02: Book Class
    class Book
    {
        public string Title;
        public int Pages;
    }

    class Program
    {
        static void Main()
        {
            // ==============================
            // Question 1: Object Reference
            // ==============================

            Book book = new Book();

            book.Title = "The Beauty and the Bear";
            book.Pages = 100;

            // Upcasting: Book object stored in Object reference
            Object obj = book;

            Console.WriteLine(obj);


            // ==============================
            // Question 2: Object Class Methods
            // ==============================

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());


            // ==============================
            // Question 3: Compilation Error
            // ==============================

            // int pages = "464"; // Compilation Error
            int pages = 464;     // Correct solution


            // ==============================
            // Question 4: Exception Handling
            // ==============================

            int x = 10;
            int y = 0;

            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }


            // ==============================
            // Question 5: Implicit Casting
            // ==============================

            int bookPages = 300;

            // Implicit conversion: int -> double
            double papers = bookPages;


            // ==============================
            // Question 6: Explicit Casting
            // ==============================

            double price = 49.99;

            // Explicit conversion: double -> int
            int cost = (int)price;


            // ==============================
            // Question 7: Convert Class
            // ==============================

            string pagesText = "464";

            int convertedPages = Convert.ToInt32(pagesText);

            Console.WriteLine(convertedPages);


            // ==============================
            // Question 8: Parse & TryParse
            // ==============================

            string yearText = "2023";

            int year = int.Parse(yearText);

            Console.WriteLine(year);

            string badText = "abc";
            int num;

            if (int.TryParse(badText, out num))
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }


            // ==============================
            // Question 9: ToString()
            // ==============================

            int originalPages = 464;

            string pagesString = originalPages.ToString();

            Console.WriteLine(pagesString.GetType());


            // ==============================
            // Question 10: Boxing & Unboxing
            // ==============================

            int copies = 100;

            // Boxing: Value Type -> Object
            Object boxedObject = copies;

            Console.WriteLine(boxedObject);

            // Unboxing: Object -> Value Type
            int copies2 = (int)boxedObject;

            Console.WriteLine(copies2);
        }
    }
}

namespace RouteAssignment1
{
    class Book
    {
        public string title;
        public int pages;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q. 01 , 
            object book1 = new Book() { title = "It", pages = 200 };
            //Q . 02
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book1.Equals(book1));
            Console.WriteLine(book1.GetHashCode());
            Console.WriteLine(book1.GetType());
            // Q. 03
            // int pages = "464" is a logical
            //int pages = 464; //fix

            // Q. 04
            try
            {
                int x = 10;
                Console.WriteLine(x / 0);
            }
            catch
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            // Q .05
            int pages = 300;
            double doublePages = pages; // implicit casting
            // Q. 06
            double price = 49.99;
            int lowPrice = (int)price; // explicit casting
            // Q.07
            string pagesText = "464";
            pages = Convert.ToInt32(pagesText); // conversion
            //Q . 08
            string yearText = "2023";
            string badText = "abc";
            if (int.TryParse(badText, out int result)) //int.TryParse
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            int yearInt = int.Parse(yearText); // int.Parse
            Console.WriteLine(yearInt);
            //Q. 09
            pages = 464;
            string pagesString = pages.ToString();
            Console.WriteLine(pagesString.GetType());
            // Q. 10
            int copies = 100;
            object copiesObj = copies;
            int copiesUnbox = (int)copiesObj;
            Console.WriteLine(copiesObj);
            Console.WriteLine(copiesUnbox);//boxing and unboxing
            // Q. 11
            int? year = null;
            Console.WriteLine(year.HasValue);
            year = 2023;
            Console.WriteLine(year);
            // Q. 12
            string? reviewer = null;
            Console.WriteLine(reviewer == null);
            // Q. 13
            Book? Book = null;
            Console.WriteLine(Book?.title);
            // Q. 14
            Console.WriteLine(Book?.title ?? "Untitled");
            if (Book?.title == null)
            {
                Book?.title ??= "Untitled";
            }
            // Q. 15
            string? name = "Ahmed";
            string confirmedName = name!;
        }
    }
}
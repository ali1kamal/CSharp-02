namespace Task_01
{
     public class Program
    {
        static void Main(string[] args)
        {
            //1st answer
            #region first answer
            /*Book book = new Book();
            object book2 = book;
            Console.WriteLine(book2); */
            #endregion


            //2nd answer
            #region second answer
            Book book = new Book();
            book.Title = "Ali Book";
            book.Pages = 204;
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetType());
            Console.WriteLine(book.GetHashCode());
            #endregion

        }
    }
}

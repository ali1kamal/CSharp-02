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
            //Book book = new Book();
            //book.Title = "Ali Book";
            //book.Pages = 204;
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetType());
            //Console.WriteLine(book.GetHashCode());
            #endregion

            //3d answer
            #region third answer
            //int page = "464";
            //is a compile-time error(suntax error) because int doesn't use ""
            //the correcting of it will be
            //int page = 464;
            #endregion

            //4th answer
            #region fourth answer
            //int x = 10;
            //int y = 0;
            //try
            //{
            //    int result = x / y;
            //    Console.WriteLine(result);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine("you r dividing by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            //5th answer
            #region fifth answer
            //int pages = 300;
            //double page = pages;
            #endregion


            //6th answer
            #region sixth answer
            //double price = 49.99;
            //int p = (int)price;
            #endregion


            //7th answer
            #region 7th answer
            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            #endregion

            //8th answer
            #region 8th answer
            string yearText = "2023";
            int year = int.Parse(yearText);

            string badText = "abc";
            if(int.TryParse(badText, out int badInt))
            {
                Console.WriteLine(badInt);
            }
            else
            {
                Console.WriteLine( "invalid number");
            }
            #endregion
        }
    }
}

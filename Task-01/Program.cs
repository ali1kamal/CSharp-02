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
            int x = 10;
            int y = 0;
            try
            {
                int result = x / y;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("you r dividing by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion
        }
    }
}

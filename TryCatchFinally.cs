internal class TryCatchFinally
{
    private static void Main(string[] args)
    {
        /*
        try
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered Number: " + number);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message.ToString());
        }
        finally
        {
            Console.WriteLine("Transaction is completed.");
        }
        */

        try
        {
            //int a = int.Parse(null);
            //int b = int.Parse("test");
            int c = int.Parse("-20000000000");
        }
        catch (ArgumentNullException ex)
        {
          Console.WriteLine("You entered an empty value!");
          Console.WriteLine(ex);
        }
        catch (FormatException ex)
        {
          Console.WriteLine("Data type is not suitable!");
          Console.WriteLine(ex);
        }
        catch (OverflowException ex)
        {
          Console.WriteLine("You entered a very small or very large value!");
          Console.WriteLine(ex);
        }
        finally{
            Console.WriteLine("Transaction is completed successfully!");
        }
    }
}
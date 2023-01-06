/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TryAndCatch
    {
        try
        {
            string content = File.ReadAllText(@"C:\testfiles\WriteTxt.txt");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("There was a problem");
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("There was a problem");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("There was a problem");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine();

        }
        Console.ReadLine();
    }
}
*/
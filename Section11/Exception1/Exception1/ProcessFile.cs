using System;
using System.IO;
public class ProcessFile
{
    public static void Run()
    {
        FileStream fs = null;
        try
        {
            fs = new FileStream(@"C:\wamp64\www\dev\index.php", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (fs != null)
            {
                fs.Close();
            }
        }
    }    
}
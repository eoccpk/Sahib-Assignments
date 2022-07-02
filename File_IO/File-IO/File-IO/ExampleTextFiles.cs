using System;
using System.IO;
namespace File_IO
{
    public class ExampleTextFiles
    {
        public void Write()
        {
            try
            {
                StreamWriter sw = new StreamWriter("D: \\File_IO\\data.text");
                //write a line of text
                sw.WriteLine("Helllo World");
                //write a second line of text
                sw.WriteLine("writing to file");
                // close the file
                sw.Close();
            }
             //catch (Exception e)
             //{
             //console.writeline("Exception:"+e.Message);
             //}
             catch (Exception e)
            {
                Console.WriteLine("Exception:"+ e.Message);
            }
            finally
            {
                Console.WriteLine("Exception finally block.");
            }
        }
         public void Read()
         {
            string line;
            try
            {
                //pass the file path name to the streamreader constructor
                StreamReader sr = new StreamReader("D:\\File_IO\\data.text");
                //read the first line of text
                line = sr.ReadLine();
                //continue to read until you reach end of file
                while (line != null)
                {
                    // write the line to console window
                    Console.WriteLine(line);
                    //read the next line 
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
             Console.WriteLine("Exception finally block.");
            }
         }

    }
    
}

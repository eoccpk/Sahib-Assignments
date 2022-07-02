using System;
using System.IO;
namespace File_IO
{
    internal class ExampleTextFiles2
    { 
        public void Run()
        {
            string Text = "sahibsahibsahibsahibsahib";
            string FilePath = "D:\\File-IO\\text.text";
            File.WriteAllText(FilePath, Text);
            string FileText =File.ReadAllText(FilePath);
        }  
    }
}

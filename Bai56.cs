using System;
using System.IO;
class Bai56
{
    static void Main()
    {
        string path = "path/to/your/output.csv";
        // Mở tệp để ghi
        using (StreamWriter sw = new StreamWriter(path))
        {
            // Viết tiêu đề
            sw.WriteLine("Name, Age, Country");
            // Viết dữ liệu
            sw.WriteLine("John, 30, USA"); 
            sw.WriteLine("Anna, 25, UK"); 
            sw.WriteLine("Mike, 35, Canada");
        }
        Console.WriteLine("Dữ liệu đã được ghi vào tệp CSV.");
    }
}
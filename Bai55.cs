using System;
using System.IO;
using System.Collections.Generic;

class Bai55
{
    static void Main()
    {
        string path = "path/to/your/file.csv";
        // Đọc tất cả các dòng từ tệp CSV
        var lines = File.ReadAllLines(path);
        // Phân tích cú pháp từng dòng
        foreach (var line in lines)
        {
            var values = line.Split(',');
            //In ra các giá trị
            foreach (var value in values)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}
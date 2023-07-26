﻿using System;
using System.IO;

namespace Sum
{
    class ReadTextFileExample
    {
        static void Main(string[] args)
        {
            string path = "test.txt";
            ReadTextFileExample.ReadTextFile(path);
        }
        
        static void ReadTextFile(string filePath)
        {
            try
            {
                FileInfo file = new FileInfo(filePath);
                if (!file.Exists)
                {
                    throw new FileNotFoundException();
                }

                using(StreamReader r = new StreamReader(filePath)){
                string line = "";
                int sum = 0;
                while((line = r.ReadLine()) != null) 
                {
                    Console.WriteLine(line);
                    sum += Int32.Parse(line);
                }
                Console.WriteLine("Tổng: " + sum);
                }
            }
            catch (System.Exception)
            {
                Console.Error.WriteLine("K có file hoặc nội dung không hợp lệ");
            }
        }
    }
}
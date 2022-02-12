using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\FileIoOperations\FileIoDemo\FileIoOperations\FileIoOperations\Files\Sample.txt";
           // CheckIfFlieExits(path);
            //readDataLineByLine(path);
            readDataAtOnce(path);
            Console.ReadLine();
        }
        public static bool CheckIfFlieExits(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("file exits");
                return true;

            }
            else
            {
                Console.WriteLine("file not exits");
                return false;
            }
        }
        public static void readDataLineByLine(string path)
        {
            if (CheckIfFlieExits(path))
            {
                string[] Lines = File.ReadAllLines(path);// read all words in file line by line
                foreach (string lines in Lines)
                {
                    Console.WriteLine(lines);
                }
            }
        }
        public static void readDataAtOnce(string path)
        {
            if (CheckIfFlieExits(path))
            {
                string Lines = File.ReadAllText(path);// read all data at once
                Console.WriteLine(Lines);
            }
        }
    }
}

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
            string dest = @"D:\FileIoOperations\FileIoDemo\FileIoOperations\FileIoOperations\Files\CopyFile.txt";
            CheckIfFlieExits(path);
           // readDataLineByLine(path);
            //readDataAllAtOnce(path);
           // FileCopyFromSourceToDestination(path);
            //DeleteFile(dest);
            readingformStreamReader(path);
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
        public static void readDataAllAtOnce(string path)
        {
            if (CheckIfFlieExits(path))
            {
                string Lines = File.ReadAllText(path);// read all data at once
                Console.WriteLine(Lines);
            }
        }
        public static void FileCopyFromSourceToDestination(string path)
        {
            string dest = @"D:\FileIoOperations\FileIoDemo\FileIoOperations\FileIoOperations\Files\CopyFile.txt";
            if (CheckIfFlieExits(path))
            {
                File.Copy(path, dest);// CopyAll data to file all data at once
            }
        }
        //public static void DeleteFile(string path)
        //{
        //    if (CheckIfFlieExits(path))
        //    {
        //        File.Delete(path);
        //    }
        //}
        public static void readingformStreamReader(string path)
        {
            string line = null;
            if(CheckIfFlieExits(path))
            {
                StreamReader sr = File.OpenText(path);
                // line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            
        }
    }
}

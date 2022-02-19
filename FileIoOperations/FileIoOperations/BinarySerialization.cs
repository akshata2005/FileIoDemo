﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIoOperations
{
    public class BinarySerialization
    {
        /// <summary>
        /// serialization
        /// </summary>
        public static void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"D:\FileIoOperations\FileIoDemo\FileIoOperations\FileIoOperations\Sample.txt", FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, sample);
        }
        /// <summary>
        /// deserialization
        /// </summary>
        public static void Deserialization()
        {
            FileStream fileStream = new FileStream(@"D:\FileIoOperations\FileIoDemo\FileIoOperations\FileIoOperations\Sample.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Demo sample = (Demo)binaryFormatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName {sample.ApplicationName}....ApplicationId {sample.ApplicationID}");
        }
        }
}

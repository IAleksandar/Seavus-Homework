using Homework.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Homework
{
    public class Database
    {

        private string _folderPath;
        private string _filePath;

        public Database()
        {
            _folderPath = @"..\..\..\Db";
            _filePath = _folderPath + $"\\Dogs.json";


            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }

            Dog[] data = Read();
            if(data == null)
            {
                Dog[] dogs = new Dog[0] { };
                Write(dogs);
            }

        }

        private Dog[] Read()
        {
            using (StreamReader sr = new StreamReader(_filePath))
            {
                string content = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<Dog[]>(content);
            }
        }

        private void Write(Dog[] dogs)
        {
            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                string jsonString = JsonConvert.SerializeObject(dogs);
                sw.WriteLine(jsonString);
            }
        }

        public Dog[] GetAll()
        {
            return Read();
        }

        public void Insert(Dog dog)
        {
            Dog[] dogs = Read();
            Array.Resize(ref dogs, dogs.Length + 1);
            dogs[dogs.Length - 1] = dog;
            Write(dogs);
        }
    }
}

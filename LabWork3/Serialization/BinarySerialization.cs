using System;
using laba3.Classes;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace laba3.Serialization
{
    
    public class BinarySerialization : ISerialization
    {
        public void Serialize(List<Pet> listOfPets,string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, listOfPets);
            }
        }

        public List<Pet> Deserialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                List<Pet> listOfPets = (List<Pet>)formatter.Deserialize(fs);
                return listOfPets;
            }    
        }         
    }
}
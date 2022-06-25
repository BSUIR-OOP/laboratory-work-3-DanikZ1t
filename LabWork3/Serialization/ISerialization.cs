using laba3.Classes;
using System.Collections.Generic;

namespace laba3.Serialization
{
    public interface ISerialization
    {
        void Serialize(List<Pet> listOfPets,string fileName);   
        List<Pet> Deserialize(string fileName);
    }
}
using Bandeiras.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bandeiras.Handlers
{
    public class FileHandler
    {
        string pathName = @$"{Environment.CurrentDirectory}\countries.dat";

        public void SaveCountries(List<CountryResponse> contries)
        {
            if (File.Exists(pathName))
                return;

            File.WriteAllBytes(pathName, ObjectToByteArray(contries));
        }

        public List<CountryResponse> LoadCountries()
        {
            if (!File.Exists(pathName))
                return null;

            var data = File.ReadAllBytes(pathName);

            return FromByteArray<List<CountryResponse>>(data);
        }

        private byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        public T FromByteArray<T>(byte[] data)
        {
            if (data == null)
                return default(T);

            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(data))
            {
                object obj = bf.Deserialize(ms);
                return (T)obj;
            }
        }

        public void RemoveFile()
        {
            File.Delete(pathName);
        }
    }

}

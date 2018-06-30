using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using JetBrains.Annotations;

namespace SerializableModels
{
    public class SerializationService
    {
        [NotNull]
        public string SerializeObject([NotNull] object objectToSerialize)
        {
            byte[] json;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(objectToSerialize.GetType());
                serializer.WriteObject(memoryStream, objectToSerialize);
                json = memoryStream.ToArray();
            }

            return Encoding.UTF8.GetString(json, 0, json.Length);
        }
    }
}

using System;
using System.IO;
using System.Xml.Serialization;

namespace Proxy
{
    public class XMLProxy
    {
        private readonly XmlSerializer r_XMLSerializer;

        public XMLProxy(Type i_ObjectType)
        {
            r_XMLSerializer = new XmlSerializer(i_ObjectType);
        }

        public void Serialize(Stream i_Stream, object i_Object)
        {
            try
            {
                r_XMLSerializer.Serialize(i_Stream, i_Object);
            }
            catch
            {
                i_Stream.Dispose();
            }
        }

        public object Deserialize(Stream i_Stream)
        {
            object deserializedData = null;

            try
            {
                deserializedData = r_XMLSerializer.Deserialize(i_Stream);
            }
            catch
            {
                i_Stream.Dispose();
            }

            return deserializedData;
        }
    }
}

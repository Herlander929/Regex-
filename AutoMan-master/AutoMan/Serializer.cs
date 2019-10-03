


using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;


namespace AutoMan
{
    public class Serializer
    {


        public void Grava(object obj, string FileName)
        {

            //Opens a file and serializes the object into it in binary format.
            Stream stream = File.Open(FileName, FileMode.Create);
            //BinaryFormatter formatter = new BinaryFormatter();
            XmlSerializer formatter = new XmlSerializer(obj.GetType());
            


            //BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            stream.Close();

        }

        public object  Busca(string FileName, Type type)
        {

            //BinaryFormatter formatter = new BinaryFormatter();
            //Opens file "data.xml" and deserializes the object from it.
            Stream stream = File.Open(FileName, FileMode.Open);

            XmlSerializer formatter = new XmlSerializer(type);
            //formatter = new BinaryFormatter();

            object obj = formatter.Deserialize(stream);
            stream.Close();
            return obj;


        }
    }
}

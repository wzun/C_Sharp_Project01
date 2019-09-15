using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace Mybikes.bus
{
    class FileHandler
    {
        private static string binFilePathB = @"../../Data/Bikes.bin";
        private static string binFilePathM = @"../../Data/Mountain.bin";
        private static string binFilePathR = @"../../Data/Road.bin";
 //bin file write
        public static void WriteToBinFile(List<Bikes> Bikelist)
        {
            FileStream fs = new FileStream(binFilePathB, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, Bikelist);
            fs.Close();
        }
        public static void WriteToBinFileM(List<MountainBikes> Mountainlist)
        {
            FileStream fs = new FileStream(binFilePathM, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, Mountainlist);
            fs.Close();
        }
        public static void WriteToBinFileR(List<RoadBikes> Roadlist)
        {
            FileStream fs = new FileStream(binFilePathR, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, Roadlist);
            fs.Close();
        }
 //bin file read
        public static List<Bikes> ReadFromBinFile()
        {
            List<Bikes> tempList = new List<Bikes>();
            if (File.Exists(binFilePathB))
            {
                FileStream fs = new FileStream(binFilePathB, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                tempList = (List<Bikes>)bf.Deserialize(fs);

                fs.Close();
            }
            return tempList;
        }
        public static List<MountainBikes> ReadFromBinFileM()
        {
            List<MountainBikes> tempList = new List<MountainBikes>();
            if (File.Exists(binFilePathM))
            {
                FileStream fs = new FileStream(binFilePathM, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                tempList = (List<MountainBikes>)bf.Deserialize(fs);

                fs.Close();
            }
            return tempList;
        }
        public static List<RoadBikes> ReadFromBinFileR()
        {
            List<RoadBikes> tempList = new List<RoadBikes>();
            if (File.Exists(binFilePathR))
            {
                FileStream fs = new FileStream(binFilePathR, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                tempList = (List<RoadBikes>)bf.Deserialize(fs);

                fs.Close();
            }
            return tempList;
        }
    }
}

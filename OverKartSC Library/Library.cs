using System;
using System.Windows;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OverKartSC_Library
{
    public class OKSCLibrary
    {

        MemoryStream mStream = new MemoryStream();
        BinaryReader bReader = new BinaryReader(Stream.Null);
        BinaryWriter bWriter = new BinaryWriter(Stream.Null);


        public class Character
        {
            public int topSpeed { get; set; }            
            public int[] handlingStats { get; set; }
            public int[] offroadStats { get; set; }
            public int[] accelerationStats { get; set; }
            public int[] weight { get; set; }

        }

        public class Header
        {
            public HeaderElement[] headerElement { get; set; }
        }
        public class HeaderElement
        {
            public byte[] elementBytes { get; set; }
        }



        public Header[] loadHeader(byte[] fileData)
        {
            Header[] outputHeader = new Header[44];  //44 = number of courses


            //initialize all elements
            

            for (int headerIndex = 0; headerIndex < 44; headerIndex++)
            {
                outputHeader[headerIndex] = new Header();
                outputHeader[headerIndex].headerElement = new HeaderElement[14];
                for (int elementIndex = 0; elementIndex < 14; elementIndex++)  //14 = number of elements
                {
                    outputHeader[headerIndex].headerElement[elementIndex] = new HeaderElement();
                    outputHeader[headerIndex].headerElement[elementIndex].elementBytes = new byte[4];
                }
            }


            mStream = new MemoryStream(fileData);
            bWriter = new BinaryWriter(mStream);
            bReader = new BinaryReader(mStream);

            bReader.BaseStream.Position = 0xE7FFC;  //offset to header table

            for (int currentCourse = 0; currentCourse < 44; currentCourse++)  //44 course headers
            {
                for (int currentElement = 0; currentElement < 14; currentElement++)  //14 elements per header.
                {

                    outputHeader[currentCourse].headerElement[currentElement].elementBytes = bReader.ReadBytes(4);
                    Array.Reverse(outputHeader[currentCourse].headerElement[currentElement].elementBytes);
                }
            }

            return outputHeader;
        }



        public byte[] saveHeader(byte[] fileData, Header[] courseHeader)
        {
            
            mStream = new MemoryStream(fileData);
            bWriter = new BinaryWriter(mStream);
            bReader = new BinaryReader(mStream);

            bReader.BaseStream.Position = 0xE7FFC;  //offset to header table

            for (int currentCourse = 0; currentCourse < 44; currentCourse++)  //44 course headers
            {
                for (int currentElement = 0; currentElement < 14; currentElement++)  //14 elements per header.
                {
                    Array.Reverse(courseHeader[currentCourse].headerElement[currentElement].elementBytes);
                    bWriter.Write(BitConverter.ToInt32(courseHeader[currentCourse].headerElement[currentElement].elementBytes, 0));
                }
            }

            byte[] outputData = mStream.ToArray();
            return outputData;
        }




        public void loadStats(ref Character[] characterOutput, ref int[] speedLoss, byte[] fileData)
        {
            mStream = new MemoryStream(fileData);
            bWriter = new BinaryWriter(mStream);
            bReader = new BinaryReader(mStream);

            

            //initialize all elements

            speedLoss = new int[8];
            characterOutput = new Character[8];

            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                characterOutput[characterIndex] = new Character();
            }



            //setup the position to begin reading data from. All data is end to end
            // so we'll only set the position once and then read data sequentially from there. 

            bReader.BaseStream.Position = 0xEBF48;


            //Speed Loss
            for (int currentIndex = 0; currentIndex < 8; currentIndex++)
            {
                speedLoss[currentIndex] = bReader.ReadInt16();
            }
            //Top Speed
            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                characterOutput[characterIndex].topSpeed = bReader.ReadInt32();
            }

            //acceleration stats
            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                characterOutput[characterIndex].accelerationStats = new int[16];

                for (int statIndex = 0; statIndex < 16; statIndex++)
                {
                    characterOutput[characterIndex].accelerationStats[statIndex] = bReader.ReadInt16();
                }
            }

            //weight
            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                characterOutput[characterIndex].weight = new int[6];

                for (int statIndex = 0; statIndex < 6; statIndex++)
                {
                    characterOutput[characterIndex].weight[statIndex] = bReader.ReadInt16();
                }
            }

            //handling stats
            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                characterOutput[characterIndex].handlingStats = new int[16];

                for (int statIndex = 0; statIndex < 16; statIndex++)
                {
                    characterOutput[characterIndex].handlingStats[statIndex] = bReader.ReadInt16();
                }
            }

            
            
        }


        public byte[] saveStats(byte[] fileData, Character[] inputCharacter, int[] speedLoss)
        {
            
            mStream = new MemoryStream(fileData);
            bWriter = new BinaryWriter(mStream);
            bReader = new BinaryReader(mStream);



            bReader.BaseStream.Position = 0xEBF48;


            //Speed Loss
            for (int currentIndex = 0; currentIndex < 8; currentIndex++)
            {
                bWriter.Write(Convert.ToInt16(speedLoss[currentIndex]));
            }
            //Top Speed
            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                bWriter.Write(Convert.ToInt32(inputCharacter[characterIndex].topSpeed));
            }

            //acceleration stats
            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                for (int statIndex = 0; statIndex < 16; statIndex++)
                {
                    bWriter.Write(Convert.ToInt16(inputCharacter[characterIndex].accelerationStats[statIndex]));
                }
            }

            //weight
            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                for (int statIndex = 0; statIndex < 6; statIndex++)
                {
                    bWriter.Write(Convert.ToInt16(inputCharacter[characterIndex].weight[statIndex]));
                }
            }

            //handling stats
            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                for (int statIndex = 0; statIndex < 16; statIndex++)
                {
                    bWriter.Write(Convert.ToInt16(inputCharacter[characterIndex].handlingStats[statIndex]));
                }
            }


            byte[] outputData = mStream.ToArray();
            return outputData;
        }
    }
}


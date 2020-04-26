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
            public int speedLoss { get; set; }
            public int[] handlingStats { get; set; }
            public int[] offroadStats { get; set; }
            public int[] accelerationStats { get; set; }
            public int[] weight { get; set; }

        }

        public Character[] loadStats(byte[] fileData)
        {
            Character[] characterOutput = new Character[8];

            mStream = new MemoryStream(fileData);
            bWriter = new BinaryWriter(mStream);
            bReader = new BinaryReader(mStream);


            //initialize all elements inside the array
            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                characterOutput[characterIndex] = new Character();
            }

            bReader.BaseStream.Position = 0xEBF48;


            //Speed Loss
            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                characterOutput[characterIndex].speedLoss = bReader.ReadInt16();
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

            

            return characterOutput;
        }


        public byte[] saveStats(byte[] fileData, Character[] inputCharacter)
        {
            
            mStream = new MemoryStream(fileData);
            bWriter = new BinaryWriter(mStream);
            bReader = new BinaryReader(mStream);



            bReader.BaseStream.Position = 0xEBF48;


            //Speed Loss
            for (int characterIndex = 0; characterIndex < 8; characterIndex++)
            {
                bWriter.Write(Convert.ToInt16(inputCharacter[characterIndex].speedLoss));
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


using System;
using System.IO;

namespace SecretSanta
{
    class Program
    {
        static int NumberOfParametersInFile = 2;
        static string pathToPlayersInfoDirecory = @"C:\Users\Mark3asy\Desktop\SecretSanta\";
        public static string[] GetFileNames(string pathToFilesWithPresentInfo)
        {
            string[] fileNames = Directory.GetFiles(pathToFilesWithPresentInfo);
            for (int i = 0; i <= fileNames.Length - 1; i++)
            {
                fileNames[i] = fileNames[i].Replace(pathToFilesWithPresentInfo, "");
            }
            return fileNames;
        }
        public static void ReadPresentInfoFromTextFile()
        {
            String lineOfFile;
            string[] presentInfo = null;
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Mark3asy\Desktop\SecretSanta\txt.txt");
                lineOfFile = sr.ReadLine();
                presentInfo[0] = lineOfFile;
                while (lineOfFile != null )
                {
                    //Console.WriteLine(lineOfFile);
                    lineOfFile = sr.ReadLine();
                    //presentInfo = lineOfFile;
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public static string[] Readinfo( string path, string[] fileNames)
        {
            string result = path + fileNames[1]; // рабочая тема, нужно использовать
            StreamReader sr = new StreamReader(path);
            string[] mass = null;
            for (int i = 0; i <= fileNames.Length; i++)
            {
                for (int k = 0; i <= NumberOfParametersInFile; k++)
                {
                    mass[i] = "2";
                }
            }
        return mass;
        }

        static void Main(string[] args)
        {
            Readinfo(pathToPlayersInfoDirecory, GetFileNames(pathToPlayersInfoDirecory));
            GetFileNames(pathToPlayersInfoDirecory);
            ReadPresentInfoFromTextFile();
        }
    }
}

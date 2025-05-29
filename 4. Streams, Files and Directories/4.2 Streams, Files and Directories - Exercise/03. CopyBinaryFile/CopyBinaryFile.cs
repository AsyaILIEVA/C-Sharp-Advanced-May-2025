namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using FileStream inputFileStream = new FileStream(inputFilePath,
                FileMode.Open);
            using FileStream outputFileStream = new FileStream(outputFilePath,
                FileMode.Create);

            //inputFileStream.CopyTo(outputFileStream);

            byte[] buffer = new byte[1024];

            int readBytes;
            while ((readBytes = inputFileStream.Read(buffer)) != 0) 
                outputFileStream.Write(buffer, 0, readBytes);
        }
    }
}

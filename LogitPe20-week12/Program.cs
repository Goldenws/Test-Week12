using System;
using System.IO;

namespace LogitPe20_week12
{
    class Program
    {
        static void Main(string[] args)
        {
            GettingRidOfTrash();
            Console.WriteLine("Two Tangos down, Moving to next positon!");
            MovingDesiredFiles();
        }

        public static void GettingRidOfTrash()
        {
            string rootPath = @"C:\Users\Roland Strod\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string fileName = "toiletPaper.txt";

            if (File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                
            }
            else
            {
                Console.WriteLine("NoOne's, here!");
            }

            string rootPath2 = @"C:\Users\Roland Strod\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            string fileName2 = "cheese.txt";

            if (File.Exists(Path.Combine(rootPath2, fileName2)))
            {
                File.Delete(Path.Combine(rootPath2, fileName2));
                
            }
            else
            {
                Console.WriteLine("Positon Secure!");
            }

            
            

            
        }

        public static void MovingDesiredFiles()
        {
            Console.WriteLine("What files do you want to transport ? ");
            string userInput = Console.ReadLine();
            string sourceDirectory = @"C:\Users\Roland Strod\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\Roland Strod\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            
            
            if(File.Exists(Path.Combine(sourceDirectory, destinationPath)))
            {
                
                File.Move(Path.Combine(sourceDirectory, userInput), Path.Combine(destinationPath, userInput));
                Console.WriteLine("Job Done!");
            }

            Console.WriteLine("What files do you want to transport ? ");
            string userInput2 = Console.ReadLine();
            string sourceDirectory2 = @"C:\Users\Roland Strod\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath2 = @"C:\Users\Roland Strod\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            

            if (File.Exists(Path.Combine(sourceDirectory2, userInput2)))
            {
                
                File.Move(Path.Combine(sourceDirectory2, userInput2), Path.Combine(destinationPath2, userInput2));
                Console.WriteLine("Job Done!");
            }






        }
    }
}

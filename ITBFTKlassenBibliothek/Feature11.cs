using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBFTKlassenBibliothek
{
    internal class Feature11
    {
        internal static void Feature_11()
        {
            //ChatGPT suggest
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Sound File Space Calculator");
            Console.WriteLine("2) Video File Space Calculator");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    SoundFileSpaceCalculator();
                    return true;
                case "2":
                    VideoFileSpaceCalculator();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void SoundFileSpaceCalculator()
        {
            Console.Clear();
            Console.WriteLine("To calculate the space required for a sound file, please provide the following:");
            Console.Write("Length of the audio file (in minutes): ");
            double lengthInMinutes = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bit rate of the audio file (in kbps): ");
            double bitRate = Convert.ToDouble(Console.ReadLine());
            double fileSizeInMB = (lengthInMinutes * bitRate) / 8 / 1024;
            Console.WriteLine("The file size will be approximately {0:N2} MB.", fileSizeInMB);
            Console.Write("\r\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        private static void VideoFileSpaceCalculator()
        {
            Console.Clear();
            Console.WriteLine("To calculate the space required for a video file, please provide the following:");
            Console.Write("Length of the video file (in minutes): ");
            double lengthInMinutes = Convert.ToDouble(Console.ReadLine());
            Console.Write("Resolution of the video file (in pixels, e.g. 1920x1080): ");
            string resolution = Console.ReadLine();
            int width = Convert.ToInt32(resolution.Split('x')[0]);
            int height = Convert.ToInt32(resolution.Split('x')[1]);
            Console.Write("Frame rate of the video file (in fps): ");
            double frameRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bit rate of the video file (in kbps): ");
            double bitRate = Convert.ToDouble(Console.ReadLine());
            double fileSizeInMB = (lengthInMinutes * width * height * frameRate * bitRate) / (8 * 1024 * 1024);
            Console.WriteLine("The file size will be approximately {0:N2} MB.", fileSizeInMB);
            Console.Write("\r\nPress any key to return to the main menu...");
            Console.ReadKey();

        }
    }
}

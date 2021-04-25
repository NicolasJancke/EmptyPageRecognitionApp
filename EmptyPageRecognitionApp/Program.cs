using System;
using System.Drawing;

namespace EmptyPageRecognitionApp
{
    class Program
    {
        static bool isEmptyPage(string ImageURL)
        {
            try
            {
                Bitmap image = new Bitmap(ImageURL, true);
            }
            catch(ArgumentException)
            {
                Console.Write("An error occured. The file path could be wrong.");
            }
            return true;
        }
    }
}

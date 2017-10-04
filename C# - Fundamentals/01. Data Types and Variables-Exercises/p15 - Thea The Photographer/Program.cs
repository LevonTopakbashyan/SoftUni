using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15___Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalPictures = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var percantegPictures = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var goodPictures = (int)Math.Ceiling(totalPictures * ((double)percantegPictures / 100));

            var secondsTotalPictures = totalPictures * filterTime;
            var secondsUpload = goodPictures * uploadTime;
            var totalSecond = secondsTotalPictures + secondsUpload;

            var totalTime = new TimeSpan(0, 0, totalSecond);
            Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));


        }
    }
}

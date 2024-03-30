using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223119
{
    internal class SayaTubeVideo
    {
        private int id, playCount;
        private string title;
        public SayaTubeVideo(String title)
        {
            this.title = title;
            id = new Random().Next(99999);
            playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public int getPlayCount()
        {
            return playCount;
        }

        public string getJudul()
        {
            return title;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"title: {title}\nid: {id}\nviews: {playCount}");
        }
    }
}

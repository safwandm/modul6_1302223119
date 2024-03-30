using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223119
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;

        public string Username;

        public SayaTubeUser(string username)
        {
            Username = username;

            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                total += video.getPlayCount();
            }
            return total;
        }
        public void addVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void printAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");
            int i = 0;
            foreach (var video in uploadedVideos)
            {
                Console.WriteLine($"Video {++i} judul: {video.getJudul()}");
            }
        }
    }
}

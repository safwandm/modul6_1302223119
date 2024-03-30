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

            try
            {
                if (username.Length > 100)
                {
                    throw new ArgumentException("Error: Username argument must not be longer than 200 character");
                }
                else if (username.Length == 0 || username == null)
                {
                    throw new ArgumentNullException("Username argument must not be null nor an empty string");
                }
            } catch (ArgumentNullException e) 
            {
                Console.WriteLine(e.Message);
            } catch (ArgumentException e) 
            {
                Console.WriteLine(e.Message);
            }


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
                if (i == 8)
                {
                    break;
                }
            }
        }
    }
}

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

            try
            {
                if (title.Length > 200)
                {
                    throw new ArgumentException("Error: Title argument must not be longer than 200 character");
                }
                else if (title.Length == 0 || title == null)
                {
                    throw new ArgumentNullException("Title argument must not be null nor an empty string");
                } else
                {
                    this.title = title;
                    id = new Random().Next(99999);
                    playCount = 0;
                }

            } catch (ArgumentNullException e) 
            { 
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public void IncreasePlayCount(int count)
        {
            try
            {
                if (count > 25000000)
                {
                    throw new ArgumentException("Error: Count argument must not exceed 25000000");
                }
                else if (count < 0)
                {
                    throw new ArgumentException("Error: Count argument must not be negative");
                }
                else if (count + playCount < 0)
                {
                    throw new OverflowException("Error: Overflow detected. playCount is either full or the argument will make it full");
                }
                else
                {
                    playCount += count;
                }
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            } catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
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

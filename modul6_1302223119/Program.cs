// See https://aka.ms/new-console-template for more information
using modul6_1302223119;

SayaTubeVideo vid1 = new SayaTubeVideo("Tutorial Design By Contract - [MuhammadFaisalShafwanDamanik]");
vid1.IncreasePlayCount(10000000);
vid1.PrintVideoDetails();


SayaTubeUser user1 = new SayaTubeUser("Shafwan");

List<SayaTubeVideo> videoList = new List<SayaTubeVideo>();

SayaTubeVideo vid2 = new SayaTubeVideo("Review Film ROOM oleh Shafwan");

for (int i = 0; i < 10; i++)
{

    videoList.Add(new SayaTubeVideo("Review Film 1984 oleh Shafwan"));
}


int views = 1984;
foreach (var video in videoList)
{
    video.IncreasePlayCount(views);
    views += 1984;
    user1.addVideo(video);
}

Console.WriteLine($"\nTotal view count: {user1.GetTotalVideoPlayCount()}");
user1.printAllVideoPlaycount();

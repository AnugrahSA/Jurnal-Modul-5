using System;
using System.Diagnostics.Contracts;

namespace modul5_1302204047
{
    internal class Program
    {
        static void Main(String[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Spiderman");
            SayaTubeVideo video2 = new SayaTubeVideo("Doctor Strange");
            SayaTubeVideo video3 = new SayaTubeVideo("iron man");
            SayaTubeVideo video4 = new SayaTubeVideo("Black Panther");
            SayaTubeVideo video5 = new SayaTubeVideo("Captain Marvel");
            SayaTubeVideo video6 = new SayaTubeVideo("Captain America");
            SayaTubeVideo video7 = new SayaTubeVideo("World War z");
            SayaTubeVideo video8 = new SayaTubeVideo("Doraemon");
            SayaTubeVideo video9 = new SayaTubeVideo("Spiderman No Way Home");
            SayaTubeVideo video10 = new SayaTubeVideo("Shang Chi");

            SayaTubeUser user1 = new SayaTubeUser("Anugrah Saputra Aras");
            user1.AddVideo(video1);
            user1.AddVideo(video2);
            user1.AddVideo(video3);
            user1.AddVideo(video4);
            user1.AddVideo(video5);
            user1.AddVideo(video6);
            user1.AddVideo(video7);
            user1.AddVideo(video8);
            user1.AddVideo(video9);
            user1.AddVideo(video10);
        }
    }
}
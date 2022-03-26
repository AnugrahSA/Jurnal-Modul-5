using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204047
{
	public class SayaTubeUser
	{
		private int id;
		private List<SayaTubeVideo> uploadedVideos;
		public string Username;

		public SayaTubeUser(string Username)
		{
			this.Username = Username;

			


		}

		public int GetTotalVideoPlayCount()
        {
			return uploadedVideos.Count;
        }

		public void AddVideo(SayaTubeVideo video)
        {
			uploadedVideos.Add(video);
        }

		public void PrintAllVideoPlayCount()
        {
			Console.WriteLine("User: " + Username);
			Console.WriteLine("Video 1 Judul: " + uploadedVideos.Count);
			Console.WriteLine("Video 2 Judul: " + uploadedVideos.Count);
			Console.WriteLine("Video 3 Judul: " + uploadedVideos.Count);
			Console.WriteLine("Video 4 Judul: " + uploadedVideos.Count);
			Console.WriteLine("Video 5 Judul: " + uploadedVideos.Count);
			Console.WriteLine("Video 6 Judul: " + uploadedVideos.Count);
			Console.WriteLine("Video 7 Judul: " + uploadedVideos.Count);
			Console.WriteLine("Video 8 Judul: " + uploadedVideos.Count);
			Console.WriteLine("Video 9 Judul: " + uploadedVideos.Count);
			Console.WriteLine("Video 10 Judul: " + uploadedVideos.Count);
		}
	}
}
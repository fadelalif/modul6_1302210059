using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210059
{
    public class SayaTubeUser
    {
        private int id;
        List<SayaTubeVideo> uploadedVideos;
        private string username;

        public SayaTubeUser(string username)
        {
            this.username = username;
            var random = new Random();
            this.id = random.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            return this.uploadedVideos.Count;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + username);
            for (int i = 0;i < this.uploadedVideos.Count;i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul :"+ uploadedVideos[i].getTitle());
            }
        }
    }
}

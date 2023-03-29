using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
            Debug.Assert(username <= 100 && title != null, "username memiliki panjang maksimal 100 karakter dan tidak berupa null.");
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
            Debug.Assert(video != null, "video ditambahkan tidak berupa null.");
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Debug.Assert(i <= 8, "jumlah video ditambahkan maksimal 8.");
            Console.WriteLine("User : " + username);
            for (int i = 0;i < this.uploadedVideos.Count;i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul :"+ uploadedVideos[i].getTitle());
            }
        }
    }
}

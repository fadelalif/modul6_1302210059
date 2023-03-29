using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210059
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title.Length <= 200 && title != null, "judul video memiliki panjang maksimal 200 karakter dan tidak berupa null.");
            this.title = title;
            var random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 25000000, "Input penambahan play count maksimal 25.000.000 per panggilan method-nya.");
            Debug.Assert(playCount >= 0, "Input play count tidak boleh bilangan nefatif");
            try
            {
                this.playCount = checked(this.playCount + playCount);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Overflow exception : " + e.Message);
            }
        }

        public void PrintVideoDetail()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("playCount : " + playCount);
        }

        public int getId() { return id; }
        public string getTitle() { return title; }
        public int getPlayCount() { return playCount; }
    }
}

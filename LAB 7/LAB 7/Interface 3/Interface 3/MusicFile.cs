using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_3
{
    class MusicFile
    {
        private string title;
        private string artist;
        private int yearOfRelease;
        private int durationInSeconds;

        public MusicFile()
        {
            title = "See you again";
            artist = "Charli puth";
            yearOfRelease = 2015;
            durationInSeconds = 4;
        }
        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }
        public void changeTitle(string title)
        {
            this.title = title;
        }
    }
}

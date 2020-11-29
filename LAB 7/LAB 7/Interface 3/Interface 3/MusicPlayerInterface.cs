using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_3
{
    interface MusicPlayerInterface
    {

        void Switch(Boolean on);
        void play(Boolean on);
        void setVolume(int loudness);
        void playNext();
        void playPrevious();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_3
{
    interface RadioPlayerInterface
    {
        void Switch(Boolean on);
        void Return(double frequency);
        void setVolume(int loudness);
        void changeChannel();
    }
}

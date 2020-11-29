using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.songs();
            phone.changeChannel();
            phone.play(true);
            phone.playNext();
            phone.playPrevious();
            phone.Switch(true);
            Console.ReadLine();
        }
    }
}

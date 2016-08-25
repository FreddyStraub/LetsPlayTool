using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LetsPlayTool
{
    class SoundController
    {

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        /// <summary>
        /// Setzt die Systemlautstärke.
        /// </summary>
        /// <param name="volume"></param>
        public static void setVolume(int volume)
        {

            // Calculate the volume that's being set
            int NewVolume = ((ushort.MaxValue / 10) * volume);
            // Set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);

        }

    }

}
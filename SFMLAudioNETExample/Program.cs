using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SFMLAudioNETExample
{
    internal class Program
    {
        public const string SFMLAud_Version2 = @"csfml-audio-2.dll";

        [DllImport(SFMLAud_Version2, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        private static extern IntPtr sfMusic_createFromFile(string Filename);

        [DllImport(SFMLAud_Version2, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        private unsafe static extern IntPtr sfMusic_createFromStream(IntPtr stream);

        [DllImport(SFMLAud_Version2, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        private static extern IntPtr sfMusic_createFromMemory(IntPtr data, UIntPtr size);

        [DllImport(SFMLAud_Version2, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        private static extern void sfMusic_destroy(IntPtr MusicStream);

        [DllImport(SFMLAud_Version2, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        private static extern void sfMusic_play(IntPtr Music);

        [DllImport(SFMLAud_Version2, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        private static extern void sfMusic_pause(IntPtr Music);

        [DllImport(SFMLAud_Version2, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        private static extern void sfMusic_stop(IntPtr Music);

        [DllImport(SFMLAud_Version2, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        private static extern void sfMusic_setLoop(IntPtr Music, bool Loop);
        static void Main(string[] args)
        {
            IntPtr music = sfMusic_createFromFile(@"ODDNUMBER.mp3");
            if(music.ToInt64() == 0)
            {
                Console.WriteLine("Not Founded Music(ODDNUMBER.mp3");
            }
            else
            {
                sfMusic_setLoop(music, true);
                sfMusic_play(music);
                while (true)
                {
                    Thread.Sleep(2000);
                }
            }
        }
    }
}

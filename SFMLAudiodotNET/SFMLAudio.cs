using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SFMLAudiodotNET
{
    public class SFMLAudio
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

        public IntPtr CreateMusicFromFile(string filename)
        {
            IntPtr music = sfMusic_createFromFile(filename);
            return music;
        }
        public void SetLoop(IntPtr mus, bool isLoop)
        {
            sfMusic_setLoop(mus, isLoop);
        }
        public void StopMusic(IntPtr music)
        {
            sfMusic_stop(music);
        }
        public IntPtr CreateFromStream(IntPtr streamfile)
        {
            IntPtr music = sfMusic_createFromStream(streamfile);
            return music;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Majo.Controllers
{
    public class spfy
    {
        public const int KEYEVENTF_EXTENTEDKEY = 1;
        public const int KEYEVENTF_KEYUP = 0;
        public const int VK_MEDIA_NEXT_TRACK = 0xB0;
        public const int VK_MEDIA_PLAY_PAUSE = 0xB3;
        public const int VK_MEDIA_PREV_TRACK = 0xB1;
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);

        public static void playPauseTrack()
        {
            playPauseTrackIntern();
        }
        public static void prevTrack()
        {
            prevTrackIntern();
        }

        public static void nextTrack()
        {
            nextTrackIntern();
        }
        private static void playPauseTrackIntern()
        {
            keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private static void prevTrackIntern()
        {
            keybd_event(VK_MEDIA_PREV_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private static void nextTrackIntern()
        {
            keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }
    }
}

using System.Runtime.InteropServices;

namespace SysemVolume
{
    static class Volume
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public static void VolDown()
        {
            keybd_event((byte)174, 0, 0, 0);
        }

        public static void VolUp()
        {
            keybd_event((byte)175, 0, 0, 0);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Volume Up / Down? (u/d) : ");
                string? volumeString = Console.ReadLine();
                if (volumeString == null) return;
                if (volumeString.Contains("u")) Volume.VolUp();
                else if (volumeString.Contains("d")) Volume.VolDown();
                else return;
            }
        }
    }
}
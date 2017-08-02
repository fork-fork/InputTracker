using System.Runtime.InteropServices;

namespace InputTracker.Tracking.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int x;
        public int y;
    }
}

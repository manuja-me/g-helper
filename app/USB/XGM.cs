using GHelper.Helpers;
using System.Drawing;

namespace GHelper.USB
{
    public static class XGM
    {
        public static bool IsConnected() => false;
        public static void Init() { }
        public static void Light(bool status) { }
        public static void LightBrightness(int brightness) { }
        public static void LightMode(AuraMode mode, Color color, Color color2, int speed) { }
        public static void InitLight() { }
        public static void NotifyShutdown() { }
        public static void Reset() { }
        public static void SetFan(byte[] curve) { }
    }
}

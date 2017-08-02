using System;
using InputTracker.Tracking.Native;
using log4net;

namespace InputTracker.Tracking
{
    public class LogKeyboardGlobalHook : BaseKeyboardGlobalHook
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LogKeyboardGlobalHook));

        protected override void KeyboardKeyDown(VirtualKeyCode key)
        {
            log.Debug($"KDown:{(int)key}");
        }

        protected override void KeyboardKeyUp(VirtualKeyCode key)
        {
            log.Debug($"KUp:{(int)key}");
        }
    }
}

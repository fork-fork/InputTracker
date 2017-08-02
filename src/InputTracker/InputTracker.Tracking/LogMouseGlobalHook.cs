using System;
using InputTracker.Tracking.Native;
using log4net;

namespace InputTracker.Tracking
{
    public class LogMouseGlobalHook : BaseMouseGlobalHook
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LogMouseGlobalHook));

        protected override void LeftButtonDown(POINT pos)
        {
            log.Debug($"LBDown:{pos.x}:{pos.y}");
        }

        protected override void LeftButtonUp(POINT pos)
        {
            log.Debug($"LBUp:{pos.x}:{pos.y}");
        }

        protected override void Move(POINT pos)
        {
            log.Debug($"Move:{pos.x}:{pos.y}");
        }

        protected override void RightButtonDown(POINT pos)
        {
            log.Debug($"RBDown:{pos.x}:{pos.y}");
        }

        protected override void RightButtonUp(POINT pos)
        {
            log.Debug($"RBUp:{pos.x}:{pos.y}");
        }

        protected override void WheelMove(int delta)
        {
            log.Debug($"WMove:{delta}");
        }
    }
}

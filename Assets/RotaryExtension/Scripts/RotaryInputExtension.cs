using System.Runtime.InteropServices;

namespace RotaryInput
{
    public enum RotaryDirection
    {
        None = 0,
        Clockwise,
        CounterClockwise
    }

    class RotaryInputExtension
    {
        [DllImport("rotaryinput")]
        private static extern int getRotaryDirection();

        public static RotaryDirection GetBezelInput()
        {
            return (RotaryDirection)getRotaryDirection();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace Auto_Clicker
{
    public static class MouseInputSender
    {
        static InputSimulator sim = new InputSimulator();

        public static void Left()
        {
            sim.Mouse.LeftButtonClick();
        }

        public static void LeftStack()
        {
            sim.Mouse.LeftButtonDoubleClick();
            sim.Mouse.LeftButtonDoubleClick();
            sim.Mouse.LeftButtonDoubleClick();
            sim.Mouse.LeftButtonDoubleClick();
            sim.Mouse.LeftButtonDoubleClick();
            sim.Mouse.LeftButtonDoubleClick();
            sim.Mouse.LeftButtonDoubleClick();
            sim.Mouse.LeftButtonDoubleClick();
            sim.Mouse.LeftButtonDoubleClick();
            sim.Mouse.LeftButtonDoubleClick();
        }
        public static void Right()
        {
            sim.Mouse.RightButtonClick();
        }

        public static void RightStack()
        {
            sim.Mouse.RightButtonDoubleClick();
            sim.Mouse.RightButtonDoubleClick();
            sim.Mouse.RightButtonDoubleClick();
            sim.Mouse.RightButtonDoubleClick();
            sim.Mouse.RightButtonDoubleClick();
            sim.Mouse.RightButtonDoubleClick();
            sim.Mouse.RightButtonDoubleClick();
            sim.Mouse.RightButtonDoubleClick();
            sim.Mouse.RightButtonDoubleClick();
            sim.Mouse.RightButtonDoubleClick();
        }

        public static void ScrollWheel(int lines)
        {
            sim.Mouse.VerticalScroll(lines);
        }
    }
}

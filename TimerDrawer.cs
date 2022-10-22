using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyGroupConsoleUI
{
    class TimerDrawer
    {
        private readonly ConsoleDrawer drawer;

        public TimerDrawer()
        {
            drawer = new ConsoleDrawer(Console.CursorTop, Console.CursorLeft); 
        }

        public void drawFrame()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            drawer.WriteAt("||", 0, 1);
            drawer.WriteAt("||", 10, 1);
            drawer.WriteAt("||", 0, 2);
            drawer.WriteAt("||", 10, 2);
            drawer.WriteAt("||", 0, 3);
            drawer.WriteAt("||", 10, 3);
            drawer.WriteAt("||", 0, 4);
            drawer.WriteAt("||", 10, 4);

            for (int i = 2; i < 9; i++)
            {
                drawer.WriteAt("==", i, 1);
                drawer.WriteAt("==", i, 1);
            }

            for (int i = 2; i < 9; i++)
            {
                drawer.WriteAt("==", i, 3);
                drawer.WriteAt("==", i, 3);
            }
        }
        public void draw(string timer)
        {
            Console.ResetColor();
            drawer.WriteAt(timer, 2, 2);
        }

        public void drawType()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            drawer.WriteAt("Reading ", 2, 4);
        } 
    }
}

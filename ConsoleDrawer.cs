using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyGroupConsoleUI
{
    public class ConsoleDrawer
    {
        private int OrigRow { get; set; }
        private int OrigCol { get; set; }
        public ConsoleDrawer(int origRow, int origCol)
        {
            OrigRow = origRow;
            OrigCol = origCol;
        }

        public void WriteAt(string s, int x, int y)
        {
            {
                Console.SetCursorPosition(OrigCol + x, OrigRow + y);
                Console.Write(s);
            }
        }

    }
}

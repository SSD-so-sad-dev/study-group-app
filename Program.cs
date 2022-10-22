using StudyGroupConsoleUI;
using System.Diagnostics;


// Console.ForegroundColor = ConsoleColor.White;
// Console.BackgroundColor = ConsoleColor.Red;
var drawer = new TimerDrawer();
drawer.drawFrame();
drawer.drawType();

var timer = 30 * 1000 * 60;
var stopwatch = Stopwatch.StartNew();
var elapsedTime = timer - stopwatch.ElapsedMilliseconds;

while(elapsedTime > 0)
{
    var timespan = TimeSpan.FromMilliseconds(elapsedTime);
    var str = string.Format("{0:D2}:{1:D2}:{2:D2}", timespan.Hours, timespan.Minutes, timespan.Seconds);
    drawer.draw(str);
    elapsedTime = timer - stopwatch.ElapsedMilliseconds;
}


using System.Diagnostics;

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine( "Start ");

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGreen;

var tempo = 30 * 1000 * 60;
var cronometro = Stopwatch.StartNew();
var percorrido = tempo - cronometro.ElapsedMilliseconds;

while(percorrido > 0)
{   
    var timespan = TimeSpan.FromMilliseconds(percorrido);
    Console.Write("\r {0:D2}:{1:D2}:{2:D2} ", timespan.Hours, timespan.Minutes, timespan.Seconds);
    percorrido = tempo - cronometro.ElapsedMilliseconds;
}
// See https://aka.ms/new-console-template for more information
using System.Media;

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Snek Time");
Console.WriteLine("       ---_ ......._-_--.");
Console.WriteLine(@"      (|\ /      / /| \  \ ");
Console.WriteLine("      /  /     .'  -=-'   `.");
Console.WriteLine("     /  /    .'             )");
Console.WriteLine("   _ /  /   .'        _.)   /");
Console.WriteLine("  / o   o        _.- ' /  .'");
Console.WriteLine(@"  \          _.- '    / .' *|");
Console.WriteLine(@"   \______.- '//    .'.' \*|");
Console.WriteLine(@"    \|  \ | //   .'.' _ |*|");
Console.WriteLine(@"     `   \|//  .'.'_ _ _|*|");
Console.WriteLine(@"      .  .// .'.' | _ _ \*|");
Console.WriteLine(@"      \`-|\_ / /    \ _ _ \*\ ");
Console.WriteLine(@"       `/ '\__/      \ _ _ \*\ ");
Console.WriteLine(@"      / ^|            \ _ _ \* ");
Console.WriteLine(@"     '  `             \ _ _ \   ");
Console.WriteLine(@"                       \_");

Console.WriteLine("Ready?");
string result = Console.ReadLine();
if(result.ToUpper() != "Y" || result.ToUpper() != "YES")
{
    for (var x = 0; x < 10; x++) {
        Console.WriteLine("TOO BAD");
        Thread.Sleep(100);
    }
}

Console.Clear();

SoundPlayer soundPlayer = new SoundPlayer();
soundPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Music\\ryf-greensnake.wav";
soundPlayer.PlayLooping();

while (true)
{
    Console.WriteLine("            ____ ");
    Console.WriteLine("      _,.-'`_ o `;__,   ");
    Console.WriteLine("       _.-'` '---'  '");

    Thread.Sleep(500);
    Console.Clear();

    Console.WriteLine("                    ____");
    Console.WriteLine("                 .'`_ o `;__,");
    Console.WriteLine("       .       .'.'` '---'  '   ");
    Console.WriteLine("       .`-...-'.'");
    Console.WriteLine("        `-...-'");

    Thread.Sleep(500);
    Console.Clear();

    Console.WriteLine("                        _,.--.");
    Console.WriteLine("    --..,_           .'`__ o  `;__,");
    Console.WriteLine("       `'.'.       .'.'`  '---'`  ' ");
    Console.WriteLine("          '.`-...-'.'");
    Console.WriteLine("            `-...-'");

    Thread.Sleep(500);
    Console.Clear();

    Console.WriteLine("    --..,_                     _,.--.");
    Console.WriteLine("       `'.'.                .'`__ o  `;__. ");
    Console.WriteLine("          '.'.            .'.'`  '---'`  `");
    Console.WriteLine("            '.`'--....--'`.'");
    Console.WriteLine("              `'--....--'`");

    Thread.Sleep(500);
    Console.Clear();
}


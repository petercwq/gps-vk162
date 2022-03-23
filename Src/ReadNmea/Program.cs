using System.IO.Ports;

using var sp = new SerialPort("/dev/ttyACM0", 115200);
while (true)
{
    var line = sp.ReadLine();
    Console.WriteLine(line);
}
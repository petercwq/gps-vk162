using System.IO.Ports;

using var sp = new SerialPort("/dev/ttyACM0", 115200);

sp.Open();
while (true)
{
    try
    {
        string message = sp.ReadLine();
        Console.WriteLine(message);
    }
    catch (TimeoutException) { }
}

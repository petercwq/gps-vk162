// Get a list of serial port names.
using System.IO.Ports;

string[] ports = SerialPort.GetPortNames();

Console.WriteLine("The following serial ports were found:");
// Display each port name to the console.
foreach (string port in ports)
{
    Console.WriteLine(port);
}

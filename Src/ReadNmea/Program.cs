using System.IO.Ports;

//using var sp = new SerialPort("/dev/ttyACM0", 115200);
//sp.Open();
//while (true)
//{
//    try
//    {
//        string message = sp.ReadLine();
//        Console.WriteLine(message);
//    }
//    catch (TimeoutException) { }
//}

// https://dotmorten.github.io/NmeaParser/api/index.html
// /dev/ttyACM0
// COM6
var sp = new SerialPort("/dev/ttyACM0", 115200);
var device = new NmeaParser.SerialPortDevice(sp);
device.MessageReceived += (s, e) =>
{
    // called when a message is received
    if (e.Message is NmeaParser.Messages.Rmc rmc)
    {
        Console.WriteLine($"RMC: {rmc.FixTime}, {rmc.Latitude}, {rmc.Longitude}");
    }
};
await device.OpenAsync();

Console.ReadKey();

await device.CloseAsync();
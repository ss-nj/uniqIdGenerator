
using DeviceId;

string deviceId = new DeviceIdBuilder()
                                  .AddMacAddress().AddOsVersion().AddMachineName()
                                  .ToString(); 
Console.WriteLine("copy and send this code to it support");
Console.WriteLine(deviceId);

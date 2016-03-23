using System;
using System.Dynamic;
using System.IO;

namespace DriverInstaller
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Installing Miura M010 driver on {0} OS", Environment.Is64BitOperatingSystem ? "x64" : "x86");
                var pathToDPinst = string.Format(@"{0}M010\{1}\dpinst.exe", AppDomain.CurrentDomain.BaseDirectory,
                    Environment.Is64BitOperatingSystem ? "amd64" : "x86");
                Console.WriteLine("DPInst path : " + pathToDPinst);
                var startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                    FileName = pathToDPinst,
                    Arguments = "/LM /F" // https://msdn.microsoft.com/en-us/library/windows/hardware/ff544775(v=vs.85).aspx
                };
                System.Diagnostics.Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                Console.ReadLine();
            }
        }
    }
}

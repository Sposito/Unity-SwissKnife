 using System.Diagnostics;
    class WifiUtils{
      void SetWifi(bool on){
          var proc = new ProcessStartInfo("networksetup");
          proc.Arguments = "-setairportpower en0 " + (on ? "on" : "off");
          Process.Start(proc);
      }
    }

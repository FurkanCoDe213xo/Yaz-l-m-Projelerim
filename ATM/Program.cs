using System;
using System.Windows.Forms;

namespace ATM;
internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
    xml ATM/ATM.csproj
    <Project Sdk = "Microsoft.NET.Sdk.WindowsDesktop" >
      < PropertyGroup >
        < OutputType > WinExe </ OutputType >
        < TargetFramework > net8.0-windows</TargetFramework>
        <UseWindowsForms>true</UseWindowsForms>
        <Nullable>enable</Nullable>
      </PropertyGroup>
    </Project>
}
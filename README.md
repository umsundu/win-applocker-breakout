# win-applocker-breakout
Tools used for applocker breakout when the usual methods fail.

# exec.cs
exec.cs is a C# program which uses a custom installer class that overrides the Uninstall method, allowing it to execute code when the compiled executable is run with InstallUtil.exe during the uninstall process. When triggered, it calls a static method that attempts to read a file named task_update.log from the current user's Downloads folder. If the file exists, it reads the content (expected to be a PowerShell script) and executes it in memory using a hidden PowerShell runspace, without spawning a visible PowerShell window. 

# MSBuildSll.csproj

## All Credit to:
* https://github.com/Cn33liz
* Casey Smith, Twitter: @subTee
  
## MSBuildShell
Slightly modified version of https://github.com/Cn33liz/MSBuildShell. MSBuildShell, a Powershell Host running within MSBuild.exe. 

## MSBuildShell, a Powershell Host running within MSBuild.exe
This code let's you Bypass Application Whitelisting and Powershell.exe restrictions and gives you a shell that almost looks and feels like a normal Powershell session (Get-Credential, PSSessions -> Works, Tab Completion -> Unfortunately not). It will also bypass the Antimalware Scan Interface (AMSI), which provides enhanced malware protection for Powershell scripts.

License: BSD 3-Clause

### Save This File And Execute The Following Command:

```
C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe C:\Scripts\MSBuildShell.csproj

Or

C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe C:\Scripts\MSBuildShell.csproj
```

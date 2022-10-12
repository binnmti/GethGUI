using System.Diagnostics;
using System.Text;

namespace GethGUI
{
    public class GethExe
    {
        private readonly StringBuilder Output = new();
        private readonly ProcessStartInfo Info = new();
        private readonly Process Process = new();
        private readonly CancellationTokenSource CancelToken = new();
        private StreamWriter StreamWriter;

        public delegate void OutputDataReceived(string data);
        public event OutputDataReceived OnOutputDataReceived;

        public GethExe(string folderName)
        {
            Info.WorkingDirectory = folderName;
            Info.FileName = Environment.GetEnvironmentVariable("ComSpec");
            Info.CreateNoWindow = true;
            Info.UseShellExecute = false;
            Info.RedirectStandardError = true;
            Info.RedirectStandardOutput = true;
            Info.RedirectStandardInput = true;
            Process.StartInfo = Info;
            Process.EnableRaisingEvents = true;
            Process.Exited += (sender, ev) =>
            {
                CancelToken.Cancel();
            };
        }

        public void Writer(string value)
        {
            StreamWriter.WriteLine(value);
        }

        public string Run(string arguments)
        {
            Info.Arguments = $"/c geth {arguments}";
            Process.Start();
            Process.BeginErrorReadLine();
            Process.BeginOutputReadLine();
            Process.OutputDataReceived += (sender, ev) =>
            {
                OnOutputDataReceived?.Invoke(ev.Data + Environment.NewLine ?? "");
                Output.AppendLine(ev.Data);
            };
            Process.ErrorDataReceived += (sender, ev) =>
            {
                OnOutputDataReceived?.Invoke(ev.Data + Environment.NewLine ?? "");
                Output.AppendLine(ev.Data);
            };
            StreamWriter = Process.StandardInput;
            if (arguments.Contains("console"))
            {
                return "";
            }
            else
            {
                CancelToken.Token.WaitHandle.WaitOne();
                Process.WaitForExit();
                return Output.ToString();
            }
        }

        public static string Run(string folderName, string arguments)
        {
            using var ps = new Process();
            ps.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
            ps.StartInfo.Arguments = $"/c geth {arguments}";
            ps.StartInfo.WorkingDirectory = folderName;
            ps.StartInfo.RedirectStandardOutput = true;
            ps.StartInfo.RedirectStandardError = true;
            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.CreateNoWindow = true;
            ps.Start();
            ps.BeginErrorReadLine();
            ps.BeginOutputReadLine();
            var log = new StringBuilder();
            ps.OutputDataReceived += (sender, ev) =>
            {
                log.AppendLine(ev.Data);
            };
            ps.ErrorDataReceived += (sender, ev) =>
            {
                log.AppendLine(ev.Data);
            };
            ps.WaitForExit();
            return log.ToString();
        }
    }
}

using System.Data;
using System.Diagnostics;
using System.Text;

namespace GethGUI;

public class GethProcess
{
    private bool IsConsole;
    private readonly ProcessStartInfo Info = new();
    private readonly Process Process = new();
    private readonly CancellationTokenSource CancelToken = new();
    private StreamWriter StreamWriter = default!;
    public delegate void OutputDataReceived(string data);
    public event OutputDataReceived OnOutputDataReceived = delegate { };

    public GethProcess(string folderName)
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
        if (!IsConsole) return;

        StreamWriter.WriteLine(value);
        OnOutputDataReceived.Invoke($"{Environment.NewLine}> {value}");
    }

    public string Run(string arguments)
    {
        Info.Arguments = $"/c geth {arguments}";
        Process.Start();
        Process.BeginErrorReadLine();
        Process.BeginOutputReadLine();
        Process.OutputDataReceived += (sender, ev) =>
        {
            if (ev.Data == "> ") return;
            OnOutputDataReceived.Invoke(ev.Data ?? "");
        };
        Process.ErrorDataReceived += (sender, ev) =>
        {
            if (ev.Data == "> ") return;
            OnOutputDataReceived.Invoke(ev.Data ?? "");
        };
        StreamWriter = Process.StandardInput;
        if (arguments.Contains("console"))
        {
            IsConsole = true;
            return $">geth {arguments}{Environment.NewLine}";
        } 
        else
        {
            //TODO:Delete 
            IsConsole = false;
            CancelToken.Token.WaitHandle.WaitOne();
            Process.WaitForExit();
            return "";
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
        log.AppendLine($">geth {arguments}");
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

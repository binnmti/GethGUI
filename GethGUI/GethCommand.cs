using System.Diagnostics;

namespace GethGUI
{
    internal static class GethCommand
    {
        public static string Run(string folderName, string arguments)
        {
            //TODO:Windows Only
            using var ps = new Process();
            ps.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
            ps.StartInfo.Arguments = arguments != "" ? $"/c geth {arguments}" : "/c geth";
            ps.StartInfo.WorkingDirectory = folderName;
            ps.StartInfo.RedirectStandardOutput = true;
            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.CreateNoWindow = true;
            ps.Start();
            var result = ps.StandardOutput.ReadToEnd();

            ps.WaitForExit();
            return result;
        }
    }
}

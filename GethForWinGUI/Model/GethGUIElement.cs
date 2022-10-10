using GethGUI.Model;
using System.Text.Json;

namespace GethForWinGUI.Model
{
    public class GethGUIElement
    {
        public string DataDirectory { get; set; } = "";
        public Genesis Genesis { get; set; } = new();
    }

    public static class GethGUIElementFileIO
    {
        public static GethGUIElement Load(string fileName)
        {
            if (!File.Exists(fileName)) return new GethGUIElement();

            var text = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<GethGUIElement>(text) ?? new GethGUIElement();
        }

        public static void Save(this GethGUIElement element, string fileName)
        {
            var json = JsonSerializer.Serialize(element);
            File.WriteAllText(fileName, json);
        }
    }


}

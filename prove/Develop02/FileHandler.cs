using System.IO;
public class FileHandler() {
    public void SaveEntry(List<Entry> entries, string filename) {

        string path = filename;
        using (StreamWriter sw = File.AppendText(path))
        {
            foreach (var entry in entries)
            {
                sw.WriteLine($"{entry._entryDateTime}|{entry._givenPrompt}|{entry._entryText}|{entry._entrymood}");
            }
        }
    }
    public List<Entry> LoadEntries(string filename) {
        string path = filename;
        List<Entry> entries = new List<Entry>();
        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] entry = s.Split('|');
                entries.Add(new Entry(entry[1], entry[2], entry[0], entry[3]));
            }
        }
        return entries;
    }
}
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private List<string> _prompts = new List<string>
    {
        "What did you learn today?",
        "What was the best part of your day?",
        "What challenges did you face?",
        "What are you grateful for today?",
        "What goals do you have for tomorrow?"
    };

    public void AddEntry(Entry newEntry)
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        console.WriteLine(prompt);
        console.Write("Your response: ");
        string text = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        AddEntry newEntry = new Entry(date, prompt, text);
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string File)
    {
        foreach (Entry entry in _entries)
        {
            writer.WriteLine($"{entry._date}| {entry._prompt}|{entry._text}");
        }
    }

    public void LoadFromFile(string File)
    {
        _entries.Clear();
        foreach (string line in File.ReadAllLines(file))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }
    }
    
}
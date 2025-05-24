using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToShortDateString();
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.Write($"Date: {_date}");
        Console.WriteLine($"- Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine();
    }

    public string ToCsv()
    {
        return $"{_date},{_prompt},{_response}";
    }

    public static Entry FromCsv(string csvLine)
    {
        var parts = csvLine.Split(',');
        var entry = new Entry(parts[1], parts[2]);
        entry._date = parts[0]; 
        return entry;
    }
}

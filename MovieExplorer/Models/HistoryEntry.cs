using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieExplorer.Models;

public class HistoryEntry
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Emoji { get; set; }
    public List<string> Genre { get; set; }
    public DateTime Timestamp { get; set; }
}

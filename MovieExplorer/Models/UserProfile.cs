using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieExplorer.Models;

public class UserProfile
{
    public string UserName { get; set; }
    public List<string> FavouriteTitles { get; set; } = new();
    public List<HistoryEntry> History { get; set; } = new();
}


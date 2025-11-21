using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieExplorer.Models;

public class Movie
{
    public string Title { get; set; }
    public int Year { get; set; }
    public List<string> Genre { get; set; }
    public string Director { get; set; }
    public double Rating { get; set; }
    public string Emoji { get; set; }
}
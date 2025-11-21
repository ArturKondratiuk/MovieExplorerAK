using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using MovieExplorer.Models;

namespace MovieExplorer.Services;

public class MovieService
{
    private const string LocalFileName = "movies_cache.json";
    private readonly string localPath = Path.Combine(FileSystem.AppDataDirectory, LocalFileName);

    public async Task<List<Movie>> LoadMoviesAsync()
    {
        if (File.Exists(localPath))
        {
            // loading locally
            string json = await File.ReadAllTextAsync(localPath);
            return JsonSerializer.Deserialize<List<Movie>>(json);
        }

        // first start — copy that from Resources
        using var stream = await FileSystem.OpenAppPackageFileAsync("moviesemoji.json");
        using var reader = new StreamReader(stream);
        string jsonData = await reader.ReadToEndAsync();

        // cash$$$
        await File.WriteAllTextAsync(localPath, jsonData);

        return JsonSerializer.Deserialize<List<Movie>>(jsonData);
    }
}


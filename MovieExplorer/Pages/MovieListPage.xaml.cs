using System.Linq;                
using MovieExplorer.Services;     
using MovieExplorer.Models;


namespace MovieExplorer.Pages;

public partial class MovieListPage : ContentPage
{
    private List<Movie> allMovies;

    public MovieListPage()
    {
        InitializeComponent();
        LoadMovies();
    }

    private async void LoadMovies()
    {
        var service = new MovieService();
        allMovies = await service.LoadMoviesAsync();
        MovieListView.ItemsSource = allMovies;
    }

    private void OnSearchChanged(object sender, TextChangedEventArgs e)
    {
        string query = e.NewTextValue?.ToLower() ?? "";

        var filtered = allMovies.Where(m =>
            m.Title.ToLower().Contains(query) ||
            m.Genre.Any(g => g.ToLower().Contains(query))
        ).ToList();

        MovieListView.ItemsSource = filtered;
    }

    private void OnMovieSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Movie movie)
        {
            Navigation.PushAsync(new MovieDetailsPage(movie));
        }
    }
}

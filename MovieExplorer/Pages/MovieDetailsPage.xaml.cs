using MovieExplorer.Models;

namespace MovieExplorer.Pages;

public partial class MovieDetailsPage : ContentPage
{
    public MovieDetailsPage(Movie movie)
    {
        InitializeComponent();
        BindingContext = movie;
    }
}

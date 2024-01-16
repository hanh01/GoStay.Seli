
using HotelApiV56.Api;

namespace GoStay.Seli.srcComponent;

public class Api
{
    private static readonly Api Instance = new();

    public Api()
    {
        var baseurl = Environment.GetEnvironmentVariable("API_HOST");
        if (baseurl != null)
        {
            // HomePageApi = new HomePageApi(baseurl);
            HomePageNewApi = new HomePageNewApi(baseurl);
            // ListingDetailPageApi = new ListingDetailPageApi(baseurl);
            ListingNewDetailPageApi = new ListingNewDetailPageApi(baseurl);
            // ProfilePageApi = new ProfilePageApi(baseurl);
            ProfilePageNewApi = new ProfilePageNewApi(baseurl);
            CollectionPageApi = new CollectionPageApi(baseurl);
            FavoriteApi = new FavoriteApi(baseurl);
            ListingzsPageApi = new ListingzsPageApi(baseurl);
        }
    }

    // public HomePageApi HomePageApi { get; set; }
    public HomePageNewApi HomePageNewApi { get; set; }
    // public ListingDetailPageApi ListingDetailPageApi { get; set; }
    
    public ListingNewDetailPageApi ListingNewDetailPageApi { get; set; }
    // public ProfilePageApi ProfilePageApi { get; set; }
    public ProfilePageNewApi ProfilePageNewApi { get; set; }
    public CollectionPageApi CollectionPageApi { get; set; }
    public FavoriteApi FavoriteApi { get; set; }
    public ListingzsPageApi ListingzsPageApi { get; set; }

    public static Api GetIns()
    {
        return Instance;
    }
}

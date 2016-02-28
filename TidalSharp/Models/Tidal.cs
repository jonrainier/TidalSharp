using TidalSharp.Controllers;

namespace TidalSharp.Models
{
    public class Tidal
    {
        public Tidal()
        {
        }

        public Tidal(TidalController tidalController)
        {
            TidalController = tidalController;
        }

        // TidalLib.Controllers
        public TidalController TidalController { get; set; }
        // TidalLib.Models
        public AlbumsModel AlbumsModel { get; set; }
        public AlbumTracksModel AlbumTracksModel { get; set; }
        public CountryModel CountryModel { get; set; }
        public FeaturedAlbumsModel FeaturedAlbumsModel { get; set; }
        public LoginModel LoginModel { get; set; }
        public TracksModel TracksModel { get; set; }
        public UsersModel UsersModel { get; set; }
        public UsersSubscriptionsModel UsersSubscriptionsModel { get; set; }
    }
}

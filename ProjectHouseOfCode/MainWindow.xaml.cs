using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectHouseOfCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //UpdateMap();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            FormaLogin formaLogin = new FormaLogin();
            formaLogin.Show();
        }

        private void btnSeePublicPhotos_Click(object sender, RoutedEventArgs e)
        {
            UpdateMap();
        }

        private async void UpdateMap()
        {
            double latitudine = 54.937454;
            double longitudine = 10.707840;
            string flickrApiKey = "02a2c435b2404d448cedcab54b866147";
            int privacy = 1; //poze publice
            int raza = 10;

            //txtPublicPhotos.Text = String.Format("lat: {0} - long: {1} - pe o raza de {2} km", latitudine, longitudine, raza); just for test

            HttpClient client = new HttpClient();
            //https://api.flickr.com/services/rest/?method=flickr.photos.search&api_key=a4813d824488cd70ec403975ee678cbe&text=park&privacy_filter=1&lat=54.937454&lon=10.707840&radius=10&format=json&nojsoncallback=1&api_sig=5ba764520d9e76f0965ddf3a536fa063

            string url = "https://api.flickr.com/services/rest/" + 
                "?method=flickr.photos.search" + 
                "&api_key={0}" +                 
                "&privacy_filter={1}" + 
                "&lat={2}" + 
                "&lon={3}" + 
                "&radius={4}" + 
                "&format=json" + 
                "&nojsoncallback=1";

            var baseUrl = string.Format(url, 
                flickrApiKey,
                privacy,
                latitudine,
                longitudine,
                raza);

            string flickrResult = await client.GetStringAsync(baseUrl);

            //txtPublicPhotos.Text = flickrResult; //just for test
            FlickrRetreievedData apiData = JsonConvert.DeserializeObject<FlickrRetreievedData>(flickrResult);

            if (apiData.stat == "ok")
            {
                foreach (Photo data in apiData.photos.photo)
                {
                    //too retrieve one photo usi this format
                    //http://farm{farmiD}.staticflickr.com/{server-id}/{id}_{secret}{size}.jpg

                    string photoUrl = "http://farm{0}.staticflickr.com/{1}/{2}_{3}_n.jpg";
                    string baseflickrUrl = string.Format(photoUrl,
                        data.farm,
                        data.server,
                        data.id,
                        data.secret);
                    
                    ////Flickr Image control is just an Image control in XAML

                    FlickrImage.Source = new BitmapImage(new Uri(baseflickrUrl));

                    ////just trying to grab 1 photo , no break out of file_
                    break;
                }
            }
        }

        private void btnSeeMyPhotos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSeePhotosMap_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSeeMyProfile_Click(object sender, RoutedEventArgs e)
        {
            //UserID:   161400906@N03    
        }
}

    public class Photo
    {
        public string id { get; set; }
        public string owner { get; set; }
        public string secret { get; set; }
        public string server { get; set; }
        public int farm { get; set; }
        public string title { get; set; }
        public int ispublic { get; set; }
        public int isfriend { get; set; }
        public int isfamily { get; set; }
    }

    public class Photos
    {
        public int page { get; set; }
        public int pages { get; set; }
        public int perpage { get; set; }
        public string total { get; set; }
        public List<Photo> photo { get; set; }
    }

    public class FlickrRetreievedData
    {
        public Photos photos { get; set; }
        public string stat { get; set; }
    }
}

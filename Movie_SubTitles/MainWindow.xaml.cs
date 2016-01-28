using Movie_SubTitles.Core;
using Movie_SubTitles.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Movie_SubTitles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Token { get; set; }

        public XmlRpcClient Client { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Client = new XmlRpcClient();
            txtBxMovieName.Text = @"E:\Films\KingsmanTheSecretService(2014)[1080p]Kingsman.The.Secret.Service.2014.1080p.BluRay.x264.YIFY.mp4";
            this.Loaded += MainWindow_Loaded;
            //new SubMaxClient("http://subsmax.com/api/10/").GetSubtitleAsync("IronMan");
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            SubtitleModels.LoginStruct result = Client.login(string.Empty, string.Empty, "en", "");

            if (!string.IsNullOrEmpty(result.token))
                Token = result.token;


        }

        private async void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxMovieName.Text))
                return;

            SubtitleModels.subtitleStuct mystruct = new SubtitleModels.subtitleStuct
            {
                moviehash = MovieHasher.ComputeMovieHash(txtBxMovieName.Text).ToString(),
                //moviebytesize  =
                sublanguageid = "eng",
            };

            var arry = new SubtitleModels.subtitleStuct[1];
            arry[0] = mystruct;

            var result = await Task.Run(() => Client.SearchSubtitles(Token, arry));


            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("We have found {0} subtitles", result.data.Count()));
            foreach (var item in result.data)
            {
                sb.AppendLine(item.SubFileName.ToString());
            }


            MessageBox.Show(sb.ToString());
        }
    }
}

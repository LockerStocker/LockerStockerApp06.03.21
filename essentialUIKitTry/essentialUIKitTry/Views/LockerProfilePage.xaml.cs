using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace essentialUIKitTry.Views
{
    /// <summary>
    /// Page to show chat profile page
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LockerProfilePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockerProfilePage" /> class.
        /// </summary>
        public LockerProfilePage()
        {
            this.InitializeComponent();
            this.ProfileImage.Source = App.ImageServerPath + "ProfileImage11.png";
        }
        void Navigate_To_Photo(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new InsideALockerImage());
        }
    }
}
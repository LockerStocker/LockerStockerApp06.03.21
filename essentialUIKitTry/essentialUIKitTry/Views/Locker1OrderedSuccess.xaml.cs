using essentialUIKitTry.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace essentialUIKitTry.Views
{
    /// <summary>
    /// Page to show the payment success.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Locker1OrderedSuccess : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Locker1OrderedSuccess" /> class.
        /// </summary>
        public Locker1OrderedSuccess()
        {
            this.InitializeComponent();
            this.BindingContext = PaymentViewModel.BindingContext;
        }
        void OrderProfileClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LockerProfilePage());
        }
    }
}
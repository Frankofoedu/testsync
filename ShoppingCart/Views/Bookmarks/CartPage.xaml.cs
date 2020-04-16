using ShoppingCart.DataService;
using ShoppingCart.DependencyServices;
using ShoppingCart.ViewModels.Bookmarks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using TypeLocator = ShoppingCart.MockDataService.TypeLocator;

namespace ShoppingCart.Views.Bookmarks
{
    /// <summary>
    /// Page to show the cart list.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage
    {
        private bool fin;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartPage" /> class.
        /// </summary>
        public CartPage()
        {
            InitializeComponent();
            var cartDataService = App.MockDataService
                ? TypeLocator.Resolve<ICartDataService>()
                : DataService.TypeLocator.Resolve<ICartDataService>();
            BindingContext = new CartPageViewModel(cartDataService);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var audServ = DependencyService.Get<IAudioPlayerService>();

            audServ.Play("6.3gpp");

            audServ.OnFinishedPlaying = () =>
            {
                if (!fin)
                {
                    fin = true;
                    audServ.Play("7.3gpp");
                }
            };
        }
    }
}
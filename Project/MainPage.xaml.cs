using Android.App;
using Android.Media;

namespace Project
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Rathalos(object sender, EventArgs e)
        {
           Navigation.PushAsync(new Rathalos());
        }
        private async void Rathian(object sender, EventArgs e)
        {
           Navigation.PushAsync(new Rathian());
        }

        private void Fatalis(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fatalis());
        }

        private void Kushala(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Kushala());
        }

        private void Nargacuga(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nargacuga());
        }

        private void Tigrex(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Tigrex());
        }

        private void Diablos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Diablos());
        }

        private void Rajang(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Rajang());
        }

        private void Lagiacrus(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Lagiacrus());
        }

        private void Zinogre(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Zinogre());
        }

        private void Barioth(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Barioth());
        }

        private void Deviljho(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Deviljho());
        }

        private void Mizutsune(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Mizutsune());
        }

        private void Brachydios(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Brachydios());
        }

        private void Glavenus(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Glavenus());
        }

        private void Nergigante(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nergigante());
        }

        private void Velkhana(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Velkhana());
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCar {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicial : ContentPage {
        public Inicial() {
            InitializeComponent();
        }

        private async void BtnSair_ClickedAsync(object sender, EventArgs e) {
            await Navigation.PushAsync(new MainPage());
        }

        private async void BtnAdicionar_ClickedAsync(object sender, EventArgs e) {
            await Navigation.PushAsync(new AdicionarVeiculo());
        }

        private async void BtnEditar_Clicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new EditarCadastro());
        }

        private async void BtnGerenciar_ClickedAsync(object sender, EventArgs e) {
            await Navigation.PushAsync(new EditarCadastro());
        }

    }
}
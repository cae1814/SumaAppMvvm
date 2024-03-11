using SumaAppMvvm.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SumaAppMvvm.Models;

namespace SumaAppMvvm.ViewModels
{
    internal partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _n1;

        [ObservableProperty]
        private double _n2;

        [ObservableProperty]
        private double _total;

        [RelayCommand]
        private void Calcular()
        {
            try
            {
                Operaciones op = new Operaciones();
                op.Num1 = N1;
                op.Num2 = N2;

                Total = op.TotalSuma(N1, N2);
                MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("Aviso", "El total de la suma es "+ Total, "Aceptar"));
            } catch (Exception ex) {
                MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", ex.Message, "Aceptar"));
            }
        }
        
        [RelayCommand]
        private void Limpiar()
        {
            N1 = 0;
            N2 = 0;
            Total = 0;
        }
    }
}

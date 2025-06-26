using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace ExamenMvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] private decimal producto1;
        [ObservableProperty] private decimal producto2;
        [ObservableProperty] private decimal producto3;
        [ObservableProperty] private decimal subtotal;
        [ObservableProperty] private decimal descuento;
        [ObservableProperty] private decimal total;

        [RelayCommand] private void Calcular()
        {
            subtotal = producto1 + producto2 + producto3;

            if (subtotal < 1000)
                descuento = 0;
            else if (subtotal < 5000)
                descuento = subtotal * 0.10m;
            else if (subtotal < 10000)
                descuento = subtotal * 0.20m;
            else
                descuento = subtotal * 0.30m;

            total = subtotal - descuento;
        }
        [RelayCommand] private void Limpiar ()
        {
            producto1 = 0;
            producto2 = 0;
            producto3 = 0;
            subtotal = 0;
            descuento = 0;
            total = 0;
        }
    }
}
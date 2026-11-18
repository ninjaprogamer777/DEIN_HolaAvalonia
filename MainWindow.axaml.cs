using Avalonia.Controls;
using Avalonia.Media;
using Avalonia;
using Avalonia.Interactivity;

namespace HolaAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Title = "Ventana Principal";
        saludo.Text = "Hola, soy Amador";
        saludo.Foreground = Brushes.Crimson;

        var extra = new Button
        {
            Content = "Botón creado en C#",
            Margin = new Thickness(0, 10, 0, 0)
        };

        panel.Children.Add(extra);

        boton.Click += Boton_Click;
        
        


    }

    private void Boton_Click(object? sender, RoutedEventArgs e)
    {
        saludo.Text = "Botón presionado :)";
    }

    


}
using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia;

namespace MessageDialogExample;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        await MessageBoxManager.GetMessageBoxStandard("Сообщение", "Welcome to Avalonia!", 
            windowStartupLocation: WindowStartupLocation.CenterOwner).ShowAsync();
    }

    private async void Button_OnClick2(object? sender, RoutedEventArgs e)
    {
       TextBox textBox = new();

       await MessageBoxManager.GetMessageBoxStandard("ввод имени", "Введите имя:",
           icon: MsBox.Avalonia.Enums.Icon.Question, context: textBox, windowStartupLocation: 
           WindowStartupLocation.CenterOwner).ShowAsync();

       if (textBox.Text?.Length > 0)
       {
           await MessageBoxManager.GetMessageBoxStandard("Вывод приветствия", $"Привет, {textBox.Text}", 
               windowStartupLocation: WindowStartupLocation.CenterOwner).ShowAsync();
       }
    }
}
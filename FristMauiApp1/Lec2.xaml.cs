namespace FristMauiApp1;

public partial class Lec2 : ContentPage
{
    public Lec2()
    {
        InitializeComponent();
    }

    private void btnWelcome_Click(object sender, EventArgs e)
    {   
        DisplayAlert("Title", $"Hello {txtName.Text}", "OK");
    }
}
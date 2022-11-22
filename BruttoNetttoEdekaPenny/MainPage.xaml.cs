namespace BruttoNetttoEdekaPenny;

public partial class MainPage : ContentPage
{
    Label label1;
    Label label2;
    Button button;
    Entry entry;

    public MainPage()
    {
        InitializeComponent();

        button = new Button();
        button.Text = "Berechnen";

        TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += Button_Tap;
        button.GestureRecognizers.Add(tapGestureRecognizer);


        label1 = new Label();
        label1.Text = "Bruttolohn";
         
        label2 = new Label();
        label2.Text = string.Empty;

        entry = new Entry();
        entry.Placeholder = "Bruttolohn eingeben";

        StackLayout views = new StackLayout();

        views.Children.Add(label1);
        views.Children.Add(entry);
        views.Children.Add(label2);
        views.Children.Add(button);

        Content = views;

    }

    private void Button_Tap(object sender, TappedEventArgs e)
    {
        double ergebnis = double.Parse(entry.Text) * 0.45;
        label2.Text = "Nettolohn: " + ergebnis.ToString();
    }

}


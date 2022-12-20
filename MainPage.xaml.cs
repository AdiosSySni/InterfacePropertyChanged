using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Memories> people { get; set; }
    public Memories MM { get; set; }

    public MainPage()
	{
        //MM = new Memories();

        people = new ObservableCollection<Memories>();
        people.Add(new Memories("Илья", "Васькин", "Владимирович", "dotnet_bot.png"));
        people.Add(new Memories("Пауль", "Гегель", "Викторович", "dotnet_bot.png"));
  
        InitializeComponent();

        BindingContext = this;
    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {

        Picker.SetBinding(Picker.SelectedItemProperty, "MM");
        //Test.SetBinding(Label.TextProperty, "MM.Name");

        EntryName.SetBinding(Entry.TextProperty, "MM.Name");
        LabelName.SetBinding(Label.TextProperty, "MM.Name");

        EntrySurname.SetBinding(Entry.TextProperty, "MM.Surname");
        LabelSurname.SetBinding(Label.TextProperty, "MM.Surname");

        EntryPatronymic.SetBinding(Entry.TextProperty, "MM.Patronymic");
        LabelPatronymic.SetBinding(Label.TextProperty, "MM.Patronymic");

        EntrySource.SetBinding(Entry.TextProperty, "MM.Source");
        Image.SetBinding(Image.SourceProperty, "MM.Source");




    }
}


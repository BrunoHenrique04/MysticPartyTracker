namespace MysticPartyTracker.View;
using MysticPartyTracker.Models;
using MysticPartyTracker.ViewModels;

public partial class SpellsView : ContentPage
{
	public SpellsView()
	{
		InitializeComponent();
		BindingContext = new SpellsViewModel();

    }
}
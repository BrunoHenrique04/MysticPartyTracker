using MysticPartyTracker.ViewModels;
using MysticPartyTracker.Models;

namespace MysticPartyTracker.View;

public partial class CharacterView : ContentPage
{
	public CharacterView()
	{
        InitializeComponent();
        BindingContext = new CharcterViewModel();
    }


}
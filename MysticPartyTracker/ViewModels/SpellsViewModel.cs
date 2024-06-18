using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.VisualBasic;
using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    internal class SpellsViewModel : ObservableObject
    {
        private readonly RestService _restService;

        [ObservableProperty]
        private ObservableCollection<Spells> _spell = new ObservableCollection<Spells>();


        public SpellsViewModel()
        {
            _restService = new RestService();
            GetSpellsAsyncCommand = new Command(async () => await GetSpellsAsync());
        }

        public ICommand GetSpellsAsyncCommand { get; }

        public async Task GetSpellsAsync()
        {
            Spell = await _restService.GetSpellsAsync();

        }

    }
}


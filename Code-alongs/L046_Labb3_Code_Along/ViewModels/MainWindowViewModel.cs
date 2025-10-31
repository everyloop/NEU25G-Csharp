using L046_Labb3_Code_Along.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L046_Labb3_Code_Along.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<QuestionPackViewModel> Packs { get; } = new();

		private QuestionPackViewModel _activePack;
			
		public QuestionPackViewModel ActivePack
		{
			get => _activePack;
			set { 
				_activePack = value;
				RaisePropertyChanged();
                PlayerViewModel?.RaisePropertyChanged(nameof(PlayerViewModel.ActivePack));
			}
		}

        public PlayerViewModel? PlayerViewModel { get; }
        public ConfigurationViewModel? ConfigurationViewModel { get; }
        public MainWindowViewModel()
        {
            PlayerViewModel = new PlayerViewModel(this);
            ConfigurationViewModel = new ConfigurationViewModel(this);

            var pack = new QuestionPack("Mina frågor");
            ActivePack = new QuestionPackViewModel(pack);
            ActivePack.Questions.Add(new Question($"Vad är 1+1", "2", "3", "1", "4"));
            ActivePack.Questions.Add(new Question($"Vad heter sveriges huvudstad?", "Stockholm", "Oslo", "London", "Göteborg"));
        }

    }
}

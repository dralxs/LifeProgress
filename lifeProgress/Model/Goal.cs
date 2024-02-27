using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LifeProgress.Model
{
    public enum Difficulties
    {
        VeryEasy,
        Easy,
        Medium,
        Hard,
        VeryHard
    }

    public class Goal : INotifyPropertyChanged
    {
        private string _name;

        public Goal(string name)
        {
            _name = name;
        }

        private Difficulties _difficulty;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public Difficulties Difficulty
        {
            get => _difficulty;
            set
            {
                _difficulty = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        // Notify the binding that the property has changed
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

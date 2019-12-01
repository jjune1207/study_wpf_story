using System;

namespace _01.StringFormat.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private DateTime _currentTime;
        public DateTime CurrentTime
        {
            get { return _currentTime; }
            set { SetProperty(ref _currentTime, value); }
        }

        private int _currentBudget;
        public int CurrentBudget
        {
            get { return _currentBudget; }
            set { SetProperty(ref _currentBudget, value); }
        }

        public MainViewModel()
        {
            CurrentTime = DateTime.Now;
            CurrentBudget = 1000;
        }

    }
}

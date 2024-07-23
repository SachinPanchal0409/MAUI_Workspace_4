using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Threading;

namespace MAUIProject.ViewModels
{
    public partial class ButtonViewModel : INotifyPropertyChanged
    {
        private int _age;
       
        private bool _isAgeValid;
        private bool _isVisibleRadioButtons;

        public int Age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged(nameof(Age));


                    ValidateAge();
                }
            }
        }
       
        public bool IsAgeValid
        {
            get { return _isAgeValid; }
            set
            {
                if (_isAgeValid != value)
                {
                    _isAgeValid = value;
                    OnPropertyChanged(nameof(IsAgeValid));
                }
            }
        }

        public bool IsVisibleRadioButtons
        {
            get { return _isVisibleRadioButtons; }
            set
            {
                if (_isVisibleRadioButtons != value)
                {
                    _isVisibleRadioButtons = value;
                    OnPropertyChanged(nameof(IsVisibleRadioButtons));
                }
            }
        }

        public ButtonViewModel()
        {

            Age = 0;
            ValidateAge();
           
        }

        private void ValidateAge()
        {

            IsAgeValid = Age >= 18;


            SubmitButtonEnabled = IsAgeValid;
           
        }

        private bool _submitButtonEnabled;
        public bool SubmitButtonEnabled
        {
            get { return _submitButtonEnabled; }
            set
            {
                if (_submitButtonEnabled != value)
                {
                    _submitButtonEnabled = value;
                    OnPropertyChanged(nameof(SubmitButtonEnabled));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        [RelayCommand]
        public void ShowRadioButtons()
        {
            IsVisibleRadioButtons = true;
        }
        [RelayCommand]
        public void VoteSubmit()
        {
            Toast.Make("Vote Submitted!",
                  ToastDuration.Long,
           16)
            .Show();
            IsVisibleRadioButtons = false;
        }
    }
}

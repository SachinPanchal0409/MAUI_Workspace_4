using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MAUIProject.ViewModels
{
    public partial class ProgressBarViewModel : ObservableObject
    {
        [ObservableProperty]
        public double progressValue;

        [ObservableProperty]
        public string percentageText;

   

        private System.Timers.Timer _timer;
        public ProgressBarViewModel()
        {
            this.progressValue = 0.001;
            this.percentageText = "0%";
           
            
        }

        [RelayCommand]
        public void ProgressBarValue()
        { 
            _timer = new System.Timers.Timer(0.001);
            _timer.Elapsed += async (sender, e) =>  ProgressBarFunction();
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        public void ProgressBarFunction()
        {
            ProgressValue += 0.001;
            PercentageText = $"{(int)(ProgressValue * 100)}%";
            if ((int)ProgressValue == 1)
            {
                _timer.Enabled = false;
                _timer.AutoReset = false;
                _timer.Stop();
            }
        }
    }
}

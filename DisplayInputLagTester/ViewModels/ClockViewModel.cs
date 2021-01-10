using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;
using Prism.Commands;

namespace DisplayInputLagTester.ViewModels
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        private readonly DispatcherTimer  _timer;

        public ClockViewModel()
        {
            Stopwatch = new Stopwatch();
            _timer = new DispatcherTimer();
            _timer.Tick += OnTimerTick;

            StartCommand = new DelegateCommand(Start);
            StopCommand = new DelegateCommand(Stop);
            ResetCommand = new DelegateCommand(Reset);
        }
        public Stopwatch Stopwatch { get; init; }
        public ICommand StartCommand { get; init; }
        public ICommand StopCommand { get; init; }
        public ICommand ResetCommand { get; init; }

        public void Start()
        {
            Stopwatch.Start();
            _timer.Start();
        }

        public void Stop()
        {
            Stopwatch.Stop();
            _timer.Stop();
        }

        public void Reset()
        {
            Stopwatch.Restart();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Stopwatch)));
        }

        private void OnTimerTick(object sender, object e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Stopwatch)));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

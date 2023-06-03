using System;
using System.Diagnostics;
using System.Windows.Input;
using Microsoft.Maui.Networking;
using tuRecomendacion.Model;

namespace tuRecomendacion.ViewModels
{
    [QueryProperty(nameof(QuestionModel), "QuestionModel")]
    public class QuestionsViewModel : BaseViewModel
    {
        private QuestionModel _questionModel;
        IConnectivity connectivity;
        IGeolocation geolocation;

        [ObservableProperty]
        public QuestionModel QuestionModel
        {
            get => _questionModel;
            set
            {
                _questionModel = value;
                OnPropertyChanged(nameof(QuestionModel));
            }
        }

        public ICommand OnOpenCommand { get; private set; }

        public QuestionsViewModel(IConnectivity connectivity, IGeolocation geolocation)
		{
            OnOpenCommand = new Command(OnOpen);
            this.connectivity = connectivity;
            this.geolocation = geolocation;
        }

        private async void OnOpen()
        {
            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("No connectivity!",
                    $"Please check internet and try again.", "OK");
                return;
            }

            try
            {
                // Get cached location, else get real location.
                var location = await geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    });
                }

                // Find closest monkey to us
                

                await Shell.Current.DisplayAlert("", QuestionModel.Title, "OK");

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to query location: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
        }
    }
}


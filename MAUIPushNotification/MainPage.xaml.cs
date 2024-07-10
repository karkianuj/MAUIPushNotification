namespace MAUIPushNotification
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private string _deviceToken;
        public MainPage()
        {
            InitializeComponent();
            if (Preferences.ContainsKey("DeviceToken"))
            {
                _deviceToken = Preferences.Get("DeviceToken", "");
            }
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(_deviceToken);
        }
    }

}

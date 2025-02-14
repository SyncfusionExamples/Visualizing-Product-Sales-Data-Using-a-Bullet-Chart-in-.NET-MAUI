namespace BulletChartSample
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF1cWWhLYVFxWmFZfVtgdVdMYVlbRXFPMyBoS35Rc0VhWH5ecHRTQmZcVk1w");
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage());
        }
    }
}
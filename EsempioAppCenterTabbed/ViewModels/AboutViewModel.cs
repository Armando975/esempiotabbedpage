using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Windows.Input;

using Xamarin.Forms;

namespace EsempioAppCenterTabbed.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {

            try
            {
                Title = "About";
                //Crashes.GenerateTestCrash();
                OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
            }
            catch (Exception ex)
            {
                var dati = new Dictionary<string, string> { { "Nome","Armando"} };
                Crashes.TrackError(ex);
            }
            
        }

        public ICommand OpenWebCommand { get; }
    }
}
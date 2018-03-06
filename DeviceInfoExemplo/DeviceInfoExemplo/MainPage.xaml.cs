using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.DeviceInfo;

namespace DeviceInfoExemplo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            this.Content = new StackLayout
            {
                Padding = 50,
                VerticalOptions = LayoutOptions.Center,
                Children = {
                          new Label{ Text = "Id: " + CrossDeviceInfo.Current.Id},
                          new Label{ Text = "Modelo: " + CrossDeviceInfo.Current.Model},
                          new Label{ Text = "Plataforma: " + CrossDeviceInfo.Current.Platform},
                          new Label{ Text = "Versão: " + CrossDeviceInfo.Current.Version},
                          new Label{ Text = "Numero da Versão: " + CrossDeviceInfo.Current.VersionNumber},
                          new Label{ Text = "Rodando no Device?: " + CrossDeviceInfo.Current.IsDevice},
                    }
            };

        }
	}
}

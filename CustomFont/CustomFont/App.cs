using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CustomFont
{
    public class App : Application
    {
        public App()
        {
            var myLabel = new MyLabel
            {
                Text = Device.OnPlatform(
                    "Label in iOS!",
                    "Label in Android!",
                    "Label in Windows Phone!"
                ),
                FontFamily = Device.OnPlatform(
                    "SF Hollywood Hills",
                    null,
                    @"\Assets\Fonts\SF Hollywood Hills.ttf#SF Hollywood Hills"
                ),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            myLabel.FontSize = Device.OnPlatform(
                25,
                Device.GetNamedSize(NamedSize.Medium, myLabel),
                Device.GetNamedSize(NamedSize.Large, myLabel)
                );


            // The root page of your application
            MainPage = new ContentPage
            {

                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
						myLabel
					}
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

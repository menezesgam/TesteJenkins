using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TesteMqtt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class MainPage : Page
    {

        private class Movie
        {
            public string Name;
            public List<String> Genres;
        }

        private Movie curMovie;

        string json = @"{
  'Name': 'Bad Boys',
  'Genres': [
    'Action',
    'Comedy'
  ]
}";
        public MainPage()
        {
            this.InitializeComponent();
            curMovie = JsonConvert.DeserializeObject<Movie>(json);
            IPAddress ip = IPAddress.Parse("85.119.83.194");
            MqttClient client = new MqttClient("85.119.83.194");
            client.MqttMsgPublishReceived += new MqttClient.MqttMsgPublishEventHandler(EventPublished);
            client.Connect("mosquitto_sub");
            client.Subscribe(new string[] { "test_topic_1" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }

        private async void EventPublished(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            curMovie = JsonConvert.DeserializeObject<Movie>(Encoding.UTF8.GetString(e.Message));
            string printString = "\n\nName: " + curMovie.Name;
            foreach (string s in curMovie.Genres)
            {
                printString += "\n\nGenre: " + s;
            }
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () => { this.TextCallback.Text = printString; });
        }

    }
}

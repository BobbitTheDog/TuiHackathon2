using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

using PubnubApi;
using HackathonFramework;

namespace PassengerLocationMonitor
{
    public partial class passengerLocationForm : Form
    {
        Pubnub pubnub;

        Dictionary<PassengerLocation, ListBox> listBoxes;

        public passengerLocationForm()
        {
            PNConfiguration config = new PNConfiguration();
            config.SubscribeKey = "sub-c-99728d5c-8be0-11e7-8512-8a1cdbfa3414";
            config.PublishKey = "pub-c-fcc551f8-e994-47f4-bub-c-99728d5c-8be0-11e7-8512-8a1cdbfa34604-22922ec783a4";
            pubnub = new Pubnub(config);
            pubnub.AddListener(new SubscribeCallbackExt(
                (pubnubObj, message) => HandlePubnub(pubnubObj, message), null, null));

            pubnub.Subscribe<string>()
                .Channels(new string[]
                {
                    "teams[0]"
                })
                .Execute();

            InitializeComponent();

            listBoxes = new Dictionary<PassengerLocation, ListBox>
            {
                { PassengerLocation.Onboard, lstOnBoard },
                { PassengerLocation.OnCoach, lstOnCoach},
                { PassengerLocation.OnExcursion, lstOnExcursion},
                { PassengerLocation.Disembarked, lstDisembarked}
            };
        }

        private void HandlePubnub(Pubnub pubnubObj, PNMessageResult<object> message)
        {
            // Handle new message stored in message.Message
            if (message != null)
            {
                if (message.Channel != null)
                {
                    // Message has been received on channel group stored in
                    // message.Channel()
                    LocationData messageData = JsonConvert.DeserializeObject<LocationData>(message.Message.ToString());

                    PassengerLocation location;
                    if (!Enum.TryParse<PassengerLocation>(messageData.Sensor, out location))
                    {

                    }

                    SqlTasks.UpdatePassengerLocation(messageData.Tag, location);

                    this.Invoke((MethodInvoker)(() => MovePassenger(messageData.Tag, location)));
                }
                else
                {
                    // Message has been received on channel stored in
                    // message.Subscription()
                }

                /*
                    log the following items with your favorite logger
                        - message.Message()
                        - message.Subscription()
                        - message.Timetoken()
                */
            }
        }

        private void MovePassenger(string name, PassengerLocation location)
        {
            listBoxes
                .Select(dict => dict.Value).ToList()
                .ForEach(lst =>
                    lst.Items.Remove(name)
                );

            listBoxes[location].Items.Add(name);
        }
    }
}

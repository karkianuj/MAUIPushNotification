using Shiny.Push;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIPushNotification
{
    public class PushDelegate : IPushDelegate
    {

        public async Task OnNewToken(string token)
        {
            // fires when a push registration token change is set by the operating system or provider
            // also fires with RequestAccess value changes (or initial request)
        }


        public async Task OnUnRegistered(string token)
        {
            // fires when IPushManager.UnRegister is called
            // or on startup when permissions are denied to push
        }

        public async Task OnEntry(PushNotification notification)
        {
            //
            //
        }

        public async Task OnReceived(PushNotification notification)
        {
            //
            //
        }
    }
}

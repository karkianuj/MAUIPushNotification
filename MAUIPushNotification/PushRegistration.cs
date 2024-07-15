using Shiny.Hosting;
using Shiny.Push;
using Shiny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIPushNotification
{
    public class PushRegistration
    {
        public async Task CheckPermission()
        {
            var push = Host.Current.Services.GetService<IPushManager>();
            var result = await push.RequestAccess();
            if (result.Status == AccessState.Available)
            {
                // good to go

                // you should send this to your server with a userId attached if you want to do custom work
                var value = result.RegistrationToken;
            }
        }
    }
}

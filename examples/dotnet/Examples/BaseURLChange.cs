using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Realms;
using Realms.Sync;
using Realms.Sync.Exceptions;
using Realms.Sync.Testing;
using Realms.Logging;
using System.Threading;
// var user = await app.LogInAsync(Credentials.Anonymous());

// var config = new FlexibleSyncConfiguration(app.user);

// var newUri = new Uri();
// app.updateBaseUriAsync(newUri);

// await user.LogOutAsync();

////// NEW START
///

namespace Examples
{
    public class BaseURLChange
    {
        [Test]

        public async Task testEdgeAppWithCustomBaseURL()
        {
            var edgeServerAppId = "edge-server-tester-kwbrfuo";

            var appConfig = new AppConfiguration(edgeServerAppId);
            appConfig.BaseUri = new Uri("http://localhost:80");

            var app = App.Create(appConfig);

            try {
                var user = await app.LogInAsync(Credentials.Anonymous());
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }


    }
}





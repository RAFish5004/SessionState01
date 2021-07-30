// ===========================================
// ContextTry.cs, 210514
// Author: Russell Fisher
//   experiment with HttpContext class and other details
// *NotImplementedException exception should be synonymous with "still in development."
// https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception?view=net-5.0#:~:text=The%20NotImplementedException%20exception%20is%20thrown%20when%20a%20particular,the%20default%20Object.Equals%20implementation%2C%20which%20supports%20reference%20equality.
// ===========================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace SessionState01.Models
{
    public class ContextTry : HttpContext // ------------------------------------------------------
    {
        // explicitly implemented methods and properties =====================================
        // all members override the HttpContext reference, which is an abstract class
        

        public override IFeatureCollection Features => throw new NotImplementedException();

        public override HttpRequest Request => throw new NotImplementedException();

        public override HttpResponse Response => throw new NotImplementedException();

        public override ConnectionInfo Connection => throw new NotImplementedException();

        public override WebSocketManager WebSockets => throw new NotImplementedException();

        public override ClaimsPrincipal User { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IDictionary<object, object> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IServiceProvider RequestServices { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override CancellationToken RequestAborted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string TraceIdentifier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ISession Session { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Abort()
        {
            throw new NotImplementedException();
        }
        // eo explicitly implimented members from HttpContext ---------------------------------------

    } // eo SesstionTry class ---------------------------------------------------------------------
} // eo namespace

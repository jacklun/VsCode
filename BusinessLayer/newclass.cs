using System;
using System.Configuration;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Configuration;

namespace WebEditor.BusinessLayer {
    public class newclass : Microsoft.AspNetCore.Session.ISessionStore {
        public void sss () {
            //Microsoft.AspNetCore.Session.ISessionStore.
        }
        public Microsoft.AspNetCore.Http.ISession Create (string sessionKey, TimeSpan idleTimeout, TimeSpan ioTimeout, Func<bool> tryEstablishSession, bool isNewSessionKey) {
            
            return null;
        }
    }
}
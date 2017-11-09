using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace TechnicalTests
{
    public class RaceCondition
    {
        private static readonly Dictionary<string, object> _lockDictionary = new Dictionary<string,object>();

        private readonly ISessionManager _sessionManager;

        public RaceCondition(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }

        public void UpdateSession(string sessionKey)
        {
            // A simple lock won't do, lets use a simple lock dictionary
            if (!_lockDictionary.ContainsKey(sessionKey))
            {
                _lockDictionary.Add(sessionKey, new object());
            }

            // Then we have key dependant locking, happy days
            // Unless, this is completely wrong, then, unhappy days
            lock (_lockDictionary[sessionKey])
            {
                var session = _sessionManager.Get(sessionKey);
                session.Count += 1;
                _sessionManager.Set(session);
            }


        }
    }
}

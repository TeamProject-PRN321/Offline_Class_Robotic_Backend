using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.BuisnessObject.ConvertTer
{
    public static class CustomSessionManager
    {
        private static Dictionary<string, string> sessionData = new Dictionary<string, string>();

        public static void SetString(string key, string value)
        {
            var sessionKey = GetSessionKey(key);
            if (sessionData.ContainsKey(sessionKey)) {
                sessionData[sessionKey] = value;
            }
            else {
                sessionData.Add(sessionKey, value);
            }
        }

        public static string GetString(string key)
        {
            var sessionKey = GetSessionKey(key);
            var data = sessionData.GetValueOrDefault(sessionKey);
            if (data != null) {
                return data;
            }
            return string.Empty;
        }

        private static string GetSessionKey(string key)
        {
            return $"{key}";
        }
    }
}

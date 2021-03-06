﻿using System.Threading.Tasks;
using Cobalt.Settings.Elements;
using Newtonsoft.Json;

namespace Cobalt.Settings.Serializers
{
    internal class JsonSettingsSerializer : ISettingsSerializer
    {
        public async Task<string> SerializeAsync(SettingsElement rootElement)
        {
            return await Task.Run(() => Serialize(rootElement));
        }

        public string Serialize(SettingsElement rootElement)
        {            
            return JsonConvert.SerializeObject(rootElement);
        }

        public SettingsElement Deserialize(string data)
        {
            return JsonConvert.DeserializeObject<SettingsElement>(data);
        }

        public async Task<SettingsElement> DeserializeAsync(string data)
        {
            return await Task.Run(() => Deserialize(data));
        }

        public string GetFileExtension()
        {
            return "json";
        }
    }
}

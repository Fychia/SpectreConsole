using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectreConsole
{
    internal class AppSettings
    {
        public string DefaultConnection { get; set; } = "";

        public static async Task <AppSettings> Read()
        {
            var appSettings = await System.IO.File.ReadAllTextAsync("appSettings.json");

            return System.Text.Json.JsonSerializer.Deserialize<AppSettings>(appSettings);
        }

    }
}

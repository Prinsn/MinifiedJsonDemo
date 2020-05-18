using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace MinifiedSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var objs = new List<BaseRercursable>
            {
                new ThickRecurseable("demo dumb pattern to initialize with a single child"),
                new ThinRecurseable("ditto"),
                new MinRecurseable("^")
            };

            //Leaving formatting for clarity
            var normalSerial = new JsonSerializerSettings() {
                Formatting = Formatting.Indented
            };
            var noDefaults = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate
            };

            var at = Path.Combine(Directory.GetCurrentDirectory(), "output");

            System.IO.Directory.CreateDirectory(at);

            var normal = Path.Combine(at, "normal.json");
            using (var fr = new StreamWriter(normal))
            {
                var json = JsonConvert.SerializeObject(objs, normalSerial);
                fr.Write(json);
            }

            var noDefault = Path.Combine(at, "no_default.json");
            using (var fr = new StreamWriter(noDefault))
            {
                var json = JsonConvert.SerializeObject(objs, noDefaults);
                fr.Write(json);
            }

            System.Diagnostics.Process.Start("explorer.exe", at);
        }
    }
}

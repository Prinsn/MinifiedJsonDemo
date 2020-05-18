using Newtonsoft.Json;
using System;

/// <summary>
/// https://stackoverflow.com/a/14428145/2489966
/// </summary>
namespace MinifiedSerializer
{
    public class BoolConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // Note from source: Depending on the situation, you may also need bool? in CanConvert
            writer.WriteValue(((bool)value) ? 1 : 0);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.Value.ToString() == "1";
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool);
        }
    }

}

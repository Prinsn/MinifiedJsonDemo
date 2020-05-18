using Newtonsoft.Json;

namespace MinifiedSerializer
{
    //Prevents anything not explicitly tagged as a JsonProperty from being serialized
    //NOTE: Attributes are inheritable
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class BaseRercursable
    {
        public abstract int IntegerField { get; set; }
        /// <summary>
        /// From source: And is there possibly a way to apply this custom converter to all bool properties throughout all objects without adding JsonConverter attributes?
        /// Worth looking into
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public abstract bool TrueFalse { get; set; }
        public abstract BaseRercursable RecurseableObjectDefinition { get; set; }
        public abstract string NullAllowedString { get; set; }

        public bool NeverSerializeThis { get; set; }
    }
}

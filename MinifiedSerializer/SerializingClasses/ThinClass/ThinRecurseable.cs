using Newtonsoft.Json;

namespace MinifiedSerializer
{
    public class ThinRecurseable : BaseRercursable
    {
        public ThinRecurseable() { }

        public ThinRecurseable(object any)
        {
            RecurseableObjectDefinition = new ThinRecurseable();
        }

        [JsonProperty("int")]
        public override int IntegerField { get; set; }
        [JsonProperty("bool")]
        public override bool TrueFalse { get; set; }
        [JsonProperty("child")]
        public override BaseRercursable RecurseableObjectDefinition { get; set; }
        [JsonProperty("str")]
        public override string NullAllowedString { get; set; } 
    }
}

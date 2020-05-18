using Newtonsoft.Json;

/// <summary>
/// Can only use constants in attributes unless you're doing some build jankiness that I am only vaguely aware of
/// </summary>
public class MinifiedReferences
{
    public const string INTEGER_FIELD = "i";
    public const string TRUE_FALSE_FIELD = "t";
    public const string RECURSE_FIELD = "r";
    public const string STRING_FIELD = "s";
}

namespace MinifiedSerializer
{
    public class MinRecurseable : BaseRercursable
    {
        public MinRecurseable() { }

        public MinRecurseable(object nonNulls)
        {
            RecurseableObjectDefinition = new MinRecurseable();
        }        

        [JsonProperty(MinifiedReferences.INTEGER_FIELD)]
        public override int IntegerField { get; set; }
        [JsonProperty(MinifiedReferences.TRUE_FALSE_FIELD)]
        public override bool TrueFalse { get; set; }
        [JsonProperty(MinifiedReferences.RECURSE_FIELD)]
        public override BaseRercursable RecurseableObjectDefinition { get; set; }
        [JsonProperty(MinifiedReferences.STRING_FIELD)]
        public override string NullAllowedString { get; set; } 
    }
}

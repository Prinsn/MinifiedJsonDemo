using Newtonsoft.Json;

namespace MinifiedSerializer
{    
    [JsonObject(MemberSerialization.OptOut)]
    public class ThickRecurseable : BaseRercursable
    {
        public ThickRecurseable() { }

        public ThickRecurseable(object any)
        {
            RecurseableObjectDefinition = new ThickRecurseable();
        }

        public override int IntegerField { get; set; }
        public override bool TrueFalse { get; set; }
        public override BaseRercursable RecurseableObjectDefinition { get; set; }
        //Will serialize because this file is opt out
        public override string NullAllowedString { get; set; } 
    }
}

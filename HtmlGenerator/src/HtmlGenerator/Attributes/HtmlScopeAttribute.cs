namespace HtmlGenerator
{
    public class HtmlScopeAttribute : HtmlAttribute 
    {
        internal HtmlScopeAttribute() : base("scope", "Scope", null, false) 
        {
        }

        internal HtmlScopeAttribute(string value) : base("scope", "Scope", value, false) 
        {
        }
    }
}

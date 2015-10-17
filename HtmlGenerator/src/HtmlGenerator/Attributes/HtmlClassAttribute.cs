namespace HtmlGenerator
{
    public class HtmlClassAttribute : HtmlAttribute 
    {
        internal HtmlClassAttribute() : base("class", "Class", null, false) 
        {
        }

        internal HtmlClassAttribute(string value) : base("class", "Class", value, false) 
        {
        }
    }
}

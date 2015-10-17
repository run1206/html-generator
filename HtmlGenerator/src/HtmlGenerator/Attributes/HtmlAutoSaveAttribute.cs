namespace HtmlGenerator
{
    public class HtmlAutoSaveAttribute : HtmlAttribute 
    {
        internal HtmlAutoSaveAttribute() : base("autosave", "AutoSave", null, false) 
        {
        }

        internal HtmlAutoSaveAttribute(string value) : base("autosave", "AutoSave", value, false) 
        {
        }
    }
}

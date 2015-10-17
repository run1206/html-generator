namespace HtmlGenerator
{
    public class HtmlVolumeAttribute : HtmlAttribute 
    {
        internal HtmlVolumeAttribute() : base("volume", "Volume", null, false) 
        {
        }

        internal HtmlVolumeAttribute(string value) : base("volume", "Volume", value, false) 
        {
        }
    }
}

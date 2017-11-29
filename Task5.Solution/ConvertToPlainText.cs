namespace Task5.Solution
{
    public class ConvertToPlainText : IConverter
    {
        public string ConvertBoldText(string text)
        {
            return "**" + text + "**";
            
        }

        public string ConvertHyperlink(string text, string url)
        {
            return text + " [" + url + "]";
            
        }
        public string ConvertPlainText(string text)
        {
            return text;
        }
    }
}
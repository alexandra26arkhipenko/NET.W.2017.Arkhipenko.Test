namespace Task5
{
    public class ConverterToHtml : IConverter
    {
        public string ConvertBoldText(string text)
        {
            return "<b>" + text + "</b>";
        }

        public string ConvertHyperlink(string text, string url)
        {
            return "<a href=\"" + url + "\">" + text + "</a>";
        }

        public string ConvertPlainText(string text)
        {
            return text;
        }
    }
}
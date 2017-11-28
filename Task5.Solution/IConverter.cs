namespace Task5
{
    public interface IConverter
    {
       string ConvertBoldText(string text);
       string ConvertHyperlink(string text, string url);
       string ConvertPlainText(string text);
    }
}
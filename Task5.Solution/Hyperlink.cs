namespace Task5.Solution
{
    public class Hyperlink : DocumentPart
    {
        public string Url { get; set; }

        public override string Converter(IConverter converter)
        {
            return converter.ConvertHyperlink(Text, Url);
        }
    }
}

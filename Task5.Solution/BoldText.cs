namespace Task5.Solution
{
    public class BoldText : DocumentPart
    {
        public override string Converter(IConverter converter)
        {
            return converter.ConvertBoldText(Text);
        }
    }
}
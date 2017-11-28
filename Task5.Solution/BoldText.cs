namespace Task5
{
    public class BoldText : DocumentPart
    {
        public override string Converter(IConverter converter)
        {
            return converter.ConvertBoldText(Text);
        }
    }
}
﻿namespace Task5.Solution
{
    public class PlainText : DocumentPart
    {
        public override string Converter(IConverter converter)
        {
            return converter.ConvertPlainText(Text);
        }
    }
}

﻿namespace Task5
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }

        public abstract string Converter(IConverter converter);
    }
}

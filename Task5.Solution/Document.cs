﻿using System;
using System.Collections.Generic;

namespace Task5
{
    public class Document
    {
        private List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        public string ToHtml(IConverter converter)
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.Converter(converter)}\n";
            }

            return output;
        }

        public string ToPlainText(IConverter converter)
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.Converter(converter)}\n";
            }

            return output;
        }

        public string ToLaTeX(IConverter converter)
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.Converter(converter)}\n";
            }

            return output;
        }
    }
}

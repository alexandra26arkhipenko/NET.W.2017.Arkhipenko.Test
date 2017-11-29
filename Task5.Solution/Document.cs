using System;
using System.Collections.Generic;

namespace Task5.Solution
{
    public class Document
    {
        private readonly List<DocumentPart> _parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            _parts = new List<DocumentPart>(parts);
        }

        public string ToConvert(IConverter converter)
        {
            string output = string.Empty;

            foreach (DocumentPart part in _parts)
            {
                output += $"{part.Converter(converter)}\n";
            }

            return output;
        }

        

        
    }
}

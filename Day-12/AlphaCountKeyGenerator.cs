using System.Text;

namespace Day_12
{
    public class AlphaCountKeyGenerator : IWordKeyGenerator
    {
        private const int AlphabetSize = 26;
        private readonly bool _caseInsensitive;

        public AlphaCountKeyGenerator(bool caseInsensitive = true)
        {
            _caseInsensitive = caseInsensitive;
        }

        public string GenerateKey(string word)
        {
            if (word == null) return string.Empty;

            var w = _caseInsensitive ? word.ToLowerInvariant() : word;

            var counts = new int[AlphabetSize];
            var others = new StringBuilder();

            foreach (var ch in w)
            {
                if (ch >= 'a' && ch <= 'z')
                    counts[ch - 'a']++;
                else
                    others.Append(ch);
            }

            var sb = new StringBuilder();
            for (int i = 0; i < AlphabetSize; i++)
            {
                sb.Append(counts[i]);
                sb.Append('#');
            }

            if (others.Length > 0)
            {
                var arr = others.ToString().ToCharArray();
                System.Array.Sort(arr);
                sb.Append('|');
                sb.Append(arr);
            }

            return sb.ToString();
        }
    }
}

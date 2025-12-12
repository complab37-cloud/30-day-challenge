
namespace Day_12
{
    public class AnagramGrouper
    {
        private readonly IWordKeyGenerator _keyGenerator;
        private readonly bool _caseInsensitive;

        public AnagramGrouper(IWordKeyGenerator keyGenerator, bool caseInsensitive = true)
        {
            _keyGenerator = keyGenerator;
            _caseInsensitive = caseInsensitive;
        }

        public List<List<string>> Group(IEnumerable<string> words, bool sortEachGroup = false, bool sortGroupsBySizeDesc = false)
        {
            var map = new Dictionary<string, List<string>>();

            foreach (var raw in words)
            {
                var keyInput = _caseInsensitive ? raw.ToLowerInvariant() : raw;
                var key = _keyGenerator.GenerateKey(keyInput);

                if (!map.TryGetValue(key, out var list))
                    map[key] = list = new List<string>();

                list.Add(raw);
            }

            var result = map.Values.ToList();

            if (sortEachGroup)
                foreach (var g in result)
                    g.Sort(StringComparer.OrdinalIgnoreCase);

            if (sortGroupsBySizeDesc)
                result.Sort((a, b) => b.Count.CompareTo(a.Count));

            return result;
        }
    }
}

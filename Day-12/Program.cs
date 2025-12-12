using Day_12;

var words = new List<string> { "eat", "tea", "tan", "ate", "nat", "bat" };

IWordKeyGenerator keyGen = new AlphaCountKeyGenerator(caseInsensitive: true);

var grouper = new AnagramGrouper(keyGen, caseInsensitive: true);

var groups = grouper.Group(words, sortEachGroup: true, sortGroupsBySizeDesc: true);

GroupPrinter.Print(groups);

Console.ReadLine();
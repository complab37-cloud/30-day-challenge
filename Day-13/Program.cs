string [] students = {"Petraitis Rokas", "Augė Artūras", "Mikalauskaitė Aušra", "Šlivka Donatas", "Stakėnaitė Ieva", "Skrėbė Domas", "Bruzgaitė Akvilė"};

var girls = students.Where(s => !s.Split(' ')[1].EndsWith("as")).ToList();


Console.WriteLine(girls.Count);
girls.ForEach(Console.WriteLine);

Console.ReadLine();
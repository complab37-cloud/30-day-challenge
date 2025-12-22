string text ="Ei,  drauguži, žiemos vidury Roges jei turi, tai gerai! Į kalną aukščiausią, patį balčiausią įkopt jei gali, tai gerai!";

string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

List<string> lines = new List<string>();

int index = 0;
int take = 1;

while (index < words.Length)
{
    string line = "";
    for (int i = 0; i < take && index < words.Length; i++)
    {
        if (line != "") line += " ";
        line += words[index++];
    }
    lines.Add(line);
    take++;
}

int max = 0;
for (int i = 0; i < lines.Count; i++)
{
    if (lines[i].Length > max)
    {
        max = lines[i].Length;
    }
}

int axis = max - 1;

for (int i = 0; i < lines.Count; i++)
{
    string line = lines[i];

    if (i % 2 == 0)
    {
        Console.WriteLine(  new string(' ', Math.Max(0, axis - (line.Length - 1))) + line );
    }
    else
    {
        Console.WriteLine( new string(' ', axis) + line );
    }
}
Console.ReadLine(); 
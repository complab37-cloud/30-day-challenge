int festiveBarrels, elfJugs, reindeerFlasks, remainder;

int[] juiceAmounts = {45, 92, 33};

foreach (var item in juiceAmounts)
{
    festiveBarrels = item / 5;  //5L
    remainder = item % 5;       
                                
    elfJugs = remainder / 2;    //2L
    remainder = remainder % 2;  
                                
    reindeerFlasks = remainder; //1L

    Console.WriteLine($"{festiveBarrels} {elfJugs} {reindeerFlasks}");
}
Console.ReadLine();
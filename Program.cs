System.Console.Write($"Enter the number-> ");
int weekNumber = Convert.ToInt32( Console.ReadLine());

if ( weekNumber == 6 || weekNumber == 7)
{
	System.Console.Write($" Day off ");
}
else if ( weekNumber < 1 || weekNumber > 7)
{
	System.Console.Write($" There is no such day of the week ");
}
else if ( weekNumber == 1 || weekNumber < 6 )
{
System.Console.Write($" Working day ");
}
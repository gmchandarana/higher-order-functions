//From the docs -
/*
Enumerable.Select Method
Projects each element of a sequence into a new form.
 */
using Internal;

string[] weekdays = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

var uppercased = weekdays.Select(day => day.ToUpper()).ToArray();
Console.WriteLine($"Uppercased: {string.Join(",", uppercased)}"); //prints Uppercased: SUNDAY,MONDAY,TUESDAY,WEDNESDAY,THURSDAY,FRIDAY,SATURDAY

var onlyThreeLetters = weekdays.Select(day => day.Substring(0, 3)).ToArray();
Console.WriteLine($"Only 3 letters: {string.Join(",", onlyThreeLetters)}"); //prints Only 3 letters: Sun,Mon,Tue,Wed,Thu,Fri,Sat

int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
int[] squared = numbers.Select(num => num * num).ToArray();
Console.WriteLine($"Squared numbers: {string.Join(",", squared)}"); //prints Squared numbers:  1,4,9,16,25,36,49,64
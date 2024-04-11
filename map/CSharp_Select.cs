//From the docs -
/*
Enumerable.Select Method
Projects each element of a sequence into a new form.
 */
string[] weekdays = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };



var uppercased = weekdays.Select(day => day.ToUpper()).ToArray();
Console.WriteLine($"Uppercased: {string.Join(",", uppercased)}"); //prints Uppercased: SUNDAY,MONDAY,TUESDAY,WEDNESDAY,THURSDAY,FRIDAY,SATURDAY

var onlyThreeLetters = weekdays.Select(day => day.Substring(0, 3)).ToArray();
Console.WriteLine($"Only 3 letters: {string.Join(",", onlyThreeLetters)}"); //prints Only 3 letters: Sun,Mon,Tue,Wed,Thu,Fri,Sat
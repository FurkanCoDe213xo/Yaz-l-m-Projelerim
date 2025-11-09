/*   

      DateTime



*/


var simdi = DateTime.Now;
Console.WriteLine(simdi);
Console.WriteLine(simdi.Year);
Console.WriteLine(simdi.Month);
Console.WriteLine(simdi.Day);
Console.WriteLine(simdi.DayOfWeek);
Console.WriteLine(simdi.Hour);
Console.WriteLine(simdi.Minute);
Console.WriteLine(simdi.Second);
Console.WriteLine(simdi.DayOfWeek);



DateTime dt = new DateTime(2018, 6, 10, 14, 30, 45);

Console.WriteLine(dt);
dt.AddYears(1);

Console.WriteLine(dt);


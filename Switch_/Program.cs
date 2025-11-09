int gun = DateTime.Now.DayOfWeek switch
{
    DayOfWeek.Sunday => 0,
    DayOfWeek.Monday => 1,
    DayOfWeek.Tuesday => 2,
    DayOfWeek.Wednesday => 3,
    DayOfWeek.Thursday => 4,
    DayOfWeek.Friday => 5,
    DayOfWeek.Saturday => 6,
    _ => -1
};
switch (gun){
    case 0:
        Console.WriteLine("Pazar");
        break;
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
}

using Task_004;

DayCounter d1 = new DayCounter(new DateTime(2022, 12, 12));
DayCounter d2 = new DayCounter(DateTime.Now);

Console.WriteLine(d1 - d2);
//Console.WriteLine(d2 + 10);
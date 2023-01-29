int minutesOfReceipt = 10;
int minutesInHour = 60;
Console.WriteLine("Сколько человек у вас в очереди?");
int personsInTurn = Convert.ToInt32(Console.ReadLine());
int timeInTurn = personsInTurn * minutesOfReceipt;
int minutes = timeInTurn % minutesInHour;
int hours = timeInTurn / minutesInHour;
Console.WriteLine("Вы должны стоять в очереди " + hours + " часов и " + minutes + " минут.");
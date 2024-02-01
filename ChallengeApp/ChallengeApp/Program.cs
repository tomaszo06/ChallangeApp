int[] grades = new int[365];

List<string> dayOfWeeks = new List<string>();

dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("sroda");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");
//Console.WriteLine(dayOfWeeks[3]);

string[] weekdays = { "ponied", "wtore", "środa", "czwartek", "piątek" };
//Console.WriteLine(weekdays[5]);

//  Pętle

for (int i = 0; i < dayOfWeeks.Count; i++)
    //{
    //    Console.WriteLine(dayOfWeeks[i]);
    //}
    foreach (var day in dayOfWeeks)
{
    Console.WriteLine(day);
}
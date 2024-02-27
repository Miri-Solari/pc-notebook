namespace LAB3_2_
{
    // Здесь реализуем один из вариантов формата времени(короткий)
    public class ShortTime : ITime
    {
        public string GetTime() => DateTime.Now.ToShortTimeString();
    }
}

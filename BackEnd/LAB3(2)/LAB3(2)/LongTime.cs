namespace LAB3_2_
{
    // Здесь реализуем один из вариантов формата времени(длинный)
    public class LongTime : ITime
    {
        public string GetTime() => DateTime.Now.ToLongTimeString();
    }
}

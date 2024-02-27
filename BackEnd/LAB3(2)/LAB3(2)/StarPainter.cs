namespace LAB3_2_
{
    public class StarPainter : IConsolePainter
    {
        public void Paint(int num) // рисуем лесенку из звёздочек
        {
            string temp = string.Empty;

            for (int iter = 0; iter < num; iter++)
            {
                temp += "*";
                Console.WriteLine(temp);
            }
        }
    }
}

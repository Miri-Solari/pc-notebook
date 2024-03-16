namespace LAB3_11_
{
    public class Human
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Mast { get; set; } = "";

        public RabochiyClass Class { get; set; } = RabochiyClass.aristo;
        public int Age { get; set; }
    }

    public enum RabochiyClass
    {
        worker, burjua, aristo, science
    }
}

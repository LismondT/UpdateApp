namespace UpdateApp
{
    internal class Program
    {
        private static readonly string _version = "1.0.0";


        static void Main(string[] args)
        {
            float version = float.Parse(_version.Replace(".", ""));
            Console.WriteLine($"Current version is {version}");
        }
    }
}

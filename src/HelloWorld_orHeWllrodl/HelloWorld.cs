namespace HelloWorld_orHeWllrodl
{
    public static class HelloWorld
    {
        static readonly string HelloWorldStr = "Hello World";
        public static string Hello() => HelloWorldStr;

        public static string Shuffle()
        {
            char[] array = HelloWorldStr.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }
    }
}
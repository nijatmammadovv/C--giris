class Array
{
    static void Main(string[] args)
    {
        int n, i, kicik;
        int[] array = new int[15];

        Console.WriteLine("eded daxil edek : ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Array elementi daxil edek :");
        for (i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        kicik = array[0];
        for (i = 0; i < n; i++)
        {
            if (array[i] < kicik)
            {
                kicik = array[i];
            }
        }
        Console.WriteLine("Bu en kicik arraydir : ");
        Console.ReadLine();
    }
}       
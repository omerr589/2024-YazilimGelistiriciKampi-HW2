internal class Program
{
    private static void Main(string[] args)
    {
        Add();
        Console.WriteLine(Add(20,30));
        Console.WriteLine(Add(10));

        int number1 = 10;
        int number2 = 20;

        var result = Add3(number1, number2);
        Console.WriteLine(result);
        Console.WriteLine(number1);


        var result2 = Add4(ref number1, number2); // number1 değeri aşağıda değişir
        Console.WriteLine(result2);
        Console.WriteLine(number1);

        Add6(1,2,3,4,5);
        Add6(1,2,3,4,5,6,7,8);
    }

    private static void Add()
    {
        Console.WriteLine("Added"); 
    }

    private static int Add(int number1, int number2 = 30)  // Overloading
    {
        return number1 + number2; 
    }

    private static int Add3(int number1, int number2)
    {
        number1 = 1;
        return number1 + number2;
    }

    private static int Add4(ref int number1, int number2)
    {
        number1 = 1;
        return number1 + number2;
    }

    private static int Add5(out int number1, int number2)   // out ile ref'in farkı, ref gönderilirken değeri set edilmiş olmalıdır
    {
        number1 = 1;                                        // out ile gönderilen değerin kod içinde set edilmesi zorunludur çünkü öncesinde değer set edilmemiş olabilir
        return number1 + number2;
    }

    private static int Add6(params int[] numbers) 
    {
        return numbers.Sum();
    }
}
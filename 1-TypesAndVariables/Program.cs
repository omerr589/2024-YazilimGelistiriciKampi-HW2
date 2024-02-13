internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int number1 = 1; // -2,147,483,648 to 2,147,483,647

        Console.WriteLine("Number1 is: {0}", number1);
        Console.WriteLine("Number1 is: " + number1.ToString());

        long number2 = 1231564564564; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

        Console.WriteLine("Number2 is: {0}", number2);

        short number3 = 3; //-32,768 to 32,767

        Console.WriteLine("Number3 is: {0}", number3);

        byte number4 = 255; // 0, 255

        Console.WriteLine("Number4 is: {0}", number4);

        bool state = true; // false, true

        if (state)
            Console.WriteLine("State is: {0}", state);

        char character = 'x';
        Console.WriteLine("character is: " + character);

        double num1 = 3.14;
        Console.WriteLine("character is: {0}", num1);

        decimal num2 = 3.14m;
        Console.WriteLine("character is: {0}", num2);

        Console.WriteLine(Days.Wednesday);
        Console.WriteLine((int)Days.Wednesday);

        var number5 = 10;   // ilk değer int olduğundan Ascii olarak tutar
        number5 = 'A';      // Ascii olarak tutar ondan dolayı 65 olur

        var character2 = 'X';   // İlk olarak char tanımlanır ise
        //character2 = 5;         // Sonrasında sayısal veriye dönemez

        if (true)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");

        int i = 13;
        Console.WriteLine(i == 10 ? "Number is 10" : "Number is not 10");

        int number6 = 14;

        switch (number6 % 5)
        {
            case 0:
                Console.WriteLine("{0} Sayısının 5 ile bölümünden kalan 0", number6);
                break;

            case 1:
                Console.WriteLine("{0} Sayısının 5 ile bölümünden kalan 1", number6);
                break;

            case 2:
                Console.WriteLine("{0} Sayısının 5 ile bölümünden kalan 2", number6);
                break;

            case 3:
                Console.WriteLine("{0} Sayısının 5 ile bölümünden kalan 3", number6);
                break;

            case 4:
                Console.WriteLine("{0} Sayısının 5 ile bölümünden kalan 4", number6);
                break;

            default:
                Console.WriteLine("İmkansız durum");
                break;
        }
    }

    enum Days
    {
        Monday = 10, Tuesday = 20, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
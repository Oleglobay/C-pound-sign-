using System;
class Money
{
    private long hryvnia;  
    private byte kopiyky;  

    public Money(long hryvnia, byte kopiyky)
    {
        this.hryvnia = hryvnia;
        this.kopiyky = kopiyky;
    }

    public override string ToString()
    {
        return $"{hryvnia},{kopiyky:D2}";
    }

    public static Money operator +(Money money1, Money money2)
    {
        long totalHryvnia = money1.hryvnia + money2.hryvnia;
        byte totalKopiyky = (byte)(money1.kopiyky + money2.kopiyky);

        if (totalKopiyky >= 100)
        {
            totalHryvnia += totalKopiyky / 100;
            totalKopiyky %= 100;
        }

        return new Money(totalHryvnia, totalKopiyky);
    }

    public static Money operator /(Money money, int divisor)
    {
        long totalKopiyky = money.hryvnia * 100 + money.kopiyky;
        long resultKopiyky = totalKopiyky / divisor;

        long resultHryvnia = resultKopiyky / 100;
        resultKopiyky %= 100;

        return new Money(resultHryvnia, (byte)resultKopiyky);
    }
    public static Money operator /(Money money, double divisor)
    {
        long totalKopiyky = money.hryvnia * 100 + money.kopiyky;
        double resultKopiyky = totalKopiyky / divisor;

        long resultHryvnia = (long)(resultKopiyky / 100);
        resultKopiyky %= 100;

        return new Money(resultHryvnia, (byte)resultKopiyky);
    }
}

class Program
{
    static void Main()
    {
        Money money1 = new Money(100, 50);
        Money money2 = new Money(50, 25);

        Money sum = money1 + money2;
        Console.WriteLine($"Сума: {sum}");

        Money dividedMoney = money1 / 2;
        Console.WriteLine($"Результат ділення на ціле число: {dividedMoney}");

        Money dividedByFloat = money1 / 1.5;
        Console.WriteLine($"Результат ділення на дробове число: {dividedByFloat}");
    }
}
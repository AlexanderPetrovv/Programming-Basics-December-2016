using System;


public enum Actions
{
    DoNothing = 0,
    Discount50Per = 1,
    Discount70Per = 2,
    HalfMoneyPurchase = 3,
    Withdraw10 = 4,
}

class PassionDays
{
    private static decimal money;
    private static int purchases;

    private static Actions GetAction(char ch)
    {
        if (ch >= 65 && ch <= 90) return Actions.Discount50Per;
        else if (ch >= 97 && ch <= 122) return Actions.Discount70Per;
        else if (ch == '%') return Actions.HalfMoneyPurchase;
        else if (ch == '*') return Actions.Withdraw10;
        else return Actions.DoNothing;
    }

    private static void ProcessCommand(string command)
    {
        foreach (char ch in command)
        {
            switch (GetAction(ch))
            {
                case Actions.Discount50Per:
                    Purchase50PerDiscount(ch); break;
                case Actions.Discount70Per:
                    Purchase70PerDiscount(ch); break;
                case Actions.HalfMoneyPurchase:
                    PurchaseHalfMoney(ch); break;
                case Actions.Withdraw10:
                    Withdraw10(); break;
                case Actions.DoNothing:
                    PurchaseBasic(ch); break;
                default: break;
            }

        }
    }

    private static void Purchase50PerDiscount(char ch)
    {
        decimal price = ch * 0.5m;
        if (money >= price)
        {
            money -= price;
            purchases++;
        }
    }

    private static void Purchase70PerDiscount(char ch)
    {
        decimal price = ch * 0.3m;
        if (money >= price)
        {
            money -= price;
            purchases++;
        }
    }

    private static void PurchaseHalfMoney(char ch)
    {
        if (money > 0)
        {
            money /= 2;
            purchases++;
        }
    }

    private static void Withdraw10()
    {
        money += 10;
    }

    private static void PurchaseBasic(char ch)
    {
        decimal price = ch;
        if (money >= price)
        {
            money -= price;
            purchases++;
        }
    }

    static void Main(string[] args)
    {
        purchases = 0;
        money = decimal.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        while (command != "mall.Enter")
        {
            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command != "mall.Exit")
        {
            ProcessCommand(command);
            command = Console.ReadLine();
        }


        if (purchases == 0)
        {
            Console.WriteLine("No purchases. Money left: {0:f2} lv.", money);
        }
        else
        {
            Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchases, money);
        }

    }
}
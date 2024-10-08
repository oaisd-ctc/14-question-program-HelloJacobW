using System;


public class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("What is ur name?");
       String n = Console.ReadLine();
       Console.WriteLine("What is ur age?");
       int a = int.Parse(Console.ReadLine());
       Console.WriteLine("What are ur Eyes colored around da pupils?");
       String i = Console.ReadLine();
       Console.WriteLine("Feet Glove Size?");
       String s = Console.ReadLine();
       Console.WriteLine("Favorite Color Marble?");
       String c = Console.ReadLine();
       String x = "something I could doooooooooooooooo";
       if(i.Equals(c))
       x = "and";
       else
       x = "but";
       Console.WriteLine("Favorite thing to watch on magic box?");
       String w = Console.ReadLine();
       Console.WriteLine("Favorite mentor?");
       String t = Console.ReadLine();
       Console.WriteLine("Best Subject? U do in school.");
       String ss = Console.ReadLine();
       Console.WriteLine("Funnest Free day? Like Chrismas.");
       String h = Console.ReadLine();
       Console.WriteLine("Favorite Season?");
       String f = Console.ReadLine();
       if (f.ToLower().Equals("summer"))
       f = "the worst season";
       Console.WriteLine("What are you in future... da thing you do fo money");
       String j = Console.ReadLine();
       Console.WriteLine("How many other u's are there. Things u live with. Ssiblings?");
       String b = Console.ReadLine();
       Console.WriteLine("\n\n\n Awite Let me Get dis Straight. U are " + n + " whos " + (a + 5) + " years old in 5 yers, but " + a + " years now. You gots " + i + " eyes, " + x + " ur favorite color is " + c + ". Ur over-socks are size " + s + ". You like teacher " + t + ". And to do in school best is " + ss + ". Ur magic box is generally set to " + w + " and you want to be " + j + " when grow up? Im confused? U only has " + b + " Siblings. You like " + h + " and " + f + ". Am I rite?");
       String yn = Console.ReadLine();
       if(yn.ToLower().Equals("yes"))
       Console.WriteLine("YAY YAY YAY BOSS WILL LIKE DIS!");
       else if(yn.ToLower().Equals("no"))
       Console.WriteLine(":\\");
       else
       Console.WriteLine("I don't get what u say I quit");
    }
}

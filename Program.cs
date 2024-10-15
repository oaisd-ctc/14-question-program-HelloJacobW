using System;


public class Program
{
    static string name;
    static string age;
    static string eyeColor;
    static string hairColor;
    static string shoeSize;
    static string favoriteColor;
    static string favoriteTVorMovie;
    static string favoriteTeacher;
    static string favoriteClass;
    static string favoriteHoliday;
    static string favoriteSeason;
    static string dreamJob;
    static string numberOfSiblings;
    static int ageIn5Years;
    static string x;

    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSiblings();
        DisplaySummaryMessage();
    }
    public static void AskName(){
        Console.WriteLine("What is ur name?");
        name = Console.ReadLine();
    }
    public static void AskAge(){
        Console.WriteLine("What is ur age?");
        age = Console.ReadLine();
    }
    public static void AskEyeColor(){
       Console.WriteLine("What are ur Eyes colored around da pupils?");
       eyeColor = Console.ReadLine();
    }
    public static void AskHairColor(){
        Console.WriteLine("What are your hairs colored? because I cannot see you now.");
        hairColor = Console.ReadLine();
        if(hairColor.ToLower().Equals("orange"))
        hairColor = "";
        else
        hairColor = "not ";
    }
    public static void AskShoeSize(){
       Console.WriteLine("Feet Glove Size?");
       shoeSize = Console.ReadLine();
    }
    public static void AskFavoriteColor(){
       Console.WriteLine("Favorite Color Marble?");
       favoriteColor = Console.ReadLine();
       x = "something I could doooooooooooooooo";
       if(eyeColor.Equals(favoriteColor))
       x = "and";
       else
       x = "but";
    }
    public static void AskFavoriteTvShow(){
       Console.WriteLine("Favorite thing to watch on magic box?");
       favoriteTVorMovie = Console.ReadLine();
    }
    public static void AskFavoriteTeacher(){
       Console.WriteLine("Favorite mentor?");
       favoriteTeacher = Console.ReadLine();
    }
    public static void AskFavoriteClass(){
       Console.WriteLine("Best Subject? U do in school.");
       favoriteClass = Console.ReadLine();
    }
    public static void AskFavoriteHoliday(){
       Console.WriteLine("Funnest Free day? Like Chrismas.");
       favoriteHoliday = Console.ReadLine();
    }
    public static void AskFavoriteSeason(){
       Console.WriteLine("What your favorite season be?");
       favoriteSeason = Console.ReadLine();
       if (favoriteSeason.ToLower().Equals("summer"))
       favoriteSeason = "the worst season";
    }
    public static void AskDreamJob(){
       Console.WriteLine("What are you in future... da thing you do fo money");
       dreamJob = Console.ReadLine();
    }
    public static void CalculateAgeIn5Years(string age){
        ageIn5Years = (int.Parse(age) + 5);
    }
    public static void AskNumberOfSiblings(){
       Console.WriteLine("How many other u's are there. Things u live with. Ssiblings?");
       numberOfSiblings = Console.ReadLine();
    }
    public static void DisplaySummaryMessage(){
       Console.WriteLine("\n\n\n Awite Let me Get dis Straight. U are " + name + " whos " + ageIn5Years + " years old in 5 yers, but " + age + " years now. You gots " + eyeColor + " eyes, " + x + " ur favorite color is " + favoriteColor + ". Ur over-socks are size " + shoeSize + " and you are " + hairColor + "orange haired. You like teacher " + favoriteTeacher + ". And to do in school best is " + favoriteClass + ". Ur magic box is generally set to " + favoriteTVorMovie + " and you want to be " + dreamJob + " when grow up? Im confused? U only has " + numberOfSiblings + " Siblings. You like " + favoriteHoliday + " and " + favoriteSeason + ". Am I rite?");
       string yn = Console.ReadLine();
       if(yn.ToLower().Equals("yes"))
       Console.WriteLine("YAY YAY YAY BOSS WILL LIKE DIS!");
       else if(yn.ToLower().Equals("no"))
       Console.WriteLine(":\\");
       else
       Console.WriteLine("I don't get what u say I quit");
    }

}
/*Best response:
 Awite Let me Get dis Straight. U are John doe whos 84794 years old in 5 yers, but 84789 years now. You gots eleventeen eyes, but ur favorite color is cheese.
  Ur over-socks are size turtle. You like teacher the cheetos cheeta. And to do in school best is tax envasion.
  Ur magic box is generally set to magic (on the box) and you want to be overthrowing the polish government when grow up?
  Im confused? U only has theres only one me. im one in a krillion Siblings. You like why the heck is funnest a word and fall. Am I rite?*/
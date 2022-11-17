using Lab1;

internal class Program
{
    public static void Main(string[] args)
    {
        GameAccount gameAccount = new("Natalie");
        GameAccount gameAccount1 = new("Kirill");
        GameAccount gameAccount2 = new("Hayao");
        GameAccount gameAccount3 = new("Mikael");


        Console.WriteLine("\t\t\t\t\t\tSTANDART GAME FOR USUAL PLAYERS\n");
        StandartGame standartGame = new StandartGame();
        standartGame.PlayGame(gameAccount, gameAccount1, new UpcastGame().DoUpcast(standartGame));
        standartGame.PlayGame(gameAccount, gameAccount3, new UpcastGame().DoUpcast(new StandartGame()));
        standartGame.PlayGame(gameAccount, gameAccount1, new UpcastGame().DoUpcast(new StandartGame()));
        standartGame.PlayGame(gameAccount, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        standartGame.PlayGame(gameAccount, gameAccount1, new UpcastGame().DoUpcast(new StandartGame()));
        standartGame.PlayGame(gameAccount, gameAccount3, new UpcastGame().DoUpcast(new StandartGame()));
        standartGame.PlayGame(gameAccount, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        

        Console.WriteLine(gameAccount.GetStatus());
        Console.WriteLine(gameAccount1.GetStatus());
        Console.WriteLine(gameAccount2.GetStatus());
        Console.WriteLine(gameAccount3.GetStatus());


        Console.WriteLine("\n\n\t\t\t\t\t\t\t  SECOND LAB\n");
        Console.WriteLine("\t\t\t\t\t\tSTANDART GAME FOR CHEATER ACCOUNT\n");
        CheaterGameAccount cheaterGameAccount = new("Andrey");

        Console.WriteLine(cheaterGameAccount.UserName +"'s rating - "+ cheaterGameAccount.CurrentRating);
        Console.WriteLine(gameAccount1.UserName+"'s rating - "+ gameAccount1.CurrentRating);

        StandartGame gameForCheater = new StandartGame();
        gameForCheater.PlayGame( gameAccount1, cheaterGameAccount, new UpcastGame().DoUpcast(gameForCheater));
        gameForCheater.PlayGame(gameAccount1, cheaterGameAccount, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(gameAccount1, cheaterGameAccount, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(gameAccount1, cheaterGameAccount, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(gameAccount1, cheaterGameAccount, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(gameAccount1, cheaterGameAccount, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(gameAccount1, cheaterGameAccount, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(gameAccount1, cheaterGameAccount, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(gameAccount1, cheaterGameAccount, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(gameAccount1, cheaterGameAccount, new UpcastGame().DoUpcast(new StandartGame()));
        Console.WriteLine(cheaterGameAccount.GetStatus());

        Console.WriteLine("\t\t\t\t\t\tSTANDART GAME FOR VIP ACCOUNT\n");
        VipGameAccount vip = new("Victory");

        Console.WriteLine(vip.UserName + "'s rating = " + vip.CurrentRating);
        Console.WriteLine(gameAccount2.UserName + "'s rating = " + gameAccount2.CurrentRating);

        gameForCheater.PlayGame(vip, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(vip, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(vip, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(vip, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(vip, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(vip, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(vip, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(vip, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(vip, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        gameForCheater.PlayGame(vip, gameAccount2, new UpcastGame().DoUpcast(new StandartGame()));
        Console.WriteLine(vip.GetStatus());
        

        Console.WriteLine("\n\t\t\t\t\t\tTRAINING GAME");

        TrainingGame training = new();
        Console.WriteLine("\nTraining game's id - " + training.GameIdStr);
        training.PlayGame(gameAccount, gameAccount1, new UpcastGame().DoUpcast(training));
        training.PlayGame(gameAccount, gameAccount1, new UpcastGame().DoUpcast(new TrainingGame()));
        training.PlayGame(gameAccount, gameAccount1, new UpcastGame().DoUpcast(new TrainingGame()));
        training.PlayGame(gameAccount, gameAccount1, new UpcastGame().DoUpcast(new TrainingGame()));
        training.PlayGame(gameAccount, gameAccount1, new UpcastGame().DoUpcast(new TrainingGame()));
        training.PlayGame(gameAccount, gameAccount1, new UpcastGame().DoUpcast(new TrainingGame()));
        training.PlayGame(gameAccount, gameAccount1, new UpcastGame().DoUpcast(new TrainingGame()));
        training.PlayGame(gameAccount, gameAccount1, new UpcastGame().DoUpcast(new TrainingGame()));

        Console.WriteLine(gameAccount.GetStatus());

      
        Console.WriteLine("\n\n\t\t\t\t\t\tGAME WHERE POINTS CAN GET ONLY ONE PLAYER ");
        GameAccount nata = new("Natali");
        GameAccount kir = new("SaintChyan");
        Console.WriteLine($"\n{nata.UserName}'s rating = {nata.CurrentRating}");
        Console.WriteLine($"{kir.UserName}'s rating = {kir.CurrentRating}");

        var onePlayerGame = new OneUserRatingGame();
        onePlayerGame.PlayGame(nata, kir, new UpcastGame().DoUpcast(onePlayerGame));
        onePlayerGame.PlayGame(nata, kir, new UpcastGame().DoUpcast(new OneUserRatingGame()));
        onePlayerGame.PlayGame(nata, kir, new UpcastGame().DoUpcast(new OneUserRatingGame()));
        onePlayerGame.PlayGame(nata, kir, new UpcastGame().DoUpcast(new OneUserRatingGame()));
        onePlayerGame.PlayGame(nata, kir, new UpcastGame().DoUpcast(new OneUserRatingGame()));
        onePlayerGame.PlayGame(nata, kir, new UpcastGame().DoUpcast(new OneUserRatingGame()));
        onePlayerGame.PlayGame(nata, kir, new UpcastGame().DoUpcast(new OneUserRatingGame()));
        
        Console.WriteLine(nata.GetStatus());
        
        Console.WriteLine($"\n{kir.UserName}'s rating after games = {kir.CurrentRating}");

        

    }
}

enum GameResultStatus { win, loose };



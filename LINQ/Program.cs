namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gamer game1= new Gamer();                                                          //Created Gamer class and get properties in Gamer Class then I set those properties in Program file
            game1.Name = "Madden 2k23";                                                        
            game1.year = 2023;
            game1.Sport = "Football";

            Gamer game2 = new Gamer();
            game2.Name = "NBA 2k23";
            game2.year = 2023;
            game2.Sport = "Basketball";

            Gamer game3 = new Gamer();
            game3.Name = "Fifa 2k23";
            game3.year = 2023;
            game3.Sport = "Soccer";

            List<Gamer> videoGames = new List<Gamer>() { game1, game2, game3 };                 //I created a list of type videoGames and added those games to the list using object initializer Syntax


           var orderByNameLength = videoGames.OrderBy(x => x.Name.Length);                      //This is how you order the list by lenght of Name

            foreach (var game in orderByNameLength)                                             //Create a foreach loop through all of the names on the list adding them by Name Length
            {
                Console.WriteLine(game.Name);
            }

                                                                                                //Listed below is another way to complete the same thing I did above (((Amoris showed me much easier way below)))
            Console.WriteLine();
            Console.WriteLine();



            List<string> listOfGames = new List<string> { "NBA 2k23, NFL 2K23, FIFA 2K23" };    //Create a list of type string and adding the names of the games through object initializer syntax
            var sortedGames = listOfGames.OrderBy(name => name.Length);                         //Order the list by Name Lenght
            foreach (var game in sortedGames)                                                   //For each through the List pushing to consel by Name Length
            {
                Console.WriteLine(game);
            }

            Console.WriteLine();
            Console.WriteLine();

                                                                                                    //An even easier way below

            listOfGames.OrderBy(name => name.Length) .ToList().ForEach(Console.WriteLine);  


        }
    }
}

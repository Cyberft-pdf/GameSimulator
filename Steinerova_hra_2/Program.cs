namespace Steinerova_hra_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.Players.Add(new Player(100, 30, 50));
            game1.Players.Add(new Player(80, 25, 30));
            game1.Enemies.Add(new Enemy(60, 20, false));
            game1.Enemies.Add(new Enemy(70, 25, false));
            game1.Enemies.Add(new Enemy(100, 30, true));

            Console.WriteLine($"Game 1 Result: {game1.Play()}");

            // Hra č. 2
            Game game2 = new Game();
            game2.Players.Add(new Player(100, 30, 50));
            game2.Enemies.Add(new Enemy(50, 20, false));
            game2.Enemies.Add(new Enemy(60, 25, false));
            game2.Enemies.Add(new Enemy(70, 30, true));
            game2.Enemies.Add(new Enemy(80, 35, false));
            game2.Enemies.Add(new Enemy(90, 40, true));

            Console.WriteLine($"Game 2 Result: {game2.Play()}");
        }
    }
    
}

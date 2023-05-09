namespace TextGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Temp삭제
            Temp temp = new Temp();

            GameManager.GameManager gameManager = new GameManager.GameManager();
            gameManager.Run();
        }
    }
}
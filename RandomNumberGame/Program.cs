// See https://aka.ms/new-console-template for more information

using RandomNumberGame;



Console.WriteLine("Welcome to the game. Please choose the level. [E]-Easy, [M]-Medium, [H]-Hard");

char difficulty = Convert.ToChar(Console.ReadLine());

Game game = new Game();

switch (difficulty)
{
    case 'E':
        UI.DisplayMessage("Easy Mode:");
        game.Play(1, 10);
        break;

    case 'M':
        UI.DisplayMessage("Medium Mode:");
        game.Play(1, 50);
        break;

    case 'H':
        UI.DisplayMessage("Hard Mode:");
        game.Play(1, 100);
        break;
}



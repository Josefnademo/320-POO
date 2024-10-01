using Parachutes;

// Initialiser la console
Console.Clear();
Console.CursorVisible = false;
Console.WindowHeight = Config.SCREEN_HEIGHT;
Console.WindowWidth = Config.SCREEN_WIDTH;

// Pour les interactions utilisateur
ConsoleKeyInfo keyPressed;

// Créer le groupe de parachutistes
List<Para> parachutistsInTheAir = new List<Para>();

// Créer l'avion et embarquer le club
Plane plane = new Plane();
for (int i = 0; i < 100; i++)
{
    plane.board(new Para("Bob "+i.ToString()));
}

while (true)
{
    Console.Clear();
    if (Console.KeyAvailable) // L'utilisateur a pressé une touche
    {
        keyPressed = Console.ReadKey(false);
        switch (keyPressed.Key)
        {
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
            case ConsoleKey.Spacebar:
                Para jumper = plane.dropParachutist();
                parachutistsInTheAir.Add(jumper);
                break;
            default:
                break;
        }
    }

    plane.update();
    foreach (Para para in parachutistsInTheAir)
    {
        para.update();
    }

    plane.draw();
    foreach (Para para in parachutistsInTheAir)
    {
        para.draw();
    }
    Thread.Sleep(1);
}



public class MontyHallService
{
    public (int wins, int losses) SimulateGames(int numSimulations, bool switchDoor)
    {
        int wins = 0;
        int losses = 0;
        
        var random = new Random();

        for (int i = 0; i < numSimulations; i++)
        {
            // Randomly place the car behind one of the doors
            int carDoor = random.Next(1, 4);
            int playerChoice = random.Next(1, 4);

            // Host opens one of the remaining doors, which always has a goat
            int openedDoor = 6 - carDoor - playerChoice;

            // If the player switches, they now choose the remaining door
            int finalChoice = switchDoor ? (6 - playerChoice - openedDoor) : playerChoice;

            if (finalChoice == carDoor)
                wins++;
            else
                losses++;
        }

        return (wins, losses);
    }
}

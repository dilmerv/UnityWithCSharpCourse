using ObjectOrientedProgramming.Objects;

namespace CollectionFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections - Lists");
            // Examples
            List<Player> players = new List<Player>();
            players.Add(new Player(1));
            players.Add(new Player(2));
            players.Add(new Player(3));
            players.Add(new Player(4, "michael@learnxr.io"));

            List<Player> secondSetOfPlayers = new List<Player>
            {
                new Player(5),
                new Player(6),
                new Player(7)
            };

            Console.WriteLine($"Player id: {players[3].Id} " +
                $"and email: {players[3].Email}");

            foreach(Player player in players)
            {
                Console.WriteLine($"Player id: {player.Id} " +
                $"and email: {player.Email}");
            }

            foreach (Player player in secondSetOfPlayers)
            {
                Console.WriteLine($"Player id: {player.Id} " +
                $"and email: {player.Email}");
            }

            Console.WriteLine("Collections - Dictionaries");
            // Examples
            Dictionary<int, Player> keyValuePlayers = new Dictionary<int, Player>();
            keyValuePlayers.Add(1, new Player(1));
            keyValuePlayers.Add(2, new Player(2));
            keyValuePlayers.Add(3, new Player(3));
            keyValuePlayers.Add(4, new Player(4));
            keyValuePlayers.Add(5, new Player(5));
            keyValuePlayers.Add(6, new Player(6, "michael@learnxr.io"));

            foreach (int playerId in keyValuePlayers.Keys)
            {
                var player = keyValuePlayers[playerId];
                Console.WriteLine($"[Keys] Player id: {player.Id} " +
                $"and email: {player.Email}");
            }

            foreach (Player player in keyValuePlayers.Values)
            {
                Console.WriteLine($"[Values] Player id: {player.Id} " +
                $"and email: {player.Email}");
            }

            bool doesSixExist = keyValuePlayers.ContainsKey(6);
            bool doesSevenExist = keyValuePlayers.ContainsKey(7);

            Console.WriteLine($"Does player 6 exist: {doesSixExist}");
            Console.WriteLine($"Does player 7 exist: {doesSevenExist}");

            if (!keyValuePlayers.ContainsKey(7))
            {
                keyValuePlayers.Add(7, new Player(7));
            }

            doesSevenExist = keyValuePlayers.ContainsKey(7);

            Console.WriteLine($"Does player 7 exist: {doesSevenExist}");


            //LIFO = last in > first out
            Console.WriteLine("Collections - Stacks");
            // Examples
            Stack<Player> playerStack = new Stack<Player>();
            playerStack.Push(new Player(1));
            playerStack.Push(new Player(2));
            playerStack.Push(new Player(3));
            playerStack.Push(new Player(4));
            playerStack.Push(new Player(5));

            foreach (Player player in playerStack)
            {
                Console.WriteLine($"[Stack] Player id: {player.Id} " +
                $"and email: {player.Email}");
            }

            var popPlayer = playerStack.Pop();
            Console.WriteLine($"[Stack Pop] Player id: {popPlayer.Id} " +
               $"and email: {popPlayer.Email}");

            foreach (Player player in playerStack)
            {
                Console.WriteLine($"[Stack] Player id: {player.Id} " +
                $"and email: {player.Email}");
            }

            //FIFO = first in > first out
            Console.WriteLine("Collections - Queues");
            // Examples

            Queue<Player> playerQueue = new Queue<Player>();
            playerQueue.Enqueue(new Player(1));
            playerQueue.Enqueue(new Player(2));
            playerQueue.Enqueue(new Player(3));
            playerQueue.Enqueue(new Player(4));
            playerQueue.Enqueue(new Player(5));

            foreach (Player player in playerQueue)
            {
                Console.WriteLine($"[Queue] Player id: {player.Id} " +
                $"and email: {player.Email}");
            }

            var dequeuePlayer = playerQueue.Dequeue();

            Console.WriteLine($"[Queue Dequeue] Player id: {dequeuePlayer.Id} " +
               $"and email: {dequeuePlayer.Email}");

            foreach (Player player in playerQueue)
            {
                Console.WriteLine($"[Queue] Player id: {player.Id} " +
                $"and email: {player.Email}");
            }
        }
    }
}
using ObjectOrientedProgramming.Interfaces;

namespace ObjectOrientedProgramming.Objects
{
    public class XboxPlayer : IPlayer
    {
        public void FindEnemiesInCloseProximity(int enemies = 3)
        {
            Console.WriteLine($"Find Enemies {enemies} from xbox");
        }

        public bool MovePlayer(Vector3 newPosition)
        {
            Console.WriteLine("Move player from xbox");
            return true;
        }
    }
}

using ObjectOrientedProgramming.Objects;

namespace ObjectOrientedProgramming.Interfaces
{
    public interface IPlayer
    {
        void FindEnemiesInCloseProximity(int enemies = 3);

        bool MovePlayer(Vector3 newPosition);
    }
}

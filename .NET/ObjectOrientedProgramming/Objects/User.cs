namespace ObjectOrientedProgramming.Objects
{
    public class User
    {
        private int id;

        public int Id { get { return id; } }

        public User(int id)
        {
            this.id = id;
        }

        public void WhoAmI()
        {
            Console.WriteLine($"I am an user with id: {id}");
        }
    }
}

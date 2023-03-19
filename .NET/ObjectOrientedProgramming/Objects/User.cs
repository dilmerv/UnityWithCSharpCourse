namespace ObjectOrientedProgramming.Objects
{
    public class User
    {
        private int id;

        public int Id { get { return id; } }

        protected string socialSecurity;

        public User(int id)
        {
            this.id = id;
            socialSecurity = Guid.NewGuid().ToString();
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine($"I am an user with id: {id}");
        }
    }
}

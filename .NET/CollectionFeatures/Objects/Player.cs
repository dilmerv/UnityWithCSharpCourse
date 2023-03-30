using ObjectOrientedProgramming.Interfaces;

namespace ObjectOrientedProgramming.Objects
{
    public class Player : User, IPlayer
    {
        private string email;

        private string firstName;

        private string lastName;

        private Vector3 position = new Vector3(0, 0, 0);

        private string hiddenInfo;

        public string FullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
        }

        public string FirstNameWithFirstLastCharacter
        {
            get
            {
                return GetFirstNameWithFirstCharacterOfLast();
            }
        }

        public Player(int id) : base(id)
        {
            email = $"{id}@learnxr.io";
        }

        public Player(int id, string email) : base(id)
        {
            this.email = email;
            hiddenInfo = this.socialSecurity;
        }

        public Player(int id, string email, string firstName,
            string lastName) : base(id)
        {
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            hiddenInfo = this.socialSecurity;
        }

        private string GetFirstNameWithFirstCharacterOfLast()
        {
            string firstCharacterOfLastName = string.Empty;
            if (!string.IsNullOrEmpty(lastName))
                firstCharacterOfLastName = lastName[0].ToString();

            return $"{firstName} {firstCharacterOfLastName}";
        }

        public void FindEnemiesInCloseProximity(int enemies = 3)
        {
            Console.WriteLine($"I found {enemies} enemies");
        }

        public bool MovePlayer(Vector3 newPosition)
        {
            Console.WriteLine("Move player from normal player");
            position = newPosition;
            return true;
        }

        public override void WhoAmI()
        {
            Console.WriteLine($"I am an user with email: {email}");
        }
    }
}

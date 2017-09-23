namespace Iuli_problem_1
{
    public class Person
    {
        private string _name;
        private int _age;
        private string _email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new System.ArgumentException("Name cannot be empty!", "original");
            }
        }

        public void ValidateAge(int age)
        {
            if ((age <= 1) || (age >= 100))
            {
                throw new System.ArgumentException("Age must be between 1 and 100!");
            }
        }

        public void ValidateEmail(string email)
        {
            string containsAT = "@";
            if (!email.Contains(containsAT))
            {
                throw new System.ArgumentException("This is not a valid email address. A valid email address contains \"@\"");
            }
        }

        public bool CheckIfThereIsMAil()
        {
            if (string.IsNullOrEmpty(Email))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            string haveMail = "";
            if (CheckIfThereIsMAil())
            {
                haveMail = "\nmail: " + Email;
            }

            return string.Format("Name: {0}\nAge: {1}{2}", Name, Age, haveMail);
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValidateName(value); _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                ValidateAge(value); _age = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                ValidateEmail(value); _email = value;
            }
        }
    }
}

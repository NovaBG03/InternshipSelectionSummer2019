namespace AssignmentProject.Models
{
    using System;

    using AssignmentProject.Models.Contracts;

    public class Person : IPerson
    {
        private string name;
        private string id;

        public Person(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name can not be null, empty or white space.");
                }

                this.name = value;
            }
        }

        public string Id
        {
            get => this.id;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Id can not be null, empty or white space.");
                }

                this.id = value;
            }
        }
    }
}

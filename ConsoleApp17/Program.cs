namespace voting
{
     
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Yes { get; set; }
        public bool ForNoOne { get; set; }
    }


    public  class Program
    {
        static List<Person> peopleList = new List<Person>();
        static void WhoVoted()
        {
            foreach (var person in peopleList)
            {
                string resultofvote;
                if (person.ForNoOne == false)
                {
                    if (person.Yes == true)
                        resultofvote = "For";

                    else
                    {
                        resultofvote = "Against";
                    }
                }
                else
                {
                    resultofvote = "For no one";
                }


                Console.WriteLine("List of people who voted:");

                Console.WriteLine($"{person.FirstName}, {person.LastName} - {resultofvote}");
            }
        }
        static public void Vote(string votename, string aboutvote)
        {
            Console.WriteLine("Voting!");
            Console.WriteLine("");
            Console.WriteLine(votename);
            Console.WriteLine(aboutvote);
            Console.WriteLine(" ");
            Console.WriteLine("Are you voting? Y/N");
            if(Console.ReadLine() == "Y")
            {
                Registration();
            }
            if(Console.ReadLine() == "N")
            {
                Console.WriteLine("That`s all for today.");
            }
        }
        static public void Registration() {

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();
            bool answer = false;
            bool isnothing = false;
            Console.WriteLine("For | Against | Nothing (F/A/N)?");
            string answervariant = Console.ReadLine();

            switch (answervariant)
            {
                case "F":
                    answer = true;
                    break;
                case "A":
                    answer = false;
                    break;
                case "N":
                    isnothing = true;
                    break;
            }
      
            Person person = new Person
            {
                FirstName = name,
                LastName = surname,
                Yes = answer,
                ForNoOne = isnothing
            };

            peopleList.Add(person);
            WhoVoted();
        }

        static public void Main()
        {
            bool isVoteEnded = true;

            if (isVoteEnded == true)
            {
                Console.WriteLine("Name of voting: ");
                string votename = Console.ReadLine();
                Console.WriteLine("Description of voting: ");
                string aboutvote = Console.ReadLine();
                isVoteEnded = false;
                Vote(votename, aboutvote);

            }

            
        }
    }




}
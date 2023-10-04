namespace voting
{
     static class WhoVoted {

        public static List<Person> people = new List<Person>();
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool YesOrNo { get; set; }
    }


    public  class Program
    {
        static List<Person> peopleList = new List<Person>();
        static void WhoVoted()
        {
            foreach (var person in peopleList)
            {
                string resultofvote;
                if (person.YesOrNo == true)
                {
                    resultofvote = "For";
                }
                else
                {
                    resultofvote = "Against";
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
            Console.WriteLine("For/Against?");
            if (Console.ReadLine() == "Y")
            {
                answer = true;
            }
            else if (Console.ReadLine() == "N")
            {
                answer = false;
            }
            Person person = new Person
            {
                FirstName = name,
                LastName = surname,
                YesOrNo = answer
            };

            peopleList.Add(person);
            WhoVoted();
        }

        static public void Main()
        {
            bool ifvotealreadystarted = false;

            if (ifvotealreadystarted == false)
            {
                Console.WriteLine("Name of voting: ");
                string votename = Console.ReadLine();
                Console.WriteLine("Description of voting: ");
                string aboutvote = Console.ReadLine();
                ifvotealreadystarted = true;
                Vote(votename, aboutvote);

            }

            
        }
    }




}
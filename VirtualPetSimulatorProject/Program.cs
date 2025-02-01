internal class Program
{
    private static void Main(string[] args)
    {
        //Declaring pet variables
        int pet;
        string petname;
        Boolean b = true;

        //Display welcome message
        Console.WriteLine("Welcome To Virtual Pet Simulator! \n");
        
        while (b)
        {
            //Display pet selection menu
            Console.WriteLine("Please choose a type of pet: \n1. Dog \n2. Cat \n3. Rabbit\n");

            //Read user input for pet choice and convert it to integer
            pet = (int)Convert.ToInt64(Console.ReadLine());

        
            //Determine the pet type based on the user input and prompt for pet name
            if (pet == 1)
        {
            Console.WriteLine("You have choosen Dog as your pet. Please enter your pet name.\n");
                b = false;
            }
        else if (pet == 2)
        {
            Console.WriteLine("You have choosen Cat as your pet. Please enter your pet name.\n");
                b = false;
            }

        else if (pet == 3)
        {
            Console.WriteLine("You have choosen Rabbit as your pet. Please enter your pet name.\n");
                b = false;
            }
        else
        {
            Console.WriteLine("Invalid entry!"); 
        }
    }   

        //Read the pet name from the user input
        petname = Console.ReadLine();

        //Confirm pet name selection
        Console.WriteLine("\nYou have named your pet {0} \n", petname);
        Console.WriteLine("Welcome {0}! Lets take care of you. \n", petname);

        //Pet care actions
        int petactioninput;
        petactioninput = 1;
        int hunger = 5;
        int health = 5;
        int happiness = 5;

        //Loop until user chooses to exit
        while (petactioninput != 5)
        {
            //Display action menu
            Console.WriteLine("Please choose from the menu: \n1. Feed \n2. Play \n3. Rest \n4. Status \n5. Exit \n");
            
            //Read user input from action menu
            petactioninput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You choose action {0} for your pet \n", petactioninput);

            //Perform action based on user choice
            if (petactioninput == 1)
            {
                Console.WriteLine("You fed the pet, its hunger decreased and health is slightly improved. \n");
                hunger = hunger - 2;
                health = health + 2;
            }
            else if (petactioninput == 2)
            {
                Console.WriteLine("Pet played. Happiness of the pet is increased and hunger is slightly increased. \n");
                happiness = happiness + 2;
                hunger = hunger + 2;                
            }
            else if (petactioninput == 3)
            {
                Console.WriteLine("Pet took rest, health is improved and happiness is slightly decreased. \n");
                health = health + 2;
                happiness = happiness - 2;                
            }

            else if (petactioninput == 4)       
            {
                if (hunger < 1)
                {
                    hunger = 1;
                }
                if (hunger > 10)
                {
                    hunger = 10;
                }
                if (health < 1)
                {
                    health = 1;
                }
                if (health > 10)
                {
                    health = 10;
                }
                if (happiness < 1)
                {
                    happiness = 1;
                }
                if (happiness > 10)
                {
                    happiness = 10;
                }

                //Display current status of pet
                Console.WriteLine("Status- \nHunger: {0}\nHappiness: {1}\nHealth: {2}\n",hunger,happiness,health);
            }
        }

        //Exit message
        Console.WriteLine("You choose to exit. Good Bye!");   
    }
}
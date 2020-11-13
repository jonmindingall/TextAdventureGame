using System;
using System.Dynamic;
using System.Threading;

namespace TextAdventureGame
{
    class Program
    {
        public static int treeLotCount = 0;
        public static int walMartCount = 0;
        public static int momHouseCount = 0;
        public static int overAllCounter = 0;
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {

            
            Start();
        }

        static void Start()
        {
            Console.WriteLine("Christmas Spirit");
            Console.WriteLine("Enter your name:");
            currentPlayer.name = Console.ReadLine();
            if (currentPlayer.name == "")
            {
                Console.WriteLine("Forgot your name huh");
            }
            else
            {
                Console.WriteLine($"{currentPlayer.name}, you awake at home, feeling grouchy with no Christmas spirit");
                
            }
            for (int i = 0; i < 40; i++)
            {
                Console.Write("* ");
                Thread.Sleep(50);
            }
            Console.WriteLine("");
            

            Console.WriteLine("You decide you need to get out and get some Christmas cheer");
            do
            {

                Console.WriteLine("You decide you can either go to a Christmas Tree Lot, go to Wal-Mart or visit your Mom");
                Console.WriteLine("To go to a Tree Lot type 1");
                Console.WriteLine("To go to Wal-Mart type 2");
                Console.WriteLine("To visit your Mom type 3");
                int yourChoice = Int32.Parse(Console.ReadLine());
                if (yourChoice == 1)
                {
                    TreeLot();
                }
                else if (yourChoice == 2)
                {
                    WalMart();
                }
                else if (yourChoice == 3)
                {
                    VisitMom();
                }
                Console.WriteLine($"Your Christmas spirit has increased to {currentPlayer.christmasSpirit}");
                Console.WriteLine("");
                overAllCounter = treeLotCount + walMartCount + momHouseCount;
            } while (overAllCounter < 3);

            if (currentPlayer.christmasSpirit >= 250)
            {
                Console.WriteLine($"Your Christmas spirit has increased to {currentPlayer.christmasSpirit}, your spread the joy of Christmas to others and in the process, increased your own joy");
            }
            else
            {
                Console.WriteLine($"Your Christmas spirit was only increase to {currentPlayer.christmasSpirit}, your Christmas spirit is average or lower");
            }

 

        }

        static void TreeLot()
        {
            
            if (treeLotCount < 1)
            {
                Console.WriteLine("");
                Console.WriteLine("You make it to the Christmas tree lot and see a gorgeous Fraser Fir");
                Console.WriteLine("The tree is 8ft tall and is a beautiful silvery-green");
                Console.WriteLine("You decide to purchase the tree to increase that feeling of holiday cheer");
                Thread.Sleep(2075);
                Console.WriteLine("");
                Console.WriteLine("While walking to the cash register you pass a family with three children");
                Console.WriteLine("They are looking at the same Fraser Fir but you overhear the parents state that because of COVID");
                Console.WriteLine("they lost their job and don't have money for such a tree this year.");
                Thread.Sleep(2075);
                Console.WriteLine("");
                Console.WriteLine("You get to the cash register and");
                Console.WriteLine("1, Decide to buy the tree and take it home to decorate. Or ");
                Console.WriteLine("2, Purchase the tree for the family and wish them a Happy Holiday!");
                Console.WriteLine("");
                int treeChoice = Int32.Parse(Console.ReadLine());
                if (treeChoice == 1)
                {
                    Console.WriteLine("You take the tree home and decorate it.  The tree is beautiful.  You sit and listen to Christmas music and enjoy the twinkling lights!");
                    Thread.Sleep(2075);
                    Console.WriteLine("");
                    currentPlayer.christmasSpirit += 30;
                }
                else if (treeChoice == 2)
                {
                    Console.WriteLine("You purchase the tree for the family who are eternally grateful.  The feeling of giving and doing for others gives you a feeling unlike any other");
                    Thread.Sleep(2075);
                    Console.WriteLine("");
                    currentPlayer.christmasSpirit += 100;
                }
            }
            else
            {
                Console.WriteLine("You've been to the Tree Lot already, please choose another destination");
            }
            
            treeLotCount += 1;

        }

        static void WalMart()
        {
            if (walMartCount < 1)
            {
                Console.WriteLine("");
                Console.WriteLine("You make it to the hell that is known as Wal-Mart");
                currentPlayer.christmasSpirit -= 20;
                Console.WriteLine($"Your Christmas Spirit instantly drops 20 points to {currentPlayer.christmasSpirit}");
                Console.WriteLine("You need a Christmas Spirit hit immediately");
                Thread.Sleep(2075);
                Console.WriteLine("");
                Console.WriteLine("You decide you need a Christmas wreath for your door");
                Console.WriteLine("While walking to find a wreath you pass the layaway department");
                Console.WriteLine("You decide to either");
                Console.WriteLine("1, Pay off 2 items currently on layaway");
                Console.WriteLine("2, Find your wreath and tale it home");
                Thread.Sleep(2075);
                Console.WriteLine("");
                int walMartChoice = Int32.Parse(Console.ReadLine());
                if (walMartChoice == 1)
                {
                    Console.WriteLine("Even though the families will never know, they'll never forget the Christmas angel that paid for their item on layaway before Christmas");
                    Thread.Sleep(2075);
                    Console.WriteLine("");
                    currentPlayer.christmasSpirit += 60;
                }
                else if (walMartChoice == 2)
                {
                    Console.WriteLine("You purchase the wreath and immediately place it on your front door.");
                    Thread.Sleep(2075);
                    Console.WriteLine("");
                    currentPlayer.christmasSpirit += 20;
                }
            }
            else
            {
                Console.WriteLine("You've been to Wal=Mart already, please choose another destination");
            }

            walMartCount += 1;
        }

        static void VisitMom()
        {
            if (momHouseCount < 1)
            {
                Console.WriteLine("");
                Console.WriteLine("You pull into your Mom's driveway.  Ready to ask for your favorite Christmas Eggnog");
                Console.WriteLine("Mom's eggnog always put's your Christmas Spirit at 100");
                Console.WriteLine("You get inside and greet your Mom");
                Thread.Sleep(2075);
                Console.WriteLine("");
                Console.WriteLine("While talking your Mom mentions that she's really been craving the Christmas Eggnog Cheesecake you made last year");
                Console.WriteLine("Last year making that cheesecake was the hardest thing you ever completed in your life");
                Console.WriteLine("That includes completed a course at TrueCoders");
                Console.WriteLine("You decide to either");
                Console.WriteLine("1, Ask Mom to make the eggnog");
                Console.WriteLine("2, Ask Mom to make the eggnog and then use some of the eggnog to make the cheesecake");
                Thread.Sleep(2075);
                Console.WriteLine("");
                int momHouseChoice = Int32.Parse(Console.ReadLine());
                if (momHouseChoice == 1)
                {
                    Console.WriteLine("Your Mom, who can never say no to you, makes you some Eggnog.  You sit around the fire together telling family stories while sipping on your favorite Christmas beverage");
                    Thread.Sleep(2075);
                    Console.WriteLine("");
                    currentPlayer.christmasSpirit += 100;
                }
                else if (momHouseChoice == 2)
                {
                    Console.WriteLine("After your Mom finishes the eggnog, you surprise her by taking a few cups of the eggnog to make your labor of love, a Christmas Eggnog Cheesecake.");
                    Console.WriteLine("Your Mom is very grateful and posts picture after picture of Facebook showing the eggnog, the cheesecake and her wonderful child");
                    Thread.Sleep(2075);
                    Console.WriteLine("");
                    currentPlayer.christmasSpirit += 200;
                }
            }
            else
            {
                Console.WriteLine("You've been to Mom's House already, please choose another destination");
            }

            momHouseCount += 1;

        }

    }
}

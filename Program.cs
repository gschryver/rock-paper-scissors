using System;

Main();

void Main()
{
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Let's play Rock, Paper, Scissors!");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("What would you like to throw? \n 1. Rock \n 2. Paper \n 3. Scissors"); 

    int userScore = 0; 
    int computerScore = 0;

    while (true)
    {
        PrintScore(userScore, computerScore);

        string userInput = Console.ReadLine(); // Get the user's input
        if (userInput.ToLower() == "exit") // Allow the user to exit the game at any time
        {
            break;
        }

        if (int.TryParse(userInput, out int userMove))
        {
            // if the user's input is not 1, 2, or 3, then ask them to enter a valid input
            if (userMove < 1 || userMove > 3)
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                continue;
            }

            string userMoveString; // user's move as a string
            string userMoveArt; // ASCII art for the user's move
            switch (userMove) // switch statement to determine the user's move. switches are used instead of if statements because they are more readable and easier to maintain
            {
                // switches are followed by cases. each case is a possible value of the variable being switched on
                // e.g. if userMove == 1, then the code in case 1 will be executed
                case 1:
                    userMoveString = "Rock";
                    userMoveArt = @"
                        _______
                    ---'   ____)
                        (_____)
                        (_____)
                        (____)
                    ---.__(___)
                    ";
                    break;
                case 2:
                    userMoveString = "Paper";
                    userMoveArt = @"
                        _______
                    ---'    ____)____
                            ______)
                            _______)
                            _______)
                    ---.__________)
                    ";
                    break;
                case 3:
                    userMoveString = "Scissors";
                    userMoveArt = @"
                        _______
                    ---'   ____)____
                            ______)
                        __________)
                        (____)
                    ---.__(___)
                    ";
                    break;
                default:
                    userMoveString = "";
                    userMoveArt = "";
                    break;
            }

            // Generate a random number between 1 and 3 for the computer's move
            Random random = new Random();
            int computerMove = random.Next(1, 4);

            string computerMoveString;
            string computerMoveArt;
            switch (computerMove) // switch statement to determine the computer's move. cases correspond to the possible values of computerMove
            {
                case 1:
                    computerMoveString = "Rock";
                    computerMoveArt = @"
                        _______
                    ---'   ____)
                        (_____)
                        (_____)
                        (____)
                    ---.__(___)
                    ";
                    break;
                case 2:
                    computerMoveString = "Paper";
                    computerMoveArt = @"
                        _______
                    ---'    ____)____
                            ______)
                            _______)
                            _______)
                    ---.__________)
                    ";
                    break;
                case 3:
                    computerMoveString = "Scissors";
                    computerMoveArt = @"
                        _______
                    ---'   ____)____
                            ______)
                        __________)
                        (____)
                    ---.__(___)
                    ";
                    break;
                default: // default case is executed if none of the cases match the value of computerMove
                    computerMoveString = "";
                    computerMoveArt = "";
                    break;
            }

            Console.WriteLine($"You threw:\n{userMoveArt}\n{userMoveString}\n");
            Console.WriteLine($"Computer threw:\n{computerMoveArt}\n{computerMoveString}\n");

            // Compare the moves and determine the winner
            if (userMove == computerMove)
            {
                Console.WriteLine($"It's a tie! You both threw {userMoveString}.");
            }
            else if (userMove == 1 && computerMove == 3 || userMove == 2 && computerMove == 1 || userMove == 3 && computerMove == 2)
            {
                Console.WriteLine($"You win! You threw {userMoveString} and the computer threw {computerMoveString}.");
                userScore++;
            }
            else
            {
                Console.WriteLine($"Computer wins! You threw {userMoveString} and the computer threw {computerMoveString}.");
                computerScore++;
            }

            if (userScore == 3)
            {
                Console.WriteLine("You won the game!");
                break;
            }
            else if (computerScore == 3)
            {
                Console.WriteLine("Computer won the game!");
                break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
        }
    }
}

void PrintScore(int userScore, int computerScore)
{
    Console.WriteLine($"Score: You {userScore} - {computerScore} Computer");
}
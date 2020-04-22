using System;

namespace guessingGame {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("********************************");
            Console.WriteLine ("Welcome to Number Guessing Game");
            Console.WriteLine ("********************************");

            Console.WriteLine ("----------------------------------");
            Console.WriteLine ("Select Level of Dificulty");
            Console.WriteLine ("----------------------------------");
            while (true) {
                Console.Write ("Enter E for Easy, M for Medium and H for Hard: ");
                string answer = Console.ReadLine ().ToLower ();
                if (answer == "e") {
                    Console.WriteLine ("Level of Dificulty - Easy");
                    string check = "";
                    string intcheck = "";
                    int guesses;
                    Random random = new Random ();
                    int guess = random.Next (1, 11);
                    for (int i = 1; i <= 6; i++) {
                        Console.Write ("Guess the correct number between 1 - 10: ");
                        guesses = 6 - i;
                        int value;
                        if (int.TryParse (Console.ReadLine (), out value)) {
                            intcheck = "true";
                        } else {
                            intcheck = "false";
                        }
                        if (intcheck == "true") {
                            int userguess = value;
                            Console.WriteLine (userguess);
                            if (guess == userguess) {
                                Console.WriteLine ("********************************************************************");
                                Console.WriteLine ("You got it right!, Nice one");
                                check = "true";
                                break;
                            } else {
                                Console.WriteLine ("That was wrong, Nice try");

                                if (guesses > 1) {
                                    Console.WriteLine ("You have " + Convert.ToString (guesses) + " guesses left");
                                } else if (guesses == 1) {
                                    Console.WriteLine ("You have " + Convert.ToString (guesses) + " guess left");
                                } else {
                                    check = "false";
                                }

                            }
                        } else {
                            Console.WriteLine ("Invalid Input, Please Enter a Number");
                            if (guesses > 1) {
                                Console.WriteLine ("You have " + Convert.ToString (guesses) + " guesses left");
                            } else if (guesses == 1) {
                                Console.WriteLine ("You have " + Convert.ToString (guesses) + " guess left");
                            } else {
                                check = "false";
                            }

                        }
                    }
                    if (check == "true") {
                        Console.WriteLine ("Enter Q to quit the game or Play Again by selecting dificulty level");
                        Console.WriteLine ("********************************************************************");
                    } else {
                        Console.WriteLine ("********************************************************************");
                        Console.WriteLine ("Game over!, Better Luck Next Time");
                        Console.WriteLine ("Enter Q to quit the game or Play Again by selecting dificulty level");
                        Console.WriteLine ("********************************************************************");
                    }

                } else if (answer == "m") {
                    Console.WriteLine ("Level of Dificulty - Medium");
                    string check = "";
                    string intcheck = "";
                    int guesses;
                    Random random = new Random ();
                    int guess = random.Next (1, 21);
                    for (int i = 1; i <= 4; i++) {
                        Console.Write ("Guess the correct number between 1 - 20: ");
                        guesses = 4 - i;
                        int value;
                        if (int.TryParse (Console.ReadLine (), out value)) {
                            intcheck = "true";
                        } else {
                            intcheck = "false";
                        }
                        if (intcheck == "true") {
                            int userguess = value;
                            Console.WriteLine (userguess);
                            if (guess == userguess) {
                                Console.WriteLine ("********************************************************************");
                                Console.WriteLine ("You got it right!, Nice one");
                                check = "true";
                                break;
                            } else {
                                Console.WriteLine ("That was wrong, Nice try");

                                if (guesses > 1) {
                                    Console.WriteLine ("You have " + Convert.ToString (guesses) + " guesses left");
                                } else if (guesses == 1) {
                                    Console.WriteLine ("You have " + Convert.ToString (guesses) + " guess left");
                                } else {
                                    check = "false";
                                }

                            }
                        } else {
                            Console.WriteLine ("Invalid Input, Please Enter a Number");
                            if (guesses > 1) {
                                Console.WriteLine ("You have " + Convert.ToString (guesses) + " guesses left");
                            } else if (guesses == 1) {
                                Console.WriteLine ("You have " + Convert.ToString (guesses) + " guess left");
                            } else {
                                check = "false";
                            }

                        }
                    }
                    if (check == "true") {
                        Console.WriteLine ("Enter Q to quit the game or Play Again by selecting dificulty level");
                        Console.WriteLine ("********************************************************************");
                    } else {
                        Console.WriteLine ("********************************************************************");
                        Console.WriteLine ("Game over!, Better Luck Next Time");
                        Console.WriteLine ("Enter Q to quit the game or Play Again by selecting dificulty level");
                        Console.WriteLine ("********************************************************************");
                    }

                } else if (answer == "h") {
                    Console.WriteLine ("Level of Dificulty - Hard");
                    string check = "";
                    string intcheck = "";
                    int guesses;
                    Random random = new Random ();
                    int guess = random.Next (1, 51);
                    for (int i = 1; i <= 3; i++) {
                        Console.Write ("Guess the correct number between 1 - 50: ");
                        guesses = 3 - i;
                        int value;
                        if (int.TryParse (Console.ReadLine (), out value)) {
                            intcheck = "true";
                        } else {
                            intcheck = "false";
                        }
                        if (intcheck == "true") {
                            int userguess = value;
                            Console.WriteLine (userguess);
                            if (guess == userguess) {
                                Console.WriteLine ("********************************************************************");
                                Console.WriteLine ("You got it right!, Nice one");
                                check = "true";
                                break;
                            } else {
                                Console.WriteLine ("That was wrong, Nice try");

                                if (guesses > 1) {
                                    Console.WriteLine ("You have " + Convert.ToString (guesses) + " guesses left");
                                } else if (guesses == 1) {
                                    Console.WriteLine ("You have " + Convert.ToString (guesses) + " guess left");
                                } else {
                                    check = "false";
                                }

                            }
                        } else {
                            Console.WriteLine ("Invalid Input, Please Enter a Number");
                            if (guesses > 1) {
                                Console.WriteLine ("You have " + Convert.ToString (guesses) + " guesses left");
                            } else if (guesses == 1) {
                                Console.WriteLine ("You have " + Convert.ToString (guesses) + " guess left");
                            } else {
                                check = "false";
                            }

                        }
                    }
                    if (check == "true") {
                        Console.WriteLine ("Enter Q to quit the game or Play Again by selecting dificulty level");
                        Console.WriteLine ("********************************************************************");
                    } else {
                        Console.WriteLine ("********************************************************************");
                        Console.WriteLine ("Game over!, Better Luck Next Time");
                        Console.WriteLine ("Enter Q to quit the game or Play Again by selecting dificulty level");
                        Console.WriteLine ("********************************************************************");
                    }
                } else if (answer == "q") {
                    break;
                } else {
                    Console.WriteLine ("Wrong Input, Enter Appropriate Input");
                    continue;
                }

            }

        }

    }
}
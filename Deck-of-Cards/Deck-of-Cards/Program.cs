/*
Create a deck of cards using C#. I chose to use an array for this particular question. This was made as part of a technical test that I undertook for a company on the 14th of Aug, 2019.

I was asked to create a virtual deck of cards, and consider how I would create the cards, shuffle the cards, how the cards would look in the players hand, and how I would identify the type of card.

My logic:

    deck of cards has 52 cards
    13 faces(deuce, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king) of each suit
    4 suits (spades, hearts, diamonds, clubs)

Features Implemented:

    Create and intitalize deck
    Shuffle deck
    3 Print functions: - current position of cards - face, suit, etc - players hand
    Function to identify cards
    Deal cards
    players hand

Future updates that havent been taken into consideration here:

    Eliminate duplicate cards
    Additional card drawing
    Unique 52 cards so there are no duplicates, and only 52 cards can be played
    Shuffle deck excludes cards in your hand
 */

using System;

namespace Deck_of_Cards
{
    class Program
    {
        static int[] ResetDeck(ref int[] deck)
        {
            //assign the deck numbers from 1 - 52 in order (reset the deck)
            for (int i = 0; i < 52; i++)
            {
                deck[i] = i;
            }
            return deck;
        }

        static int[] ShuffleDeck(ref int[] deck)
        {
            //create random object
            Random rand = new Random();

            //shuffle randomly 999 times
            for (int i = 0; i < 999; i++)
            {
                //get random numbers to indicate two random positions in the deck
                int from = ((rand.Next(1, 999)) % 52);
                int to = ((rand.Next(1, 999)) % 52);
                //assign card the value from the first random numb
                int card = deck[from];
                //set the first random number value to the value of the second rand num
                deck[from] = deck[to];
                //set the val of the second rand num to the first rand num value
                deck[to] = card;
                //essentially swapping them
            }
            return deck;
        }

        static void PrintDeckNum(int[] deck)
        {
            Console.Write("The current deck is: ");
            foreach (int i in deck)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }

        static void PrintDeckName(string[] deckWithName)
        {
            Console.Write("The current deck is: ");
            foreach (string i in deckWithName)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }


        static string[] GetCardName(int[] deck, ref string[] deckWithName)
        {
            string[] suitName = { "Spades", "Clubs", "Diamond", "Hearts" };
            string[] faceName = { "Deuce", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            //for the whole deck
            for (int i = 0; i < 52; i++)
            {
                //card in the current position in array
                int card = deck[i];
                int suit = card / 13;
                int face = card % 13;

                deckWithName[i] = (faceName[face] + " of " + suitName[suit]);

            }

            return deckWithName;
        }

        static void DealCards(string[] deckWithName, ref string[] hand1, ref string[] hand2)
        {
            //create random object
            Random rand = new Random();

            //player 1
            for (int i = 0; i < 5; i++)
            {
                int random = ((rand.Next(1, 999)) % 52);
                hand1[i] = deckWithName[random];
            }

            //player 2
            for (int i = 0; i < 5; i++)
            {
                int random = ((rand.Next(1, 999)) % 52);
                hand2[i] = deckWithName[random];
            }
        }

        static void PrintHands(string[] hand1, string[] hand2)
        {
            Console.Write("Player 1's Hand consists of: ");
            foreach (string i in hand1)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            Console.Write("Player 2's Hand consists of: ");
            foreach (string i in hand2)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            //create a deck of 52 cards
            int[] deck = new int[52];
            //array for storing named cards
            string[] deckWithName = new string[52];
            //players hands
            string[] hand1 = new string[5];
            string[] hand2 = new string[5];

            ResetDeck(ref deck);

            ShuffleDeck(ref deck);

            GetCardName(deck, ref deckWithName);

            DealCards(deckWithName, ref hand1, ref hand2);

            PrintHands(hand1, hand2);
            //print functions to check
            //PrintDeckNum(deck);
            //PrintDeckName(deckWithName);
        }
    }
}


using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223{ 

    /*TESTING CLASS*/
    class Testing {
        
        /*runTest is a method that lets us try out several functions of the Pack and Card class.*/
        public static void MethodTests() {

            /*We create two hands one for texas hold em poker 
             *and one for regular poker (Five card draw poker)          */
            myHand tHand = new myHand(1);
            myHand fHand = new myHand(2);

            /*We firstly perform the Fischer Yates Shuffle by calling its function
              providing the shuffled deck as an output.                            
              We call the shuffle function and give it 1 as the input to select the 
              appropriate shuffle for the situation                                */
            Console.WriteLine("\nFischer-Yates Shuffle: ");
            Pack.ShuffleCardPack(1);
            
            int c = 0;
            /*We then print to the screen the value of each card in the pack to 
              demonstrate the result of the Fischer-Yates shuffle.              */
            foreach (Card card in Pack.pack){
                c++;
                Console.WriteLine("Card in position ["+c+"]: " + card.Name + " [" + card.Value + "|" + card.Suit +"]");
            }


            /*We do the same in the case of the riffle shuffle just like the Fischer Yates Shuffle*/
            Console.WriteLine("\nRiffle Shuffle: ");
            Pack.ShuffleCardPack(2);
            
            c = 0;
            /*We demostrate the shuffle just like before.*/
            foreach (Card card in Pack.pack){
                c++;
                Console.WriteLine("Card in position ["+c+"]: " + card.Name + " [" + card.Value + "|" + card.Suit +"]");
            }


            /*We then show the Deal functions */
            /*Method that deals only one card*/
            Console.WriteLine("\nDeal one card:");
            Card card1 = Pack.Deal(tHand);

            /* The Return value of Pack.deal is Null when it's empty.*/
            Console.WriteLine("Dealing a card... ");
            if (card1 != null) { 
                Console.WriteLine("Dealt a(n) " + card1.Name + " [" + card1.Value + "|" + card1.Suit +"]");
            }else{
                Console.WriteLine("No cards left to be dealt");
            }

            /* We deal another card to the same hand*/
            Console.WriteLine("\nDeal another card:");
            card1 = Pack.Deal(tHand);

            Console.WriteLine("Dealing another card... ");
            if (card1 != null){
                Console.WriteLine("Dealt a(n) " + card1.Name + " [" + card1.Value + "|" + card1.Suit + "]");
            }else{
                Console.WriteLine("No cards left to be dealt");
            }


            /* We show how some of the methods in the class Pack.cs function more specifically .dealCard*/
            List<Card> cards = Pack.DealCard(5, fHand);
            Console.WriteLine("\nDealing 5 Cards using dealCard method...");

            foreach (Card card2 in cards){

                Console.WriteLine("Dealt a(n) " + card2.Name + " [" + card2.Value + "|" + card2.Suit +"]");
                
            }


            /*We now clear the pack firstly to then try and add a card to the deck.*/
            Pack.pack = new List<Card>(); 
            Console.WriteLine("\nAdding a new card:");
            Card card3 = new Card(1, 1);
            Pack.pack.Add(card3); 
            Console.WriteLine("Added a(n) " + card3.Name + " [" + card3.Value + "|" + card3.Suit +"]");


            /*We then try the same while adding multiple of them*/
            Pack.pack = new List<Card>();
            Card card4 = new Card(1, 1);

            Console.WriteLine("\nAdding 16 new cards:");

            for (int i = 1; i < 5; i++) { 

                for (int j = 1; j < 5; j++){
                    /*Each card is added as they're created using the two counters*/
                    card4.Value = j;
                    card4.Suit = i;
                    card4.Name = card4.ChangeName();
                    Pack.pack.Add(card4);

                    Console.WriteLine("Added a(n) " + card4.Name + " [" + card4.Value + "|" + card4.Suit + "]");

                }

            }

            /*Lastly we show the content of our hands.*/
            tHand.ShowHand();
            fHand.ShowHand();

        }

    }

}



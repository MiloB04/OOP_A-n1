using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
    class Pack{
        public static List<Card> pack = new List<Card>();

        static Pack(){
           /*For loop that repeats for each suit of cards*/
           for(int i=1; i<5; i++){ 

                /*For loop that repeats for each value of cards*/
                for (int j = 1; j < 14; j++){   

                    /*Thirteen cards are added for each suit resulting
                     * in an average 52 playing cards deck          */

                    pack.Add(new Card(j, i)); 
                }

           }

        }



        public static bool shuffleCardPack(int typeOfShuffle)
        {

            /*We check that there are at least more than one card 
             * in the deck so that it can be shuffled if it isn't 
             * it defaults the switch case to No Shuffle.       */
            if (pack.Count >= 2) { typeOfShuffle = 0; }

            /*Variable that keeps track of the pack's size*/
            int n = pack.Count;

            /*Switch Case to select between the different*/
            switch (typeOfShuffle){
                case 1:
                    /*Fischer Yates Shuffle:
                     * - The fisher yates shuffle consists in swapping every card 
                     * - in order from last to first of the deck to a random position 
                     * - (not excluding its own) that comes before itself.          */

                    /*Creating a new "Random" object to handle random number creation 
                    *as well as a variable to hold random numbers we generate */
                    Random rand = new Random();



                    /*Loop that repeats the random movement for each card*/
                    for (int i = 0; i < (n - 1); i++){

                        /*First we generate a new random position for the card*/
                        int r = i + rand.Next(n - i);

                        /*Then we swap them around through the use of a Temporary */
                        Card temp = pack[r];
                        pack[r] = pack[i];
                        pack[i] = temp;

                    }
                break;

                case 2:
                    /*Card Riffle Shuffle:
                     * - The Riffle shuffle consists in dividing the deck in two halves
                     * - and then interleaving them together in such a way that the cards
                     * - from the two decks are alternated between each other              */

                    /*Variable that keeps track of the size of the deck*/
                    n = pack.Count;

                    /*Here we divide the pack of cards into two new packs "PackOne" 
                     * And "PackTwo" that will be fused together later             */
                    List<Card> PackOne = new List<Card>();
                    List<Card> PackTwo = new List<Card>();


                    /*We assign PackOne the First half of the deck*/
                    for (int i = 0; i < n / 2; i++){
                        /*Adds in the first half*/
                        PackOne.Add(pack[i]);
                        /*Checks if the total is even or not for operation purposes.*/
                        if (n % 2 == 0){      /*if even the operation keeps going as normal*/

                            /*Takes value from the first half*/
                            PackTwo.Add(pack[i + (n / 2)]);

                        }
                        else{               /*if uneven we take the higher middle value as the half*/

                            if (i != ((n - 1) / 2)){/*Clause to prevent going over the pack's size, we take 
                                                  * the lower middle value and if we reach that it means 
                                                  * we're at the end of the for loop so there are no more
                                                  * cards in the second half to add                      */

                                /* Takes value from the second half 
                                 * (by adding half of the length to the i as an offset)*/
                                PackTwo.Add(pack[i + ((n + 1) / 2)]);

                            }
                        }
                        /*Now in preparation to reintroduce the cards 
                         * back into the new order we clear the deck.*/
                        pack.Clear();

                        /*We now reassemble the deck from the two halves we've created.*/
                        for (int j = 0; j < (n / 2); j++){

                            pack.Add(PackOne[j]);

                            /*We need the same clause as before to avoid going 
                             * outside the range of the second half's deck     */
                            if (n % 2 == 0){
                                pack.Add(PackTwo[j]);
                            }else{
                                if (j != ((n - 1) / 2)){
                                    pack.Add(PackTwo[j]);
                                }
                            }
                        }
                    }
                break;

                default:
                    /*No shuffle.*/
                break;   
            }

            return true;

        }

        /*Through the use of this method we remove a card 
         * from the deck and add it to a player's hand. */
        public static Card deal(myHand Hand) {
                
                
                if (pack.Count > 0) { /*First we check if the pack isn't empty.*/
                    
                    /*If it isn't empty we remove the first card from the top of the deck */
                    Card card = pack[(pack.Count-1)];
                    /*And then we draw it into our hand*/
                    Hand.DrawCard(card);
                    pack.RemoveAt((pack.Count-1));
                    return card;

                }else { /*If it IS empty we return "null" as in no card was dealt*/
                    return null; 
                }

            }

        /*Function that deals multiple cards to a given hand*/
        public List<Card> dealCard(int amount, myHand Hand){

            /*We avoid going over the amount left in the deck*/
            if (amount >= pack.Count){ amount = pack.Count; }   
            
            /*We create a list of cards that will then be added to the the hand*/
            List<Card> cards = new List<Card>();

            for(int i=0; i < amount; i++){

                cards.Add(pack[0]);

                /*If the hand becomes full the program stops
                 * - we can detect when it happens because the
                 * - function DrawCard() returns null when it 
                 * - cannot add another card                   */
                if(Hand.DrawCard(pack[0]) != null){
                    Console.WriteLine("Hand is full, no further cards will be dealt.");
                    return null;
                }
                /*We also remove each card as they're drawn*/
                pack.RemoveAt(0);
            }
            /*We pass the cards drawn so we can 
             * more easily print them to the screen.*/
            return cards;
        }

    }

}
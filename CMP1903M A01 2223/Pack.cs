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



        public static bool shuffleCardPack(int typeOfShuffle){

            /*We check that there are at least more than one card 
             * in the deck so that it can be shuffle             */
            if (pack.Count >= 2){

                /*Fischer Yates Shuffle:
                 * - The fisher yates shuffle consists in swapping every card 
                 * - in order from last to first of the deck to a random position 
                 * - (not excluding its own) that comes before itself.          */
                if (typeOfShuffle == 1){

                    /*Creating a new "Random" object to handle random number creation 
                     *as well as a variable to hold random numbers we generate */
                    Random rand = new Random();
                    int nRand = 0;
                    
                    /*Loop that repeats the random movement for each card*/
                    for (int head = pack.Count -1; head > 0 ; head--){
                        
                        /*First we generate a new random position for the card*/
                        nRand = rand.Next(0, head);
                        
                        /*Then we swap them around for each case*/
                        Card num1 = pack[nRand];
                        Card num2 = pack[head];
                       
                        pack[head] = num1;
                        pack[nRand] = num2;
                        
                        
                    }

                    return true;


                } else if (typeOfShuffle == 2) {
                    /*Card Riffle Shuffle:
                     * - The Riffle shuffle consists in dividing the deck in two halves
                     * - and then interleaving them together in such a way that the cards
                     * - from the two decks are alternated between each other              */

                    

                    /*Here we divide the pack of cards into two new packs "PackOne" And "PackTwo" that will be fused together later*/
                    List<Card> PackOne = new List<Card>();
                    
                    /*We assign PackOne the First half of the deck*/
                    for (int i = 0; i < pack.Count / 2; i++) {
                        PackOne.Add(pack[i]);
                    }

                    /*We assign PackTwo the Second half of the deck*/
                    Card[] Array = pack.GetRange((pack.Count / 2) - 1, pack.Count - (pack.Count / 2)).ToArray();
                    List<Card> PackTwo = new List<Card>(Array);
                    
                    /*We then clear the original pack's contents in preparation to add in the cards in a new order*/
                    pack.Clear();

                    /*We join the two halves back together by adding a card from each one at a time*/
                    for(int i=0; i < PackOne.Count; i++){
                        pack.Add(PackOne[i]);
                        pack.Add(PackTwo[i]);
                    }

                    return true;

                }else{ /* When a different number than one or two is chosen no shuffle is performed*/
                    return false;
                }

            }else{ 
                return false; 
            }

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


        

        public static void addCard(List<Card> cards) // Returns a list of card to the pack (Additional Method)
        {
            pack.AddRange(cards);
        }



        public List<Card> dealCard(int amount, myHand Hand) // Deals multiple cards from the deck
        {
            if(amount >= pack.Count) // Guard clause if user tries to deal more cards than is left in the pack -> will empty pack
            {
                amount = pack.Count;
            }

            List<Card> cards = new List<Card>();

            for(int i=0; i < amount; i++)
            {
                cards.Add(pack[0]);
                
                if(Hand.DrawCard(pack[0]) != null){
                    Console.WriteLine("Hand is full, no further cards will be dealt.");
                    return null;
                }
                pack.RemoveAt(0);
            }
             
            return cards;
        }

    }

}
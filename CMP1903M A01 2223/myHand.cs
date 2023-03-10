using System;
using System.Collections.Generic;
using System.Linq;


namespace CMP1903M_A01_2223{


	/*ADDITIONAL CLASS*/
	class myHand
	{

		private List<Card> hand = new List<Card>();
		private string _typename;
		private int _typecode;
		private int _max;

		public int TypeCode{
			
			get { return _typecode; }
			set {
				/*Checks that the value is within the predicted parameters*/
				if (value > 0 && value< 3){ 

					_typecode = value;
				}
			}
		}

		
		public Card DrawCard(Card drawnCard){ /*This Method adds a card that is dealt from the deck to the hand.*/
			if (hand.Count() < _max){
				hand.Add(drawnCard);
				return null;
            }else{							  /*If the hand is full the function will return the drawn card back*/
				Console.WriteLine("Unable to add card to the hand: Hand is full.");
				return drawnCard;
            }
			
		}

		public void ShowHand(){ /*This method shows the full contents of a hand*/

			Console.WriteLine("\n\nCards in " + _typename + " hand:");

			if (hand != null){ /*we make sure that the hand isn't empty before we show it.*/

				

				for (int i = 0; i < hand.Count(); i++){
					Console.WriteLine("[" + i + "]: " + hand[i].Name + " [" + hand[i].Value + "|" + hand[i].Suit + "]");
				}

			} else{
				Console.WriteLine("\n\nThe Hand is Empty");


			}
			
        }

		public myHand(int type){

		  /*Same integrity checks as before but this time if the value is 
         *found outside of the parameters it's set to a default value of 1*/
			if (type > 0 && type < 3){
				_typecode = type;
			}else{
				_typecode = 1;
			}

			switch (TypeCode) { 
				/*Texas Hold Em Poker*/
				case 1: 
					_max = 2;
					_typename = "Texas Hold Em Poker";
				break;
				/*Five Card Draw Poker*/
				case 2:
					_max = 5;
					_typename = "Five Card Draw Poker";
				break;
				/*Default*/
				default:
					_max = 2;
					_typename = "!Texas Hold Em Poker!";
				break;
			}
		}

	}

}

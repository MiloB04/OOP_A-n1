

class Card{

    private int _value;
    private int _suit;
    private string _name;

    public int Value{

        get { return _value; }
        set{
            if (value > 0 && value < 14){ /*Checks that the value is within the predicted parameters*/
            
                _value = value;
            }
        }

    }

    public int Suit { 

        get { return _suit; } 
        set { 
                if (value > 0 && value < 5) { /*Checks that the value is within the predicted parameters*/
                
                    _suit = value;
                }
            } 

    }
    
    public string Name {
    
        get { return _name; }
        set { _name = ChangeName();    }
    
    }

    /*ADDITIONAL METHOD*/
    public string ChangeName(){

        string valueName;
        string suitName;
        string cardName;

        switch (_value){     
              /* Through the use of nested switch cases we assign a name that can be used as an output 
               * for each card. The first switch divides them by values and the nested switch divides 
               * Them by suit.                                                                        */

            case 1:     /* Aces */
                valueName = "Ace of ";

                break;

            case 2:     /* Twos */
                valueName = "Two of ";

                break;

            case 3:     /* Three */
                valueName = "Three of ";

                break;

            case 4:     /* Fours */
                valueName = "Four of ";

                break;

            case 5:     /* Fives */
                valueName = "Five of ";

                break;

            case 6:     /* Sixes */
                valueName = "Six of ";

                break;

            case 7:     /* Sevens */
                valueName = "Seven of ";

                break;

            case 8:     /* Eights */
                valueName = "Eight of ";

                break;

            case 9:     /* Nines */
                valueName = "Nine of ";

                break;

            case 10:    /* Tens */
                valueName = "Ten of ";

                break;

            case 11:    /* Jacks */
                valueName = "Jack of ";

                break;

            case 12:    /* Queens */
                valueName = "Queen of ";

                break;

            case 13:  /* Kings */
                valueName = "King of ";

                break;

            default: /*Here to mark an error in the value of the number of the card we mark it with two ! instead of one*/
                valueName = "(!) Ace of ";

                break;
        }

        switch (_suit){
            case 1:
                suitName = "Spades";
                break;

            case 2:
                suitName = "Clubs";
                break;

            case 3:
                suitName = "Hearts";
                break;

            case 4:
                suitName = "Diamonds";
                break;

            default:
                suitName = "(!) Spades";
                break;
        }

        cardName = valueName + suitName;

        return cardName;
    }
    

    public Card(int value, int suit)
    {

        /*Same integrity checks as before but this time if the value is 
         *found outside of the parameters it's set to a default value of 1*/
        if (value > 0 && value < 14){ 
            _value = value;
        } else { 
            _value = 1; 
        }

        if (suit > 0 && suit < 5) { 
           _suit = suit;
        } else {                        
           _suit = 1; 
        }

        _name = ChangeName();
        

    }

}


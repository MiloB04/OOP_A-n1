

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

        string cardname;

        switch (_value){     
              /* Through the use of nested switch cases we assign a name that can be used as an output 
               * for each card. The first switch divides them by values and the nested switch divides 
               * Them by suit.                                                                        */

            case 1:     /* Aces */
                switch (_suit)
                {
                    case 1:
                        cardname = "Ace of Spades";
                        break;

                    case 2:
                        cardname = "Ace of Clubs";
                        break;

                    case 3:
                        cardname = "Ace of Hearts";
                        break;

                    case 4:
                        cardname = "Ace of Diamonds";
                        break;

                    default: /*In case the value falls outside of the valid parameters it's set to the 
                                              * default and we add ! at the start and end of the string to signal it */
                        cardname = "!Ace of Spades!";
                        break;
                }

                break;

            case 2:     /* Twos */
                switch (_suit)
                {
                    case 1:
                        cardname = "Two of Spades";
                        break;

                    case 2:
                        cardname = "Two of Clubs";
                        break;

                    case 3:
                        cardname = "Two of Hearts";
                        break;

                    case 4:
                        cardname = "Two of Diamonds";
                        break;

                    default:
                        cardname = "!Two of Spades!";
                        break;
                }

                break;

            case 3:     /* Three */
                switch (_suit)
                {
                    case 1:
                        cardname = "Three of Spades";
                        break;

                    case 2:
                        cardname = "Three of Clubs";
                        break;

                    case 3:
                        cardname = "Three of Hearts";
                        break;

                    case 4:
                        cardname = "Three of Diamonds";
                        break;

                    default:
                        cardname = "!Three of Spades!";
                        break;
                }

                break;

            case 4:     /* Fours */
                switch (_suit)
                {
                    case 1:
                        cardname = "Four of Spades";
                        break;

                    case 2:
                        cardname = "Four of Clubs";
                        break;

                    case 3:
                        cardname = "Four of Hearts";
                        break;

                    case 4:
                        cardname = "Four of Diamonds";
                        break;

                    default:
                        cardname = "!Four of Spades!";
                        break;
                }

                break;

            case 5:     /* Fives */
                switch (_suit)
                {
                    case 1:
                        cardname = "Five of Spades";
                        break;

                    case 2:
                        cardname = "Five of Clubs";
                        break;

                    case 3:
                        cardname = "Five of Hearts";
                        break;

                    case 4:
                        cardname = "Five of Diamonds";
                        break;

                    default:
                        cardname = "!Five of Spades!";
                        break;
                }

                break;

            case 6:     /* Sixes */
                switch (_suit)
                {
                    case 1:
                        cardname = "Six of Spades";
                        break;

                    case 2:
                        cardname = "Six of Clubs";
                        break;

                    case 3:
                        cardname = "Six of Hearts";
                        break;

                    case 4:
                        cardname = "Six of Diamonds";
                        break;

                    default:
                        cardname = "!Six of Spades!";
                        break;
                }

                break;

            case 7:     /* Sevens */
                switch (_suit)
                {
                    case 1:
                        cardname = "Seven of Spades";
                        break;

                    case 2:
                        cardname = "Seven of Clubs";
                        break;

                    case 3:
                        cardname = "Seven of Hearts";
                        break;

                    case 4:
                        cardname = "Seven of Diamonds";
                        break;

                    default:
                        cardname = "!Seven of Spades!";
                        break;
                }

                break;

            case 8:     /* Eights */
                switch (_suit)
                {
                    case 1:
                        cardname = "Eight of Spades";
                        break;

                    case 2:
                        cardname = "Eight of Clubs";
                        break;

                    case 3:
                        cardname = "Eight of Hearts";
                        break;

                    case 4:
                        cardname = "Eight of Diamonds";
                        break;

                    default:
                        cardname = "!Eight of Spades!";
                        break;
                }

                break;

            case 9:     /* Nines */
                switch (_suit)
                {
                    case 1:
                        cardname = "Nine of Spades";
                        break;

                    case 2:
                        cardname = "Nine of Clubs";
                        break;

                    case 3:
                        cardname = "Nine of Hearts";
                        break;

                    case 4:
                        cardname = "Nine of Diamonds";
                        break;

                    default:
                        cardname = "!Nine of Spades!";
                        break;
                }

                break;

            case 10:    /* Tens */
                switch (_suit)
                {
                    case 1:
                        cardname = "Ten of Spades";
                        break;

                    case 2:
                        cardname = "Ten of Clubs";
                        break;

                    case 3:
                        cardname = "Ten of Hearts";
                        break;

                    case 4:
                        cardname = "Ten of Diamonds";
                        break;

                    default:
                        cardname = "!Ten of Spades!";
                        break;
                }

                break;

            case 11:    /* Jacks */
                switch (_suit)
                {
                    case 1:
                        cardname = "Jack of Spades";
                        break;

                    case 2:
                        cardname = "Jack of Clubs";
                        break;

                    case 3:
                        cardname = "Jack of Hearts";
                        break;

                    case 4:
                        cardname = "Jack of Diamonds";
                        break;

                    default:
                        cardname = "!Jack of Spades!";
                        break;
                }

                break;

            case 12:    /* Queens */
                switch (_suit)
                {
                    case 1:
                        cardname = "Queen of Spades";
                        break;

                    case 2:
                        cardname = "Queen of Clubs";
                        break;

                    case 3:
                        cardname = "Queen of Hearts";
                        break;

                    case 4:
                        cardname = "Queen of Diamonds";
                        break;

                    default:
                        cardname = "!Queen of Spades!";
                        break;
                }

                break;

            case 13:  /* Kings */
                switch (_suit)
                {
                    case 1:
                        cardname = "King of Spades";
                        break;

                    case 2:
                        cardname = "King of Clubs";
                        break;

                    case 3:
                        cardname = "King of Hearts";
                        break;

                    case 4:
                        cardname = "King of Diamonds";
                        break;

                    default:
                        cardname = "!King of Spades!";
                        break;
                }

                break;

            default: /*Here to mark an error in the value of the number of the card we mark it with two ! instead of one*/
                cardname = "!!Ace of Spades!!";

                break;
        }

        return cardname;
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




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
        set {}
    
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

        if (value > 0 && value < 5) { 
           _suit = suit;
        } else {                        
           _suit = 1; 
        }

        switch (value){     /* Through the use of nested switch cases we assign a name that can be used as an output 
                             * for each card. The first switch divides them by values and the nested switch divides 
                             * Them by suit.                                                                        */

                case 1:     /* Aces */
                                switch (suit){
                                    case 1:
                                        _name = "Ace of Spades";
                                    break;

                                    case 2:
                                        _name = "Ace of Clubs";
                                    break;

                                    case 3:
                                        _name = "Ace of Hearts";
                                    break;

                                    case 4:
                                        _name = "Ace of Diamonds";
                                    break;

                                    default: /*In case the value falls outside of the valid parameters it's set to the 
                                              * default and we add ! at the start and end of the string to signal it */
                                        _name = "!Ace of Spades!";
                                    break;
                                }
                    
                break;

                case 2:     /* Twos */
                                switch (suit){
                                    case 1:
                                        _name = "Two of Spades";
                                    break;

                                    case 2:
                                        _name = "Two of Clubs";
                                    break;

                                    case 3:
                                        _name = "Two of Hearts";
                                    break;

                                    case 4:
                                        _name = "Two of Diamonds";
                                    break;

                                    default:
                                        _name = "!Two of Spades!";
                                    break;
                                }
                   
                break;

                case 3:     /* Three */
                                switch (suit){
                                    case 1:
                                        _name = "Three of Spades";
                                    break;

                                    case 2:
                                        _name = "Three of Clubs";
                                    break;

                                    case 3:
                                        _name = "Three of Hearts";
                                    break;

                                    case 4:
                                        _name = "Three of Diamonds";
                                    break;

                                    default:
                                        _name = "!Three of Spades!";
                                    break;
                                }
                    
                break;

                case 4:     /* Fours */
                                switch (suit){
                                    case 1:
                                        _name = "Four of Spades";
                                    break;

                                    case 2:
                                        _name = "Four of Clubs";
                                    break;

                                    case 3:
                                        _name = "Four of Hearts";
                                    break;

                                    case 4:
                                        _name = "Four of Diamonds";
                                    break;

                                    default:
                                        _name = "!Four of Spades!";
                                    break;
                                }
                    
                break;

                case 5:     /* Fives */
                                switch (suit){
                                    case 1:
                                        _name = "Five of Spades";
                                    break;

                                    case 2:
                                        _name = "Five of Clubs";
                                    break;

                                    case 3:
                                        _name = "Five of Hearts";
                                    break;

                                    case 4:
                                        _name = "Five of Diamonds";
                                    break;

                                    default:
                                        _name = "!Five of Spades!";
                                    break;
                                }
                    
                break;
                
                case 6:     /* Sixes */
                                switch (suit){
                                    case 1:
                                        _name = "Six of Spades";
                                    break;

                                    case 2:
                                        _name = "Six of Clubs";
                                    break;

                                    case 3:
                                        _name = "Six of Hearts";
                                    break;

                                    case 4:
                                        _name = "Six of Diamonds";
                                    break;

                                    default:
                                        _name = "!Six of Spades!";
                                    break;
                                }
                   
                break;

                case 7:     /* Sevens */
                                switch (suit){
                                    case 1:
                                        _name = "Seven of Spades";
                                    break;

                                    case 2:
                                        _name = "Seven of Clubs";
                                    break;

                                    case 3:
                                        _name = "Seven of Hearts";
                                    break;

                                    case 4:
                                        _name = "Seven of Diamonds";
                                    break;

                                    default:
                                        _name = "!Seven of Spades!";
                                    break;
                                }
                    
                break;

                case 8:     /* Eights */
                                switch (suit){
                                    case 1:
                                        _name = "Eight of Spades";
                                    break;

                                    case 2:
                                        _name = "Eight of Clubs";
                                    break;

                                    case 3:
                                        _name = "Eight of Hearts";
                                    break;

                                    case 4:
                                        _name = "Eight of Diamonds";
                                    break;

                                    default:
                                        _name = "!Eight of Spades!";
                                    break;
                                }
                    
                break;

                case 9:     /* Nines */
                                switch (suit){
                                    case 1:
                                        _name = "Nine of Spades";
                                    break;

                                    case 2:
                                        _name = "Nine of Clubs";
                                    break;

                                    case 3:
                                        _name = "Nine of Hearts";
                                    break;

                                    case 4:
                                        _name = "Nine of Diamonds";
                                    break;

                                    default:
                                        _name = "!Nine of Spades!";
                                    break;
                                }
                    
                break;

                case 10:    /* Tens */
                                switch (suit){
                                    case 1:
                                        _name = "Ten of Spades";
                                    break;

                                    case 2:
                                        _name = "Ten of Clubs";
                                    break;

                                    case 3:
                                        _name = "Ten of Hearts";
                                    break;

                                    case 4:
                                        _name = "Ten of Diamonds";
                                    break;

                                    default:
                                        _name = "!Ten of Spades!";
                                    break;
                                }
                    
                break;

                case 11:    /* Jacks */
                                switch (suit){
                                    case 1:
                                        _name = "Jack of Spades";
                                    break;

                                    case 2:
                                        _name = "Jack of Clubs";
                                    break;

                                    case 3:
                                        _name = "Jack of Hearts";
                                    break;

                                    case 4:
                                        _name = "Jack of Diamonds";
                                    break;

                                    default:
                                        _name = "!Jack of Spades!";
                                    break;
                                }
                    
                break;

                case 12:    /* Queens */
                                switch (suit){
                                    case 1:
                                        _name = "Queen of Spades";
                                    break;

                                    case 2:
                                        _name = "Queen of Clubs";
                                    break;

                                    case 3:
                                        _name = "Queen of Hearts";
                                    break;

                                    case 4:
                                        _name = "Queen of Diamonds";
                                    break;

                                    default:
                                        _name = "!Queen of Spades!";
                                    break;
                                }
                    
                break;

                case 13:  /* Kings */
                                switch (suit){
                                    case 1:
                                        _name = "King of Spades";
                                    break;

                                    case 2:
                                        _name = "King of Clubs";
                                    break;

                                    case 3:
                                        _name = "King of Hearts";
                                    break;

                                    case 4:
                                        _name = "King of Diamonds";
                                    break;

                                    default:
                                        _name = "!King of Spades!";
                                    break;
                                }
                  
                break;

                default: /*Here to mark an error in the value of the number of the card we mark it with two ! instead of one*/
                    _name = "!!Ace of Spades!!";
                    
                break;
            }

    }

}


import java.security.SecureRandom;

// this class represents a deck which contains an array of 52 cards
public class DeckOfCards {
    private static final int NUMBER_OF_CARDS = 52; // private, static, final because I don't want to share this data
    private Card[] deck = new Card[NUMBER_OF_CARDS]; // use constant to initialize array, it's a list of NULL

    // keeps the current index, used for when I deal a card
    private int currentCard = 0;
    // random number generator to swap cards
    private static final SecureRandom randomNumbers = new SecureRandom();

    // constructor > what's the starting value of the deck?
    public DeckOfCards() {
        // GENERATE 52 CARDS
        String[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack",
                "Queen", "King" }; // 13 different values
        String[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" }; // 4 different values

        // iterate through each card in the deck
        for (int count = 0; count < deck.length; count++) {
            // every time initialize a new card with a face and a suit
            // System.out.println(count + " % " + 13 + " = " + (count % 13));
            Card myCard = new Card(faces[count % 13], suits[count / 13]);
            deck[count] = myCard;
        }
    }

    // what do I do with a deck? 2 methods
    public void shuffle() {
        // variable to keep the next card in the deck
        currentCard = 0;
        // one-pass algorithm
        for (int a = 0; a < deck.length; a++) {
            // select a random card in the deck
            int b = randomNumbers.nextInt(NUMBER_OF_CARDS);
            Card temp = deck[a]; // my current card
            // swap a with b and b with temp
            deck[a] = deck[b];
            deck[b] = temp;
        }
    }

    public Card dealCard() {
        if (currentCard < deck.length) {
            // I still have cards in the deck
            Card myCard = deck[currentCard];
            currentCard++; // move to next position for next time
            return myCard;
        } else {
            // I ran out of cards
            return null;
        }
    }

}

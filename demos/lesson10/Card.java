// this is a class representing 1 standard card
public class Card {
    private final String suit; // sign > hearts diamonds spades clubs
    private final String face; // number or value > ace, 2, 4.... Queen King
    
    public Card(String cardFace, String cardSuit) {
        this.face = cardFace;
        this.suit = cardSuit;
    }
    // need to have a method to "show" this card
    public String toString() {
        return face + " of " + suit; // e.g. Ace of Hearts
    }
}

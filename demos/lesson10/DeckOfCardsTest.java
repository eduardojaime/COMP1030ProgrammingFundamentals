public class DeckOfCardsTest {
    public static void main(String[] args) {
        DeckOfCards myDeck = new DeckOfCards();
        // display cards before shuffling
        for (int i = 1; i <= 52; i++) {
            Card currentCard = myDeck.dealCard(); // get a card from the deck
            System.out.println(currentCard.toString()); // print the value
        }

        myDeck.shuffle();

        // display cards after shuffling
        for (int i = 1; i <= 52; i++) {
            Card currentCard = myDeck.dealCard(); // get a card from the deck
            System.out.println(currentCard.toString()); // print the value
        }
    }
}

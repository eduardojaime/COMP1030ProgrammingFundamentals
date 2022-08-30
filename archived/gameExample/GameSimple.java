import java.util.Scanner;
// > Turn-based RPG-style fighting
// - Amount of points (100)
//      - User
//      - Computer
// - Every turn (while)
//      - Heal, attack
//      - Computer plays > heal or attack 
// - Determine who wins

// This is the class that will run the game logic
// Simple game in this case: 
//  - only one type of attack
//  - plays only one turn
//  - only if statements used
public class GameSimple {
    public static void main(String[] args) {
        // provide instructions to play
        System.out.println("Welcome to Monster Fights!");
        System.out.println("You are a knight and will fight a monster!");
        System.out.println("Every turn you can choose to heal (H) or attack (A)");
        System.out.println("Be careful! The Monster (CPU) will also heal or attack!");

        Scanner scan = new Scanner(System.in);
        int knightHealth = 0;
        int monsterHealth = 0;

        Knight knight = new Knight();
        Monster monster = new Monster();

        knightHealth = knight.GetHealth();
        monsterHealth = monster.GetHealth();

        System.out.println("Do you want to heal (H) or attack (A)?");
        String move = scan.nextLine();

        if (move.equals("A")) {
            int damage = knight.AttackWithExcalibur();
            monster.RecalculateHealth(-damage);
            System.out.println("You used Excalibur! You did " + damage + " in damage!");
        } else {
            System.out.println("Not allowed! You missed a turn!");
        }

        // randomly generate a move by the monster
        // simulating attack
        int damage = monster.AttackWithSpear();
        knight.RecalculateHealth(-damage);
        System.out.println("Monster did " + damage + " in damage!");

        knightHealth = knight.GetHealth();
        monsterHealth = monster.GetHealth();

        // what to do if by the end of the turn someone lost all their health?
        if (knightHealth <= 0) {
            System.out.println("You lose!");
        }
        if (monsterHealth <= 0) {
            System.out.println("You win!");
        }
    }
}

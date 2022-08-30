public class Monster {
    private int Health;
    private boolean hasUsedDarkSword;

    public Monster() {
        hasUsedDarkSword = false;
        Health = 100;
    }

    // can take positive or negative values
    public void RecalculateHealth(int value) {
        this.Health += value;
    }

    public int GetHealth() {
        return this.Health;
    }

    public int AttackWithSpear() {
        return 10;
    }

    public int AttackWithDarkSword() {
        if (hasUsedDarkSword) {
            return 0;
        } else {
            hasUsedDarkSword = true;
            return 500;
        }
    }
}

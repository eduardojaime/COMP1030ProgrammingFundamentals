public class Knight {
    private int Health = 100;
    private boolean hasUsedExcalibur;

    public Knight() {
        hasUsedExcalibur = false;
        Health = 100;
    }

    // can take positive or negative values
    public void RecalculateHealth(int value) {
        this.Health += value;
    }

    public int GetHealth() {
        return this.Health;
    }

    public int AttackWithSword() {
        return 10;
    }

    public int AttackWithExcalibur() {
        if (hasUsedExcalibur) {
            return 0;
        } else {
            hasUsedExcalibur = true;
            return 1000;
        }
    }
}

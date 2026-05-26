using UnityEngine;
public class Dihydrogen_Monoxide : Compound {
    protected override void attack() {
        timer += Time.deltaTime;
        if (timer >= attackCooldown) {
            timer = 0f;
            // Instantiate projectile here
        }
    }
}

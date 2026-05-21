using UnityEngine;
public class H2O : Compound {
    protected override void attack() {
        timer += Time.deltaTime;
        if (timer >= attackCooldown) {
            timer = 0f;
            // Instantiate projectile here
        }
    }
}
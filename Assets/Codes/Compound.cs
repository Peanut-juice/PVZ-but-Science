using UnityEngine;
public abstract class Compound : MonoBehaviour {
    public int cost;
    public float attackCooldown, health, placementCooldown, timer;
    public float X { get; private set; }
    public float Y { get; private set; }
    protected virtual void Awake() {
        X = transform.position.x;
        Y = transform.position.y;
    }
    public void isEaten(float damage) {
        health -= damage;
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
    protected abstract void attack();
    void Update() { 
        attack();
    }
}

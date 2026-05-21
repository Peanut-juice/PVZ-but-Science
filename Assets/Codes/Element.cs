using UnityEngine;
public abstract class Element : MonoBehaviour {
    public float speed, health, damage, drop;
    public float X { get; private set; }
    public float Y { get; private set; }
    protected virtual void Awake() {
        X = transform.position.x;
        Y = transform.position.y;
    }
    public abstract void moveLeft();
    public bool checkForPlant(Compound C) {
        if (X == C.X && Y == C.Y) {
            C.isEaten(damage);
            return true;
        }
        return false;
    }
    public void isDefeated(float damage) {
        health -= damage;
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
    void Update() { 
        moveLeft();
    }
}

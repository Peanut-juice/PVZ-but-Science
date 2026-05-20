public abstract class Compound : MonoBehaviour {
    public int cost, health;
    public float attackCooldown;
    protected abstract void Attack();
    void Update() { }
}
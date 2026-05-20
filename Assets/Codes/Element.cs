public abstract class Zombie : MonoBehaviour {
    public float speed, health, damage;
    void Update() { MoveLeft(); CheckForPlant(); }
}
using UnityEngine;
public class Alpha_particle : MonoBehaviour {
    public float X { 
        get; 
        private set; 
    }
    public float Y { 
        get; 
        private set; 
    }
    private void Awake() {
        X = transform.position.x;
        Y = transform.position.y;
    }
    private void collision(Element element) {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, 0.5f);
        if (hit != null && hit.GetComponent<Element>() != null) {
            Destroy(hit.GetComponent<Element>());
        }
    }
    public void moveRight() {
        transform.Translate(Vector3.right * 2 * Time.deltaTime);
    }
    void Update() {
        moveRight();
    }
}
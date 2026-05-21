using UnityEngine;
public class Hydrogen : Element {
    public override void moveLeft() {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
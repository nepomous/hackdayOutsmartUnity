using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stomper : MonoBehaviour
{
    public int damageToDeal;
    private Rigidbody2D _rigidbody2D;
    public float bounceForce;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = transform.parent.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "HurtBox") {
            other.gameObject.GetComponent<EnemyHP>().TakeDamage(damageToDeal);
            _rigidbody2D.AddForce(transform.up * bounceForce, ForceMode2D.Impulse);
        }
    }
}

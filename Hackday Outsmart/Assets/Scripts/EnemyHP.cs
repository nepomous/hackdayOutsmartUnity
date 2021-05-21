using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int enemyHP;
    private int currentHP;
    private Animator animator;
    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = enemyHP;
        animator = transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHP <= 0) {
            isDead = true;
            animator.SetBool("Dead", isDead);
            StartCoroutine("KillSwitch");
        }
    }

    public void TakeDamage(int damage) {
        currentHP -= damage;
    }

    IEnumerator KillSwitch() {
        yield return new WaitForSeconds(0.5f);
        Destroy(transform.parent.gameObject);
    }
}

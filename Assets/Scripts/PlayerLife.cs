using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator anim;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            Death();
        }
    }


    private void Death()
    {
        rb.bodyType = RigidbodyType2D.Static;
        GetComponent<heroMovement>().enabled = false;
        anim.SetTrigger("death");
        Debug.Log("öldün");
    }

    
    
}

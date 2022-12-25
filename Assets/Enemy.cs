using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    
    public int maxHealth = 100; // su an icin maxhealth 100 dedik zaten bu degiskenlerimizi unity icinden dusmanlara gore kolayca degistirebilecegimiz icin farkli dusmanlara farkli canlar verebilecegiz.
    int currentHealth; //toplam can ve anlik can icin degiskenlerimizi olusturduk.
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // diger scriptimizden de cagirabilmek icin damage fonksiyonumuzu public olarak hazirliyoruz.
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // o anki canimizdan aldigimiz hasari cikariyoruz.

        // hasar alma animasyonu farkli dusmanlar icin farkli animasyonlar bu kisima eklenebilir.
        animator.SetTrigger("Hurt");

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died!");

        // Die icin animasyon
        animator.SetBool("IsDead", true);

        // dusman yok oldugu icin dusmani kaldirmak.
        // once collideri devre disi birakip dusmanin hitboxini kapatiyoruz daha sonra ise bu scripti devre disi birakarak dusmanin ozelliklerini kapatmis oluyoruz.
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
  
}

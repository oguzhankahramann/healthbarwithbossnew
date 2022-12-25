using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

    public Transform attackPoint; //kilicimizin attack noktasini referans edecegimiz degisken
    public LayerMask enemyLayers; //dusman layeri olusturup tum dusmanlari o layeri koyup hangi nesnelerin dusman oldugunu anliyoruz
    public float attackRange = 0.5f; //saldiri alanimiz icin bir deger olusturuyoruz
    public int attackDamage = 35;
   
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

    }

    void Attack()
    {
        // attack animasyonunu calistirma
        animator.SetTrigger("Attack");

        // attack range içinde bulunan düsman/nesneleri algilamak
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers); // bu fonksiyon attackPointimizin etrafýnda bir alan olusturarak bu alanin carptigi objeleri tutacak, bu degerleri arraye atýyoruz.
        
        // hasar vermek
        foreach(Collider2D enemy in hitEnemies) 
        {

            // Debug.Log("dusmana vurdunuz" + enemy.name); = denemeler yaparken konsolda gormek icin kullandigimiz kod
            enemy.GetComponent<BossHealth>().TakeDamage(attackDamage);

        }

    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }


}

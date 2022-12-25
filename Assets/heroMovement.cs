using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator; 

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Start is called before the first frame update
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        // animatorda olusturdugumuz speed degiskenini yatay harekete bagladik.yatay hareket oldugunda 
        // movespeed degiskeninin degeri artacak ve movespeed degeri >0.01 oldugu icin animasyon calisacak.
        // sola gittigimizde deger negatif olacak ama mathf abs fonksiyonu ile pozitiflestirerek sorunu cözdük.
        animator.SetFloat("MoveSpeed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    public Animator animator;

    private void Start()
    {
        //Ao iniciar o jogo, acessa o Rigidbody2D do personagem
        rb = GetComponent<Rigidbody2D>();
    }

    private void update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }

    private void FixedUpdate()
    {

        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
            
        // Responsável por ativar as animações
        animator.SetFloat("Horizontal", moveH);
        animator.SetFloat("Vertical", moveV);
        animator.SetFloat("Speed", rb.linearVelocity.magnitude);

        // Vira o personagem baseado no movimento
        transform.localScale = new Vector3(moveH < 0 ? -1 : 1, 1, 1);
    }


}

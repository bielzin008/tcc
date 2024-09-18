using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed; // Velocidade de movimento do jogador

    Animator anim;
    Rigidbody2D rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>(); // Obtém o componente Rigidbody2D no início
    }

    void Update()
    {
       Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

       anim.SetFloat("Horizontal", move.x);
       anim.SetFloat("Vertical", move.y);
       anim.SetFloat("Speed", move.magnitude);

       transform.position = transform.position + move * speed * Time.deltaTime;
    }

    
}
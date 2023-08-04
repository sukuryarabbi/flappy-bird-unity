using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public Rigidbody2D rigi;

    [SerializeField]
    private GameObject DeathScreen;

    [SerializeField]
    float JumpForce ;

   
    
    void Start()
    {
        Time.timeScale = 1f;
        DeathScreen.SetActive(false);

        rigi = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigi.AddForce(new Vector2(rigi.velocity.x, JumpForce));

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "scoring")
        {
            FindObjectOfType<GameManager>().ArtiSkor();
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "borular")
        {
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
            
        }
    }
}

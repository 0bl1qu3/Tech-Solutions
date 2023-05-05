using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterScript : MonoBehaviour
{

    public float speed = 5f;
    public BoxCollider2D Person;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.position += new Vector3(horizontal, 0f) * speed * Time.deltaTime;


        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {

        if(collision.gameObject.CompareTag("Choice1"))
        {
            Debug.Log("Collided with Choice 1");

        } 
        
        if(collision.gameObject.CompareTag("Choice2"))
        {
            Debug.Log("Collided with Choice 2");
        }

    }
}

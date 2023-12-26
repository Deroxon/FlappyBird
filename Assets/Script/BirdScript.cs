using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D rigidbody2D;

    public float flapStrength;

    public LogicScript logic;

    public bool birdIsAlive = true;

   
    public Sprite wingsDown, wingsUp;
 
    public SpriteRenderer wingsSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        wingsSpriteRenderer = GameObject.FindGameObjectWithTag("wings").GetComponent<SpriteRenderer>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        // starting timer
        StartCoroutine(CourutineFunction());
    }

    IEnumerator CourutineFunction()
    {
        while (true)
        {
            moveWings();


            yield return new WaitForSeconds(0.4f);
        }
    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            rigidbody2D.velocity = Vector2.up * flapStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        logic.GameOver();
        birdIsAlive = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // collision of wall
        if (collision.gameObject.layer == 6)
        {

            logic.GameOver();
            birdIsAlive = false;
        }

    }

    private void moveWings()
    {

        if (wingsSpriteRenderer.sprite.name == "down")
        {
            wingsSpriteRenderer.sprite = wingsUp;
        }
        else
        {
            wingsSpriteRenderer.sprite = wingsDown;
        }
    }
}

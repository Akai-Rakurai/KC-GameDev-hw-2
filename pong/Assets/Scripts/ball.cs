using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{   
    public float speed;
    Rigidbody2D RB;
    public GameObject Wall1;
    public GameObject Wall2;
    public AudioSource C;

    // Start is called before the first frame update
    void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();
        Launch();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    }

    void Launch()
    {
        float direction = Random.Range(0,2);
        if (direction == 0f)
        {
            RB.velocity = new Vector2(-speed, 0);
        }
        else
        {
            RB.velocity = new Vector2(speed, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ResetWall")
        {
           transform.position = new Vector2(0, 0);
           Wall2.transform.position = new Vector2(10, 0);
           Wall1.transform.position = new Vector2(-10, 0);
           C.Play();
           Launch();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigid;
    private Vector2 change;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector2.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        movePlayer();
    }

    void movePlayer ()
    {
        myRigid.MovePosition(myRigid.position + change * speed * Time.deltaTime);
    }
}

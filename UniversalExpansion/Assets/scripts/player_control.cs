using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigid;
    private Vector3 change;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (change != Vector3.zero)
        movePlayer();
    }

    void movePlayer ()
    {
        myRigid.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogescript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flap;
    public LogicScript logic;
    public bool dogealive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && dogealive)
        {
            myRigidBody.velocity = Vector2.up * flap;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOverScreen();
        dogealive = false;
    }
}

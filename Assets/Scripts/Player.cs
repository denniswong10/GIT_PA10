using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
            GameManager.thisManager.GameOver();
    }

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void PlayerJumper()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            thisAnimation.Play();

        PlayerJumper();

        if (transform.position.y <= -5)
            GameManager.thisManager.GameOver();
    }
}

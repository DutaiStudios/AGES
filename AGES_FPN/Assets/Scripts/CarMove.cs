using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CarMove : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float minspeed;
    [SerializeField] float maxspeed;
    [SerializeField] float horizontalInput;
    [SerializeField] float turnspeed;
    [SerializeField] float speedinc;
    public bool text1 = false;
    public bool text2 = false;
    public bool text3 = false;
    public bool text4 = false;
    public bool titletext = false;



    // Start is called before the first frame update
    void Start()
    {
        Rigidbody car = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
        speedup();
    }

    void speedup()
    {

        if (speed <= 0)
        {
            speed = minspeed;
        }

        if (speed >= 1.3)
        {
            speed = maxspeed;
        }
        transform.Translate(0, 0, speed);

        if (Input.GetButtonDown("Jump"))
            {
                speed += speedinc;
            turnspeed += speedinc;
            }

        if (Input.GetButtonDown("Fire3"))
        {
            speed -= speedinc;
            turnspeed -= speedinc;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Text1")
        {
            text1 = true;
        }

        if (collision.gameObject.name == "Text2")
        {
            text1 = false;
            text2 = true;
        }

        if (collision.gameObject.name == "Text3")
        {
            text2 = false;
            text3 = true;
        }

        if (collision.gameObject.name == "Text4")
        {
            text3 = false;
            text4 = true;
        }

        if (collision.gameObject.name == "FinText")
        {
            text4 = false;
            titletext = true;
        }

        if (collision.gameObject.name == "SceneChange")
        {
            SceneManager.LoadScene("Area1");
        }
    }



}

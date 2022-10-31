using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float hInput;
    public float speed;

    private float xRange = 17.2f;

    public GameObject laserBolt;
    public Transform blaster;

    private AudioSource blasterAudio;
    public AudioClip laserBlast;

    // Start is called before the first frame update
    void Start()
    {
        blasterAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set horizontal input to recieve values from the keyboard keymap horizontal -1 - 1
        hInput = Input.GetAxis("Horizontal");

        //Move the Player left and right
        transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);

        //Keeps Player within 10.4 position on screen
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //Keeps Player within -10.4 position on screen
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            blasterAudio.PlayOneShot(laserBlast,1.0f);
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
    }
}

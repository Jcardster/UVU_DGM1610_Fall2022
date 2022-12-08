using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement")]
    public float moveSpeed;
    public float jumpForce;
    [Header("Camera")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    private float rotX;
    private Camera camera;
    private Rigidbody rb;
    [Header("Player Stats")]
    public int maxHp;
    public int curHp;
    //private Weapon weapon;

    void Awake()
    {
        //weapon = GetComponent<Weapon>();
        curHp = maxHp;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Get Components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();

        //Initialize the UI
        //GameUI.instance.UpdateHealthBar(curHp, maxHp);
        //GameUI.instance.UpdateScoreText(0);
        //GameUI.instance.UpdateAmmoText(weapon.curAmmo, weapon.maxAmmo);
    }

    public void TakeDamage(int damage)
    {
        curHp -= damage;

        if(curHp <= 0)
        {
            Die();
        }
        //GameUI.instance.UpdateHealthBar(curHp, maxHp);
    }

    void Die()
    {
        //GameManager.instance.LoseGame();
        Debug.Log("Player had died! Game Over");
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraLook();

        //Fire Button
        if(Input.GetButton("Fire1"))
        {
            //if(weapon.CanShoot())
            //{
            //    weapon.Shoot();
            //}
            Debug.Log("Player shoots!");
        }    

        //Jump Button
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        //Don't do anything if the game is paused
        //if (GameManager.instance.gamePaused == true)
            //return;
    }


    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; //Getting input for left and right movement
        float z = Input.GetAxis("Vertical") * moveSpeed; //Getting input for forward and back movement
        //Walk in the direction we are facing
        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y;
        rb.velocity = dir; //Applying velocity to the x and z axis to drive player
    }


    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity; //Look up and down
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity; //Look left and right

        rotX = Mathf.Clamp(rotX, minLookX, maxLookX); //Constrains Camera
        // Drives Camera rotation
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void Jump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(ray, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void GiveHealth(int amountToGive)
    {
        //curHp = Mathf.Clamp(curHp + amountToGive, 0, maxHp);
        //GameUI.instance.UpdateHealthBar(curHp, maxHp);
        Debug.Log("Player has been healed!");
    }

    public void GiveAmmo(int amountToGive)
    {
        //weapon.curAmmo = Mathf.Clamp(weapon.curAmmo + amountToGive, 0, weapon.maxAmmo);
        //GameUI.instance.UpdateAmmoText(weapon.curAmmo, weapon.maxAmmo);
        Debug.Log("Player has collected ammo!");
    }

}

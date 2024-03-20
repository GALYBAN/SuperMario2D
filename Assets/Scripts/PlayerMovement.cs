using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rBody;

    public GroundSensor sensor; 

    public SpriteRenderer render; 

    public Animator anim;

    AudioSource source;

    public Vector3 newPosition = new Vector3(50, 5, 0);

    public float movementSpeed = 10;
    public float jumpForce = 10;

    private float inputHorizontal;

    public bool jump = false;

    public AudioClip jumpSound;

    public Transform bulletSpawn;
    public GameObject bulletPrefab;

    private bool canShoot = true;

    public float timer;
    
    public float rateOfFire = 1;


    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Teletransporta al personaje a la posicion de la variable newPosition
        //transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {

        inputHorizontal = Input.GetAxis("Horizontal"); //Los controladores se ponen en el Update

        /*if(jump == true)
        {
            Debug.Log("estoy saltando");
        }
        else
        {
            Debug.Log("estoy en el suelo");
        }*/

        Jump();

        Movement();

        Shoot();

    }

    void FixedUpdate()
    {
        //transform.position = transform.position + new Vector3(1, 0, 0) * movementSpeed * Time.deltaTime;
        //transform.position += new Vector3(inputHorizontal, 0, 0) * movementSpeed * Time.deltaTime;

        rBody.velocity = new Vector2(inputHorizontal * movementSpeed, rBody.velocity.y); //Cuando trabajamos con fisicas de forma continua, trabajamos en el FixedUpdate.
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") & sensor.isGrounded == true) 
        {
            rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            anim.SetBool("IsJumping", true);
            source.PlayOneShot(jumpSound);
        }
    }

    void Movement()
    {
        if(inputHorizontal < 0 )
        {
            //render.flipX = true;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("IsRunning", true);
        }
        else if(inputHorizontal > 0)
        {
            //render.flipX = false;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }
    }

    void Shoot()
    {
        if(!canShoot)
        {
            timer += Time.deltaTime;

            if(timer >= rateOfFire)
            {
                canShoot = true;
                timer = 0;
            }
        }

        if(Input.GetKeyDown(KeyCode.F) && canShoot)
        {
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

            canShoot = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour
{
    public Text winText;
    public AudioSource AudioSource;
    public AudioClip musicone;
    public AudioClip musictwo;
    public AudioClip musicthree;
    public AudioClip musicfour;
    public float speed = 20f;
    public Rigidbody2D rb;
    public float timeLeft = 12.0f;
    public Text timeText;

    private int count;
    private int lives;

    Animator anim;
    Vector2 movement;

    void Start()
    {
        {
            rb = GetComponent<Rigidbody2D>();
            count = 0;
            winText.text = "";
            lives = 1;
            anim = GetComponent<Animator>();
            AudioSource.clip = musicfour;
            AudioSource.PlayDelayed(2.0f);
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetInteger("State", 1);
            transform.localEulerAngles = new Vector3(0, 0,90);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetInteger("State", 1);
            transform.localEulerAngles = new Vector3(0, 0, 270);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetInteger("State", 0);
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetInteger("State", 0);
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
                if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetInteger("State", 1);
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetInteger("State", 1);
            transform.localEulerAngles = new Vector3(0, 0, 180);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetInteger("State", 0);
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetInteger("State", 0);
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }

        timeLeft -= Time.deltaTime;
        timeText.text = (timeLeft).ToString("Time Remaining: 0");
        if (timeLeft < 0)
        {
            winText.text = "You Lose! Game created by Raymond Boysel!";
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Finish"))
        {
            other.gameObject.SetActive(true);
            count = count + 1;
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(true);
            lives = lives - 1;
        }

        if (count == 1)
        {
            winText.text = "You win! Game created by Raymond Boysel!";
            AudioSource.clip = musicone;
            AudioSource.Play();
        }
        if (lives == 0)
        {
            winText.text = "You Lose! Game created by Raymond Boysel!";
            AudioSource.clip = musictwo;
            AudioSource.Play();
            Destroy(gameObject, 5);
            Destroy(rb);
        }
    }
}
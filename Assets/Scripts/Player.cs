using UnityEngine;

public class Player : MonoBehaviour
{
    private float playerSpeed = 8f;
    private float horizontalInput;
    private float verticalInput;

    private float horizontalScreenLimit = 9.5f;
    private float verticalScreenLimit = 6.5f;

    public GameObject bulletPrefab;
    public GameObject shieldObj;

    private AudioSource audioSource;
    private AudioClip ascentClip;
    private AudioClip descentClip;

    void Start()
    {
        // single AudioSource 
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = true;  // sound plays while key is held

        // pull audio from Resource folder
        ascentClip = Resources.Load<AudioClip>("Audio/ascentJet");
        descentClip = Resources.Load<AudioClip>("Audio/descentJet");
    }

    void Update()
    {
        Movement();
        Shooting();
    }

    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = -Input.GetAxis("Vertical");

        // move player
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * playerSpeed);

        // screen limit
        if (transform.position.x > horizontalScreenLimit || transform.position.x <= -horizontalScreenLimit)
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);

        float bottomLimit = -3.4f;
        float topLimit = 0f;
        float clampVert = Mathf.Clamp(transform.position.y, bottomLimit, topLimit);
        transform.position = new Vector3(transform.position.x, clampVert, 0);

        // sound
        //return;
        if (Input.GetKey(KeyCode.W))
        {
            if (audioSource.clip != ascentClip)
            {
                audioSource.clip = ascentClip;
                audioSource.Play();
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (audioSource.clip != descentClip)
            {
                audioSource.clip = descentClip;
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }
	Debug.Log("Hi");
    }

    public void OnTriggerEnter(Collider other)
    {
	// Check if player touched it
        if (other.gameObject.CompareTag("Shield"))
        {
            shieldObj.SetActive(true);
	    ShieldPlayer shieldScript = shieldObj.GetComponent<ShieldPlayer>();
	    StartCoroutine(shieldScript.TurnOffShield());
        }
    } 
}

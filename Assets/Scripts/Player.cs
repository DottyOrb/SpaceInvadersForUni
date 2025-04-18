using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public Projectile laserPrefab;
    public float speed = 5.0f;
    private bool _laserActive;
    private bool PowerUpActive;
    public int lives = 3;
    public TMP_Text LivesText;
    public PauseSystem pauseSystem;
    public GameObject _Beam;
    public GameObject _PowerUp;

    
    

    private void Start()
    {
        _Beam = GameObject.Find("Beam");
        _Beam.SetActive(false);
        //Debug.Log("Start");
    }

    private void Update()
    {
        Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);

        if (this.transform.position.x <= leftEdge.x + 1.0f)
        {
            TransportRight();
        }
        else if (this.transform.position.x >= rightEdge.x - 1.0f)
        {
            TransportLeft();
        }

        if (!PauseSystem.isPaused) 
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
            }

            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }
    }

    private void TransportRight() 
    {
        Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);

        Vector3 position = this.transform.position;
        position.x = rightEdge.x - 1.0f;
        this.transform.position = position;
    }
    private void TransportLeft()
    {
        Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);

        Vector3 position = this.transform.position;
        position.x = leftEdge.x + 1.0f;
        this.transform.position = position;
    }

    private void Shoot()
    {
        if (!_laserActive) 
        {
            Projectile projectile = Instantiate(this.laserPrefab, this.transform.position, Quaternion.identity);
            projectile.destroyed += LaserDestroyed;
            _laserActive = true;
        }   
    }


    private void LaserDestroyed() 
    { 
        _laserActive = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Invader") || other.gameObject.layer == LayerMask.NameToLayer("Missile"))
        {
            lives--;
            LivesText.text = "LIVES: " + lives.ToString();
            if (lives <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("PowerUp"))
        {
            //Debug.Log("Collision1");
            _Beam.SetActive(true);
            //Debug.Log("Collision2");
            StartCoroutine(EndBeam(1));
        }

    }
    private IEnumerator EndBeam(float delay)
    {
        //Debug.Log("hi");
        yield return new WaitForSeconds(delay);
        _Beam.SetActive(false);
        //Debug.Log("EndBeam");
        
    }

}

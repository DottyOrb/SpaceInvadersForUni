using System.Collections;
using System.Threading;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject _Beam;
    //public GameObject _PowerUp;

    private void Start()
    {
        _Beam = GameObject.Find("Beam");
        _Beam.SetActive(false);
        Debug.Log("Start");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.layer == LayerMask.NameToLayer("Player") || other.gameObject.layer == LayerMask.NameToLayer("Laser")) 
        {
            Debug.Log("Collision1");
            _Beam.SetActive(true);
            Debug.Log("Collision2");
            //StartCoroutine(EndBeam(2.0f));
            Invoke("EndBeam", 2);
        }
    }

    private void EndBeam() 
    {
        _Beam.SetActive(false);
    }

    /*private IEnumerator EndBeam(float delay) 
    { 
        yield return new WaitForSeconds(delay);
        _Beam.SetActive(false);
        Debug.Log("EndBeam");
        //_PowerUp.SetActive(false);
    }*/
}

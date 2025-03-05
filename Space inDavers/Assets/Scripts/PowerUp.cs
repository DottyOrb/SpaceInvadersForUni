using System.Collections;
using System.Threading;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    /*public GameObject _Beam;
    public GameObject _PowerUp;

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
            StartCoroutine(EndBeam(3));
        }
    }

    private IEnumerator EndBeam(float delay) 
    {
        Debug.Log("hi");
        yield return new WaitForSeconds(delay);
        _Beam.SetActive(false);
        Debug.Log("EndBeam");
        _PowerUp.SetActive(false);
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class FireManager : MonoBehaviour
{
    private GameObject[] fires;

    void Start()
    {
        fires = GameObject.FindGameObjectsWithTag("Fire");
    }
    public void StartFire()
    {
          foreach (GameObject fire in fires)
        {
            fire.GetComponent<VisualEffect>().Play();
        }
    }
    public void StopFire()
    {
          foreach (GameObject fire in fires)
        {
            fire.GetComponent<VisualEffect>().Stop();
        }
    }
    void OnTriggerEnter(Collider other){
                    Debug.Log("pla");

        if (other.gameObject.tag == "Player"){
            Debug.Log("vla");
        StartFire();
        }
    }

}

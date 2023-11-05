using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(false);
        text2.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
        
    }
    void OnTriggerEnter(Collider other){
        text1.SetActive(true);
    }
    void OnTriggerStay(Collider other){
        if(Input.GetKeyDown(KeyCode.Space)){
            text1.SetActive(false);
            text2.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        text2.SetActive(false);
    }
}

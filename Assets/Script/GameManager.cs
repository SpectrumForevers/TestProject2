using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject house;
    void Start()
    {
        
    }
    public void ActivateObj()
    {
        house.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

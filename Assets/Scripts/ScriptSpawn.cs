using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSpawn : MonoBehaviour
{
    public MeshRenderer floor;
    public MeshRenderer railOne;
    public MeshRenderer railTwo;
    public MeshRenderer railThree;


    // Start is called before the first frame update
    void Start()
    {
        floor = GetComponent<MeshRenderer>();
        floor.enabled = false;
        railOne = GetComponent<MeshRenderer>();
        railOne.enabled = false;
        railTwo = GetComponent<MeshRenderer>();
        railTwo.enabled = false;
        railThree = GetComponent<MeshRenderer>();
        railThree.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        floor.enabled = true;
        railOne.enabled = true;
        railTwo.enabled = true;
        railThree.enabled = true;


    }
}

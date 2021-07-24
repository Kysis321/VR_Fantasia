using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippingSquare : MonoBehaviour
{
    public List<GameObject> squares;

    public List<GameObject> instantiatePoints;






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartSquares()

    {
        foreach (GameObject i in instantiatePoints)
        {
            int r = Random.Range(0,5);
            Instantiate(squares[r], instantiatePoints);

        }

        




    }



}


using UnityEngine;

public class Coin : MonoBehaviour
{
 
    public GameObject coo;


    public void coin()
    {
        Instantiate(coo, new Vector3(0, 0.8f, 0), Quaternion.identity);
    }
    

   



}




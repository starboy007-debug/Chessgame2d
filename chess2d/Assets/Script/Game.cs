using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject Chesspiece;
    void Start()
    {
        Instantiate(Chesspiece, new Vector3(0, 0, -1), Quaternion.identity);
    }

    void Update()
    {
        
    }
}

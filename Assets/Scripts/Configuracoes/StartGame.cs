using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    private Tenus tenus;

    private void Awake() {
        tenus = GetComponent<Tenus>();
    }
    // Start is called before the first frame update
    void Start()
    {
        tenus.Jogar();
    }
}

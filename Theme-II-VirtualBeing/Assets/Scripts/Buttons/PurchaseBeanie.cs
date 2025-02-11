using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseBeanie : MonoBehaviour
{
    [SerializeField] GameObject storeBeanie;
    [SerializeField] GameObject Beanie;
    // Start is called before the first frame update
    void Start()
    {
        storeBeanie.SetActive(true);
        Beanie.SetActive(false);
    }

    // Update is called once per frame
    public void PurchaseBeanies()
    {
        storeBeanie.SetActive (false);
        Beanie.SetActive (true);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrolu : MonoBehaviour {
    public GameObject patlama;
    OyunKontrol oyunKontrolScripti;

    void Start()
    {
        oyunKontrolScripti = GameObject.Find("_Script").GetComponent<OyunKontrol>();
    }
	void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation)as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.167f);
        oyunKontrolScripti.BalonEkle();
    }
}

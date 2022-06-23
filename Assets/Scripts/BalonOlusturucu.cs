using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour {
	public GameObject balon;
	float balonOlusturmaSuresi = 1f;
	float zamansayaci = 0f;
	OyunKontrol okScripti;
	// Use this for initialization
	void Start () {
		okScripti = this.gameObject.GetComponent<OyunKontrol>();
	} 
	
	// Update is called once per frame
	void Update () {
		zamansayaci -= Time.deltaTime;
		int katsayi = (int)(okScripti.zamanSayaci / 10) - 6 ;
		katsayi *= -1;
		if(zamansayaci < 0 && okScripti.zamanSayaci>0)
        {
			GameObject go = Instantiate(balon, new Vector3(Random.Range(-2.74f,2.75f), -6, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
			go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f*katsayi,100f*katsayi), 0));
			zamansayaci = balonOlusturmaSuresi;
        }
	}
}

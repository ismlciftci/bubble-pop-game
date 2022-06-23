using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OyunKontrol : MonoBehaviour {
	public UnityEngine.UI.Text zamanText, balonText;
	public float zamanSayaci = 10;
	int patlayanBalon = 0;
	public GameObject patlama;
	// Use this for initialization
	void Start () {
		balonText.text = "Balon : " + patlayanBalon;
	}

	// Update is called once per frame
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
			SceneManager.LoadScene("giris");

		}
		if (zamanSayaci > 0)
		{
			zamanSayaci -= Time.deltaTime;
			zamanText.text = "Süre : " + (int)zamanSayaci;
        }
        else
        {
			GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
			for(int i =0; i < go.Length; i++)
            {
				GameObject pa = Instantiate(patlama, go[i].transform.position, go[i].transform.rotation) as GameObject;
				Destroy(go[i]);
				Destroy(pa, 0.167f);
            }
        }
	}
	public void BalonEkle()
    {
		patlayanBalon += 1;
		balonText.text = "Balon : " + patlayanBalon;

	}
}

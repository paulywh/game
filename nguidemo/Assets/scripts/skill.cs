using UnityEngine;
using System.Collections;

public class skill : MonoBehaviour {

	public float coldtime = 2;
	
	private bool isstar = false;
	
	private UISprite sprite;
	
	void Awake()
	{
		sprite = transform.Find("onskill").GetComponent<UISprite>();
	}
	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.X) && !isstar)
		{
			sprite.fillAmount = 1;
			isstar = true;
		}
		print ("________________________________");
		if(isstar)
		{
			sprite.fillAmount -= (1f/coldtime) * Time.deltaTime;
			if(sprite.fillAmount <= 0.05f)
			{
				isstar = false;
				sprite.fillAmount = 0;
			}
		}
	}
}

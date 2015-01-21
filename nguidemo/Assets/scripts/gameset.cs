using UnityEngine;
using System.Collections;

public enum GameType
{
	EASY,
	HARD
}

public class gameset : MonoBehaviour 
{
	public float video = 1;

	public GameType gt = GameType.EASY;

	public bool isfull = false;

	public TweenPosition initTP;
	public TweenPosition optoverTP;

	public UIInput input;

	public void clickVideo()
	{
		video = UIProgressBar.current.value;
	}

	public void checkGt()
	{
		//print (UIPopupList.current.value);
		switch (UIPopupList.current.value)
		{
			case "EASY" :
				gt = GameType.EASY;
			break;
			case "HARD" :
				gt = GameType.HARD;
			break;
		}
	}

	public void checkIsfull()
	{
		print ("cccc" + UIToggle.current.value);
		if(UIToggle.current.value)
		{
			isfull = true;
		}
		else
		{
			isfull = false;
		}
	}

	public void optClinc()
	{
		initTP.PlayForward ();
		optoverTP.PlayForward ();
	}

	public void optOver()
	{
		Debug.Log ("*****************************" + input.value);

		initTP.PlayReverse ();
		optoverTP.PlayReverse ();
	}
}
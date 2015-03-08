using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class HelloWorld : MonoBehaviour {
	int i = 0;
	int j = 10;

	// Use this for initialization
	void Start () {
		
		#if UNITY_EDITOR
		string adUnitId = "unused";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-3633792288806137/2413435000";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-3633792288806137/4568152602";
		#else
		string adUnitId = "unexpected_platform";
		#endif
		BannerView bannerview = new BannerView (adUnitId, AdSize.Banner, AdPosition.Bottom);
		AdRequest request = new AdRequest.Builder ().Build ();
		bannerview.LoadAd (request);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI() {
		GUI.skin.label.fontSize = 100;
		i++;
		if (i > 100) {
			i = 0;
			if( j == 10)
			{
				j = 0;
			}
			else
			{
				j = 10;
			}
		}
		GUI.Label (new Rect (10+j, 10+j, Screen.width, Screen.height), "hello world");

	}
}

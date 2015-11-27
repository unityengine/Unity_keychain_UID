using UnityEngine;
using System.Collections;

public class UIDDemoTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Debug.LogError("++++++++++++++++++++++++++++++++++1");
		Debug.LogError("UDID is :"+UID.UDID());
		Debug.LogError("++++++++++++++++++++++++++++++++++2");

		Debug.LogError("++++++++++++++++++++++++++++++++++3");
		Debug.LogError("IDFA is :"+UID.IDFA());
		Debug.LogError("++++++++++++++++++++++++++++++++++4");

		Debug.LogError("++++++++++++++++++++++++++++++++++3");
		Debug.LogError("ChainID is :"+UID.ChainID());
		Debug.LogError("++++++++++++++++++++++++++++++++++4");

		Debug.LogError("++++++++++++++++++++++++++++++++++3");
		Debug.LogError("SetChainID UDID is :"+UID.SetChainID(UID.UDID()).ToString());
		Debug.LogError("++++++++++++++++++++++++++++++++++4");

		Debug.LogError("++++++++++++++++++++++++++++++++++3");
		Debug.LogError("ChainID is :"+UID.ChainID());
		Debug.LogError("++++++++++++++++++++++++++++++++++4");

		Debug.LogError("++++++++++++++++++++++++++++++++++3");
		Debug.LogError("UpChainID 1-9 is :"+UID.UpChainID("123456789").ToString());
		Debug.LogError("++++++++++++++++++++++++++++++++++4");

		Debug.LogError("++++++++++++++++++++++++++++++++++3");
		Debug.LogError("ChainID is :"+UID.ChainID());
		Debug.LogError("++++++++++++++++++++++++++++++++++4");

		Debug.LogError("++++++++++++++++++++++++++++++++++3");
		Debug.LogError("RemoveChainID is :"+UID.RemoveChainID().ToString());
		Debug.LogError("++++++++++++++++++++++++++++++++++4");

		Debug.LogError("++++++++++++++++++++++++++++++++++3");
		Debug.LogError("ChainID is :"+UID.ChainID());
		Debug.LogError("++++++++++++++++++++++++++++++++++4");

	}
	
	// Update is called once per frame
	void Update () {

	}

}

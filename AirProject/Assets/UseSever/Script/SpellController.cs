using UnityEngine;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Vuforia {

public class SpellController : MonoBehaviour {

		public GameObject Fire;
		public GameObject Water;
		public GameObject Thunder;
		public GameObject Soil;

    	int spellSwitch = 0;

		// Use this for initialization
		void Start () {
		
		}

		void Update () {
        	spellSwitch = ReadMsg.spellSwitch;
				
        	if (spellSwitch == 1) {
            	Fire.SetActive( true );
            	Water.SetActive(false);
            	Soil.SetActive(false);
            	Thunder.SetActive(false);
        	} else if (spellSwitch == 2) {
            	Fire.SetActive(false);
            	Water.SetActive( true );
            	Soil.SetActive(false);
            	Thunder.SetActive(false);
        	} else if(spellSwitch == 3) {
            	Fire.SetActive(false);
            	Water.SetActive(false);
            	Soil.SetActive(true);
            	Thunder.SetActive(false);
        	} else if (spellSwitch == 4) {
            	Fire.SetActive(false);
            	Water.SetActive(false);
            	Soil.SetActive(false);
            	Thunder.SetActive(true);
        	} else {
            	Fire.SetActive(false);
            	Water.SetActive(false);
            	Soil.SetActive(false);
            	Thunder.SetActive(false);
        	}
   		}
	}
}

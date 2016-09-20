using UnityEngine;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using UnityEngine.Networking;
using System.Threading;

namespace Vuforia {

	public class ReadMsg : MonoBehaviour {
	
		private Socket s;
		public string ipOrHost = "127.0.0.1";
		public int port = 1234;
	
	    public static int spellSwitch = 0;
	
		TcpClient tcpClient = new TcpClient();
	
	
		// Use this for initialization
		void Start () {
	        if (s == null) {
   	        	//TcpClientを作成し、サーバーと接続する
   	     	    tcpClient.Connect(ipOrHost, port);
   	    	   	Debug.Log("init client");
        	}
    	}
	
		// Update is called once per frame
		void Update () {
       		//サーバーに送信するデータ
			if( AddPlayerOubeBoss.isCompleting ){
        		byte[] data = new byte[1];
        		data[0] = 10;

        		//サーバーにデータを送信する
        		s = tcpClient.Client;
        		s.Send(data, 1, SocketFlags.None);

        		//サーバーから送られたデータを受信する
        		byte[] msg = new byte[10];
					
      	 		s.Receive(msg, 10, SocketFlags.None);
					
   	     		if (msg[0] == 1) {
   	         		spellSwitch = 1;
   	     		} else if (msg[0] == 2) {
   	         		spellSwitch = 2;
   	     		} else if(msg[0] == 3) {
   	        		spellSwitch = 3;
   	     		} else if (msg[0] == 4) {
   	         		spellSwitch = 4;
   	     		} else {
   	         		spellSwitch = 5;
   	    		}
	        	//Debug.Log("spellSwitch:" + spellSwitch);
			}
    	}
	}
}
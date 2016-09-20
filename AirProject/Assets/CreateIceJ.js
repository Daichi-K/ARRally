#pragma strict

var Ice0:Transform;
var Ice1:Transform;
var Ice2:Transform;
var Ice3:Transform;
var Ice4:Transform;

var timecount = 0;
var rand = Random.Range( -1.0, 2.0);
var iceRand = Random.Range( 0, 6);
var interval = 120;
     
function Start () {
}
     
function Update () {
	rand = Random.Range( -1.0, 1.1);
	iceRand = Random.Range( 0, 6);

    timecount++;

     if(timecount % interval  == 0 )
    {
    	if( iceRand == 0 ) {
        	Instantiate(Ice0, new Vector3( rand, 3, 0),Quaternion.Euler(0, 0, 0));
    	}else if( iceRand == 1 ) {
        	Instantiate(Ice1, new Vector3( rand, 3, 0),Quaternion.Euler(0, 0, 0));
    	}else if( iceRand == 2 ) {
        	Instantiate(Ice2, new Vector3( rand, 3, 0),Quaternion.Euler(0, 0, 0));
    	}else if( iceRand == 3 ) {
        	Instantiate(Ice3, new Vector3( rand, 3, 0),Quaternion.Euler(0, 0, 0));
    	}else if( iceRand == 4 ) {
        	Instantiate(Ice4, new Vector3( rand, 3, 0),Quaternion.Euler(0, 0, 0));
    	} 
    }
}
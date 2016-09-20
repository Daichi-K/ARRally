using UnityEngine;
using System.Collections;

public class levelImage : MonoBehaviour {

	public static int score = 0; //スコア計算用変数
    public GameObject blueImage;
    public GameObject redImage;

	void Update (){

		score = GameSelect.playerLevel;
        
        if ( score >= 8 ) {
            blueImage.SetActive( false );
            redImage.SetActive(true);
        }
    
    }
}

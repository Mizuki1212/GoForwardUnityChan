using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {
	
	// キューブの移動速度（左方向）
	private float speed = -0.2f;
	// 消滅位置
	private float deadLine = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// キューブを左方向に移動させる
		transform.Translate (this.speed, 0, 0);

		// 左方向へ持っていき画面外へ消えたら破棄する
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}
}

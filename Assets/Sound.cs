using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {
    // 効果音を鳴らす時はAudioClip変数を宣言
    public AudioClip blockSE;

    AudioSource sound;


    // Use this for initialization
    void Start()
    {
        sound = GetComponent<AudioSource>();

    }

        // 練習 デバッグログで接触を調べる
        void OnCollisionEnter2D(Collision2D collision2D)
        {
            Debug.Log("オブジェクト衝突: " + collision2D.gameObject.name);
        
        // CubePrefabが以下のタグに接触した場合
        if (collision2D.gameObject.tag == "Cube" || collision2D.gameObject.tag == "ground")
        {
            // SE再生 ※SEは重ねて再生する場合があるので PlayOneShot() を使う
            sound.PlayOneShot(blockSE);

            // 練習 デバッグログでSE再生を調べる
            Debug.Log("SE再生: " + blockSE.name);
        }

        }
    }
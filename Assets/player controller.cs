using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Animator _playerAnimator;
    public AudioClip coinSound;
    public AudioClip Enemysound;

    public TMP_Text _scoreText, _lifeText, _resultText;
    public int score, life;
    public GameObject _Gameovermenu;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        life = 3;
        _scoreText.text = "score:" + score;
        _lifeText.text = "life:" + life;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            _playerAnimator.SetInteger("state", 2);
            transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            _playerAnimator.SetInteger("state", 1);
            transform.Translate(Vector3.forward * 1.0f * Time.deltaTime);
        }
        else
            _playerAnimator.SetInteger("state", 0);


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * 30.0f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * 30.0f * Time.deltaTime);
        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collided");
        if (collision.gameObject.tag == "coin")
        {
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(collision.gameObject);
            score++;
            _scoreText.text = "score" + score;

            if (score >= 3)
            {
                _Gameovermenu.SetActive(true);
                _resultText.text = "Congradulations!!! You Won the Game.";
                Time.timeScale = 0.0f;
            }

        }

        else if (collision.gameObject.tag == "enemy")
        {
            AudioSource.PlayClipAtPoint(Enemysound, transform.position);
            Destroy(collision.gameObject);
            life--;
            _lifeText.text = "life:" + life;

            if (life <= 0)
            {
                _Gameovermenu.SetActive(true);
                _resultText.text = "You Lost the Game. Retry Once";
                Time.timeScale = 0.0f;
            }

        }


    }


}
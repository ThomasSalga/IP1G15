using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// attach to UI Text component (with the full text already there)

public class TypeScript : MonoBehaviour 
{

	Text txt;
	string story;
	public bool PlayOnAwake = true;
	public float Delay;
	public AudioSource typeSound;

	void Start(){

		typeSound = GetComponent<AudioSource>();

	}

	void Awake()
	{
		txt = GetComponent<Text>();
		if (PlayOnAwake)
			ChangeText(txt.text, Delay);
	}

	//Update text and start typewriter effect
	public void ChangeText(string _text, float _delay= 0f)
	{
		StopCoroutine(PlayText()); //stop Coroutime if exist
		story = _text;
		txt.text = ""; //clean text
		Invoke("Start_PlayText", _delay); //Invoke effect
	}

	void Start_PlayText()
	{
		StartCoroutine(PlayText());
	}

	IEnumerator PlayText()
	{
		foreach (char c in story)
		{
			txt.text += c;
			typeSound.Play();
			yield return new WaitForSeconds(0.075f);
		}
	}

}
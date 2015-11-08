using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
[RequireComponent(typeof(AudioSource))]

public class SpaceBarGameCode : MonoBehaviour {

	void Start() {
		//AudioSource audio = GetComponent<AudioSource>();
		EventSystem.current.SetSelectedGameObject(button.gameObject);
	}

	public Button button;

	// Update is called once per frame
	void Update(){
		var pointer = new PointerEventData(EventSystem.current); // pointer event for Execute
		if(Input.GetKeyDown("space")) {
			EventSystem.current.SetSelectedGameObject(button.gameObject);
			ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.pointerDownHandler);
			GetComponent<AudioSource>().Play();
		}

		if (Input.GetKeyDown(KeyCode.H)) // force hover
		{
			//ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.pointerEnterHandler);
		}
		if (Input.GetKeyDown(KeyCode.U)) // un-hover (end hovering)
		{
			//ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.pointerExitHandler);
		}
		if (Input.GetKeyDown(KeyCode.S)) // submit (~click)
		{
			//ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.submitHandler);
		}
		if (Input.GetKeyDown(KeyCode.P)) // down: press
		{
			//ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.pointerDownHandler);
		}
		if (Input.GetKeyUp(KeyCode.P)) // up: release
		{
			//ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.pointerUpHandler);
		}
	}
}
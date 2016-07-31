using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public static GameObject itemBeingDragged;
	public AudioSource audioSource;
	public AudioClip audioClip;
	Vector3 startPosition;
	Transform startParent;

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}


	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		audioSource.PlayOneShot(audioClip, 1);
		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		//GetComponent<CanvasGroup>().blocksRaycasts = false;
		itemBeingDragged.transform.SetAsLastSibling();

	}

	#endregion

	#region IDragHandler implementation

	//This moves sets the transform of the object being moved to the mouse input
	public void OnDrag (PointerEventData eventData)
	{
		transform.position = Input.mousePosition;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		//audioSource.PlayOneShot(audioClip, 1);
		itemBeingDragged = null;
		//GetComponent<CanvasGroup>().blocksRaycasts = true;
		//if (transform.parent != startParent){
		//	transform.position = startPosition;
		//}
	}

	#endregion



}

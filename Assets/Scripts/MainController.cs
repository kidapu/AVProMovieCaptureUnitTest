using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RenderHeads.Media.AVProMovieCapture;

public class MainController : MonoBehaviour
{
	[SerializeField]
	Button _startRecButton;

	[SerializeField]
	Text _statusText;

	[SerializeField]
	CaptureFromCamera _cap;

	bool _isRecording = false;

	void Start()
	{
		_startRecButton.onClick.AddListener(() =>
		{
			Debug.LogFormat("Click => isRecording : {0}", _isRecording);

			if (!_isRecording)
			{
				_cap.StartCapture();
				_isRecording = true;
				_statusText.text = "Now Rec";
			}
			else
			{
				_cap.StopCapture();
				_isRecording = false;
				_statusText.text = "-";
			}
		});

	}

	void Update()
	{

	}


}

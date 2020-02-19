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
			Debug.LogFormat("Click 録画ボタン => isRecording : {0}", _isRecording);

			if (!_isRecording)
			{
				_cap.StartCapture();
				_isRecording = true;
				_statusText.text = "録画中";
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

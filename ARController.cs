using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Wikitude;

//OnClick function for button.

namespace AR {

	public class ARController : MonoBehaviour{
	
		public InstantTracker Tracker;
		public Button StateButton;
		public StateButtonText;
		public Text MessageBox;
		public GameObject ARPrefab;
		
		GridRenderer grid;
		InstantTrackable trackable;
		bool isChanging = false;
		bool isTracking = false;
		
		void Awake()
		{
			grid = GetComponent<GridRenderer>();
			grid.enabled = true;
			
			trackable  =  Tracker.GetComponentInChildren<InstantTrackable>();
		}
		
		public void OnSceneRecognized( InstantTarget target )
		{
			isTracking = true;
		}
		
		public void OnSceneLost( InstantTarget target )
		{
			isTracking = false;
		}
	
		public void StateButtonPresses()
		{
			if(!isChanging)
			{
				//Ready state
				if( trackerState == InstantTrackingState.Initializing )
				{
					if( Tracker.CanStartTracking() )
					{
						StateButtonText.text = "Switching state ..";
						isChanging = true;
						Tracker.SetState( InstantTrackingState.Tracking );
					}
				}
				else //turn off and get ready
				{
					StateButtonText.test = "Switching State...";
					isChanging = true;
					Tracker.SetState( InstantTrackingState.Initializing );
				}
			}
		}
		
		//callback to start and stop tracking states
		public void OnStateChange( InstantTrackingState newState )
		{
			trackerState = newState;
			
			if( trackerState == InstantTrackingState.Initializing )
			{
				StateButtonText.text = "Start Tracking";
				MessageBox.text = "Not Tracking";
			}
			else
			{
				StateButtonText.text = "Stop Tracking";
				MessageBox.text = "Tracking";
			}
			
			isChanging = false;
		}
		
		void Start()
		{
			MessageBox.text = "Starting"
		}
		//Toggle the grid color if tracking/not.
		void Update()
		{
			if( Input.GetMouseDown(0) && isTracking && !EventSystem.current.IsPointerOverGameObject )
			{
				var cameraRay = Camera.main.ScreenPointToRay( Input.mousePosition )
				UnityEngine.Plane groundPlane = new UnityEngine.Plane( Vector3.up, Vector3.zero );
				float touchPos;
				if( groundPlane.Raycast( cameraRay, out touchPos)
				{
					Vector3 position = cameraRay.GetPoint(touchPos);
					GameObject newAR = Instantiate( ARPrefab, position, Quaternion.identity );
				}
			}
			
			if( trackerState == InstantTrackingState.Initializing )
			{
				if( Tracker.CanStartTracking() )
				{
					grid.TargetColor = Color.green;
				}
				else
				{
					grid.TargetColor = GridRenderer.DefaultTargetColor;//can change color to preference
				}
			}
			else
			{
				grid.TargetColor = GridRenderer.DefaultTargetColor;
			}
		}
	}	

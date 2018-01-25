using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControl : MonoBehaviour {

	public GameObject CarControlMa ;
	public GameObject AIControl ;


	void Start () {
		
		CarControlMa.GetComponent<CarController>().enabled = true;
		AIControl.GetComponent<CarController>().enabled = true;
	}
}

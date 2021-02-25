using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class CrumbMenuController : MonoBehaviour {
  [SerializeField] private string[] inputFieldsKeys;
  [SerializeField] private TMP_InputField[] inputFields;




  public TMP_InputField GetInputFieldByKey(string s) {
  	return inputFields.Get(inputFieldsKeys.IndexOf(s));
  } 
}

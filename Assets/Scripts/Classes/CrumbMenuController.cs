using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CrumbMenuController : MonoBehaviour {
  [SerializeField] private List<string> inputFieldsKeys;
  [SerializeField] private List<TMP_InputField> inputFields;

  private void Start() {
    if (inputFieldsKeys.Count != inputFields.Count) {
      Debug.LogError("InputField lists are not of matching length");
    }
    for (int i = 0; i < inputFieldsKeys.Count; ++i) {
      inputFields[i].onValueChanged.AddListener(callbackForInputField(inputFieldsKeys[i]));
    }
  }

  public void SetCrumb(Crumb c) {
    for (int i = 0; i < inputFieldsKeys.Count; ++i) {
      switch (inputFieldsKeys[i]) {
        case "title":
          inputFields[i].text = c.Title;
          break;
        case "description":
          inputFields[i].text = c.Description;
          break;
        default:
          Debug.LogError("Could not preset field for non-real key " + inputFieldsKeys[i]);
          break;
      }
    }
  }

  public void BackCallback() {
    BreadcrumbsState.Instance.DeselectCrumb();
    foreach (var field in inputFields) {
      field.SetTextWithoutNotify("");
    }
  }

  /// <summary>
  /// Crumb callbacks
  /// </summary>
  private UnityAction<string> callbackForInputField(string key) {
    switch (key) {
      case "title":
        return updateTitle;
      case "description":
        return updateDescription;
      default:
        Debug.LogError("Callback triggered for non-real key");
        return null;
    }
  }

  private void updateTitle(string content) {
    BreadcrumbsState.Instance.CurrentCrumb.Title = content;
  }

  private void updateDescription(string content) {
    BreadcrumbsState.Instance.CurrentCrumb.Description = content;
  }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CrumbPreview : MonoBehaviour {
  [SerializeField] private TextMeshProUGUI titleText;

  private Crumb crumb;

  public void SetCrumb(Crumb c) {
    crumb = c;
    titleText.text = crumb.Title;
  }

  public void EditCrumb() {
    BreadcrumbsState.Instance.SelectCrumb(crumb);
  }
}

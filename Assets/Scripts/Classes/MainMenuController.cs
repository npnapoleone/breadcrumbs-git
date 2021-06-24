using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour {
  [SerializeField] private RectTransform crumbContainer;
  [SerializeField] private CrumbPreview crumbPreview;

  private void OnEnable() {
    refresh();
  }


  private void Update() {
    if (BreadcrumbsState.Instance.Dirty) {
      refresh();
    }
  }

  private void refresh() {
    foreach (Transform crumb in crumbContainer) {
      Destroy(crumb.gameObject);
    }

    var crumbs = BreadcrumbsState.Instance.Crumbs;
    foreach (var crumb in crumbs) {
      CrumbPreview newPreview = Instantiate(crumbPreview, crumbContainer);
      newPreview.SetCrumb(crumb);
    }
  }
}

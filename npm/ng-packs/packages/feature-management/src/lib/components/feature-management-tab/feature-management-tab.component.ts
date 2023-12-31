import { Component } from '@angular/core';

@Component({
  selector: 'abp-feature-management-tab',
  templateUrl: './feature-management-tab.component.html',
})
export class FeatureManagementTabComponent {
  visibleFeatures = false;
  providerKey: string;

  openFeaturesModal() {
    this.visibleFeatures = true;
  }

  onVisibleFeaturesChange = (value: boolean) => {
    this.visibleFeatures = value;
  };
}

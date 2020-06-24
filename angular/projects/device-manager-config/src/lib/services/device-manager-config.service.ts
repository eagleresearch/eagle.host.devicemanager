import { Injectable } from '@angular/core';
import { eLayoutType, addAbpRoutes, ABP } from '@abp/ng.core';
import { addSettingTab } from '@abp/ng.theme.shared';
import { DeviceManagerSettingsComponent } from '../components/device-manager-settings.component';

@Injectable({
  providedIn: 'root',
})
export class DeviceManagerConfigService {
  constructor() {
    addAbpRoutes({
      name: 'DeviceManager',
      path: 'device-manager',
      layout: eLayoutType.application,
      iconClass: 'fas fa-check',
      order: 4,
    } as ABP.FullRoute);

    const route = addSettingTab({
      component: DeviceManagerSettingsComponent,
      name: 'DeviceManager Settings',
      order: 4,
      requiredPolicy: '',
    });
  }
}

import { NgModule, APP_INITIALIZER } from '@angular/core';
import { DeviceManagerConfigService } from './services/device-manager-config.service';
import { noop } from '@abp/ng.core';
import { DeviceManagerSettingsComponent } from './components/device-manager-settings.component';

@NgModule({
  declarations: [DeviceManagerSettingsComponent],
  providers: [{ provide: APP_INITIALIZER, deps: [DeviceManagerConfigService], multi: true, useFactory: noop }],
  exports: [DeviceManagerSettingsComponent],
  entryComponents: [DeviceManagerSettingsComponent],
})
export class DeviceManagerConfigModule {}

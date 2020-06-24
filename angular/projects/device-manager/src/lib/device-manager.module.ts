import { NgModule } from '@angular/core';
import { DeviceManagerComponent } from './components/device-manager.component';
import { DeviceManagerRoutingModule } from './device-manager-routing.module';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { CoreModule } from '@abp/ng.core';

@NgModule({
  declarations: [DeviceManagerComponent],
  imports: [CoreModule, ThemeSharedModule, DeviceManagerRoutingModule],
  exports: [DeviceManagerComponent],
})
export class DeviceManagerModule {}

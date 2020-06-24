import { ABP } from '@abp/ng.core';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    loadChildren: () => import('./home/home.module').then((m) => m.HomeModule),
    data: {
      routes: {
        name: 'Home',
        iconClass: 'fa fa-home',
      } as ABP.Route,
    },
  },
  {
    path: 'identity',
    loadChildren: () => import('@volo/abp.ng.identity').then((m) => m.IdentityModule),
  },
  {
    path: 'account',
    loadChildren: () => import('@volo/abp.ng.account').then((m) => m.AccountModule),
  },
  {
    path: 'saas',
    loadChildren: () => import('@volo/abp.ng.saas').then((m) => m.SaasModule),
  },
  {
    path: 'setting-management',
    loadChildren: () => import('@abp/ng.setting-management').then((m) => m.SettingManagementModule),
  },
  {
    path: 'device-manager',
    loadChildren: () =>
      import('../../projects/device-manager/src/public-api').then((m) => m.DeviceManagerModule),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

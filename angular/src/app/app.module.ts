import { CoreModule } from '@abp/ng.core';
import { SettingManagementConfigModule } from '@abp/ng.setting-management.config';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgxsLoggerPluginModule } from '@ngxs/logger-plugin';
import { NgxsModule } from '@ngxs/store';
import { AccountConfigModule } from '@volo/abp.ng.account.config';
import { AuditLoggingConfigModule } from '@volo/abp.ng.audit-logging.config';
import { IdentityServerConfigModule } from '@volo/abp.ng.identity-server.config';
import { IdentityConfigModule } from '@volo/abp.ng.identity.config';
import { LanguageManagementConfigModule } from '@volo/abp.ng.language-management.config';
import { SaasConfigModule } from '@volo/abp.ng.saas.config';
import { HttpErrorComponent } from '@volo/abp.ng.theme.lepton';
import { OAuthModule } from 'angular-oauth2-oidc';
import { environment } from '../environments/environment';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SharedModule } from './shared/shared.module';
import { DeviceManagerConfigModule } from '../../projects/device-manager-config/src/public-api';

const LOGGERS = [NgxsLoggerPluginModule.forRoot({ disabled: false })];
@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    ThemeSharedModule.forRoot({
      httpErrorConfig: {
        errorScreen: {
          component: HttpErrorComponent,
          forWhichErrors: [401, 403, 404, 500],
        },
      },
    }),
    CoreModule.forRoot({
      environment,
    }),
    AccountConfigModule.forRoot({ redirectUrl: '/' }),
    IdentityConfigModule,
    LanguageManagementConfigModule,
    SaasConfigModule,
    AuditLoggingConfigModule,
    IdentityServerConfigModule,
    SettingManagementConfigModule,
    DeviceManagerConfigModule,
    OAuthModule.forRoot(),
    NgxsModule.forRoot([]),
    SharedModule,

    ...(environment.production ? [] : LOGGERS),
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}

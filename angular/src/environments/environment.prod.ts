export const environment = {
  production: true,
  application: {
    name: 'DeviceManager',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44333',
    clientId: 'DeviceManager_ConsoleTestApp',
    dummyClientSecret: '1q2w3e*',
    scope: 'DeviceManager',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44361',
    },
  },
};

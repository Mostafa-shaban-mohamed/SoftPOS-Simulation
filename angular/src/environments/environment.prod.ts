import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'SoftPOS',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44368/',
    redirectUri: baseUrl,
    clientId: 'SoftPOS_App',
    responseType: 'code',
    scope: 'offline_access SoftPOS',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44368',
      rootNamespace: 'App.SoftPOS',
    },
  },
} as Environment;

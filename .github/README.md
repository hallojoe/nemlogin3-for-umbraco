# Casko.NemLogin3ForUmbraco

[![Downloads](https://img.shields.io/nuget/dt/Casko.NemLogin3ForUmbraco?color=cc9900)](https://www.nuget.org/packages/Casko.NemLogin3ForUmbraco/)
[![NuGet](https://img.shields.io/nuget/vpre/Casko.NemLogin3ForUmbraco?color=0273B3)](https://www.nuget.org/packages/Casko.NemLogin3ForUmbraco)

Umbraco 17 member and backoffice external login provider for NemLog-in 3 / OIOSAML 3 SAML authentication.

The public NuGet package is `Casko.NemLogin3ForUmbraco`. It adapts the shared `Casko.Authentication.NemLogin3.Web` SAML foundation into Umbraco member and backoffice authentication flows.

## Installation

```powershell
dotnet add package Casko.NemLogin3ForUmbraco
```

## Package Focus

- Register NemLog-in 3 as an Umbraco member external login provider.
- Register NemLog-in 3 as an Umbraco backoffice external login provider.
- Generate service provider metadata through an Umbraco-hosted endpoint.
- Map NemLog-in claims into Umbraco member and backoffice user identities.
- Store compact RelayState data server-side for Umbraco external login callbacks.

## Main Entry Points

- `AddNemLogin3MemberLogin(...)` registers the Umbraco member external login provider.
- `AddNemLogin3BackOfficeLogin(...)` registers the Umbraco backoffice external login provider.

## Maintainer Notes

- Keep low-level SAML behavior in `Casko.Authentication.NemLogin3.Web`.
- Keep this package focused on Umbraco integration, claim mapping, metadata hosting, and external login behavior.
- Full solution and package documentation lives in `docs`.

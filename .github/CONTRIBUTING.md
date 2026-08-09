# Contributing Guidelines

Contributions are welcome.

This repository publishes `Casko.NemLogin3ForUmbraco`, an Umbraco member and backoffice external login provider for NemLog-in 3 / OIOSAML 3 SAML authentication. Please keep contributions focused on the Umbraco package surface: external login registration, metadata hosting, claim mapping, RelayState handling, options, and package integration.

Before opening a pull request:

- Build the package project in Release configuration.
- Keep public API changes intentional and documented.
- Keep low-level SAML behavior in `Casko.Authentication.NemLogin3.Web`.
- Include enough context in the pull request for reviewers to understand the NemLog-in 3 scenario being changed.

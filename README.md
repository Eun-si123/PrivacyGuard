# PrivacyGuard

Local-first, open-source application privacy controls and transparency. Windows first; other platforms are research targets.

**Development status:** M0 bootstrap. No active monitoring, blocking, isolation or identifier protection is implemented yet. Do not use this as a security product.

- [Product and technical specification (Korean)](docs/spec-privacyguard.md)
- [Milestones and phases](docs/roadmap-privacyguard.md)
- [Current status](docs/STATUS.md)
- [Security policy](SECURITY.md)

## Development
.NET 10 SDK; no third-party NuGet dependencies in the initial scaffold.
```sh
dotnet build PrivacyGuard.slnx -c Release
dotnet run --project tests/PrivacyGuard.Core.Checks -c Release --no-build
dotnet run --project src/PrivacyGuard.Cli -c Release --no-build -- capabilities
```
The CLI reports unsupported capabilities, not protection. No elevated privileges or system changes.

License: Apache-2.0 for original project material; future third-party integration requires a separate license review.

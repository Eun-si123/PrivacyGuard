# Current status
M0 in progress; interview documents are historical baseline snapshots. Public repository created; original source and docs licensed Apache-2.0 after choosing an independent implementation without third-party code. Future integrations require component-level review.
Initial target: .NET 10, Windows 11 x64. Core and CLI bootstrap portable; no WPF UI, OS monitor, policy enforcement, privileged service, sandbox or driver yet.
No production protections. Windows VM and physical tests, signing, security settings and CI verification remain distinct gates.

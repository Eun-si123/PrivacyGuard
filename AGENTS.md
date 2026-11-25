# Development instructions
Read docs/spec-privacyguard.md and docs/roadmap-privacyguard.md before changes; docs/STATUS.md records current evidence.
Work on one bounded phase with tests and explicit acceptance criteria. Check current branch/PRs and avoid overwriting concurrent changes.
Prefer official OS APIs, least privilege, local processing, no implicit telemetry. Never collect raw secrets, weaken OS security, or claim unverified protection.
Do not implement service enforcement or anti-cheat bypass, host identity mutation, or invasive interception. Test privacy capabilities against owned synthetic fixtures in isolated environments.
Preserve existing OS policies and user files; privileged operations require ownership, rollback and independent verification.
Build and run checks before claiming completion. Distinguish static review, automated checks, Windows VM and physical-device results. Do not close milestones without evidence.
Check dependency licenses, pin CI actions, review security changes and update status.

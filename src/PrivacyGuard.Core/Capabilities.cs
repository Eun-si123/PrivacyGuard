namespace PrivacyGuard.Core;

public enum CapabilityState { Unsupported, Unknown, Partial, Verified, Failed }
public sealed record Capability(string Id, CapabilityState State, string Explanation);

public static class Capabilities
{
    public static IReadOnlyList<Capability> Current() => Array.AsReadOnly(new[]
    {
        new Capability("observation", CapabilityState.Unsupported, "OS event collection is not implemented."),
        new Capability("network-control", CapabilityState.Unsupported, "Network policy enforcement is not implemented."),
        new Capability("isolation", CapabilityState.Unsupported, "Application isolation is not implemented."),
        new Capability("identity-privacy", CapabilityState.Unsupported, "Device information controls are not implemented.")
    });
}

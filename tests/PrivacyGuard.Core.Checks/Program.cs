using PrivacyGuard.Core;

var caps = Capabilities.Current();
if (caps.Count != 4 || caps.Select(c => c.Id).Distinct().Count() != caps.Count)
    throw new Exception("Capability inventory is incomplete or duplicated.");
if (caps.Any(c => c.State != CapabilityState.Unsupported || string.IsNullOrWhiteSpace(c.Explanation)))
    throw new Exception("Unimplemented protection must not be advertised.");
Console.WriteLine("PASS: capability inventory and truthful unsupported states.");

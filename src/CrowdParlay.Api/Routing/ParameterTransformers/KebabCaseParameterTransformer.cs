using System.Text.RegularExpressions;

namespace CrowdParlay.Api.Routing.ParameterTransformers;

internal class KebabCaseParameterTransformer : IOutboundParameterTransformer
{
    public string? TransformOutbound(object? value) => value switch
    {
        null => null,
        _ => Regex.Replace(value.ToString()!, "([a-z])([A-Z])", "$1-$2").ToLower()
    };
}
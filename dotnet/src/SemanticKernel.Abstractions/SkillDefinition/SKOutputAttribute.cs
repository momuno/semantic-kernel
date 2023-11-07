// Copyright (c) Microsoft. All rights reserved.

using System;

namespace Microsoft.SemanticKernel.SkillDefinition;

/// <summary>
/// Attribute to define the output of a native function.
/// </summary>
/// <remarks>
/// Intended to be used as part of the prompt describing the function to the model.
/// </remarks>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.ReturnValue, AllowMultiple = false)]
public sealed class SKOutputAttribute : Attribute
{
    /// <summary>
    /// Initializes the attribute with its (native function return) type and semantic description.
    /// </summary>
    /// <param type="type">The type of output.</param>
    /// <param range="reange">The range out output included and excluded.</param>
    /// <param description="description">The semantic description of the output.</param>
    public SKOutputAttribute(string type, string range, string description)
    {
        this.Type = type;
        this.Range = range;
        this.Description = description;
    }

    /// <summary>Gets the specified type.</summary>
    public string Type { get; }

    /// <summary>Gets the specified range.</summary>
    public string Range { get; }

    /// <summary>Gets the specified description.</summary>
    public string Description { get; }
}

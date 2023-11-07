// Copyright (c) Microsoft. All rights reserved.

using System.Diagnostics;

namespace Microsoft.SemanticKernel.SkillDefinition;

/// <summary>
/// Class used to copy and export data from the skill collection.
/// The data is mutable, but changes do not affect the skill collection.
/// </summary>
[DebuggerDisplay("{DebuggerDisplay,nq}")]
public sealed class OutputView
{
    /// <summary>
    /// Function output return type. The return type is to be used in prompt templates.
    /// </summary>
    public string Type { get; } = string.Empty;

    /// <summary>
    /// Function output return range of values. This can be qualitative or quantitative, specifying what is included and what is excluded. The return value range is to be used in prompt templates.
    /// </summary>
    public string Range { get; } = string.Empty;

    /// <summary>
    /// Function output description. Any other information about the returned output not covered by outputType or outputRange. The description is to be used in prompt templates.
    /// </summary>
    public string Description { get; } = string.Empty;

    /// <summary>
    /// Constructor
    /// </summary>
    public OutputView()
    {
    }

    /// <summary>
    /// Create an output view.
    /// </summary>
    /// <param name="type">Function output return type</param>
    /// <param name="range">Function output return range of values.</param>
    /// <param name="description">Function output description</param>
    public OutputView(string type, string range, string description)
    {
        this.Type = type;
        this.Range = range;
        this.Description = description;
    }
};
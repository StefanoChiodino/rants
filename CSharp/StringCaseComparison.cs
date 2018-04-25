if (searchParameters.NodeType != "media" && searchParameters.NodeType != "Media")
{
    // Do something with non-media nodes.
}

// To lower technically doesn't do exactly the same, but probably even better.
if (searchParameters.NodeType.ToLower() != "media")
{
    // Do something with non-media nodes.
}

// Even better: compare with invariant case.
if (!searchParameters.NodeType.Equals("media", StringComparison.OrdinalIgnoreCase))
{
    // Do something with non-media nodes.
}

// In fact, Umbraco provides a utility method for this.
if (!searchParameters.NodeType.InvariantEquals("media"))
{
    // Do something with non-media nodes.
}

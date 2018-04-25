if (searchParameters.Rating != null)
{
    if (searchParameters.Rating.Any())
    {
        foreach (var ratingId in searchParameters.Rating)
        {
            // Do something with ratingId.
        }
    }
}

// Chain if, save 2-3 lines
if (searchParameters.Rating != null
    && searchParameters.Rating.Any())
{
    foreach (var ratingId in searchParameters.Rating)
    {
        // Do something with ratingId.
    }
}

// Don't check if there are any ratings, if empty the foreach will do nothing anyway!
if (searchParameters.Rating != null)
{
    foreach (var ratingId in searchParameters.Rating)
    {
        // Do something with ratingId.
    }
}



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
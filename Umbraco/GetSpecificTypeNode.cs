// Hit the DB twice. Use a list of hardcoded document type aliases.
var websiteNodeContentId = this.Services.ContentTypeService.GetContentType(DocumentTypeAlias.WebsiteNode).Id;
var websiteNode = this.Services.ContentService.GetByLevel(1).First(d => d.ContentTypeId == websiteNodeContentId);


// Doesn't hit the database. Use models builder alias.
UmbracoContext.ContentCache.GetAtRoot()
    .FirstOrDefault(content => content.DocumentTypeAlias == Website.ModelTypeAlias);


// XPath trick.
UmbracoContext.ContentCache.GetSingleByXPath($"//{Website.ModelItemType}");
if (requestData.WebsitePage != null)
{
    var domains = library.GetCurrentDomains(requestData.WebsitePage.Id);

    if (domains != null && domains.Length > 0)
    {
        // return the language id from the first domain
        //currentLanguage = domains[0].Language.CultureAlias;
    }
}



// Why was this commented out? What did it do before? We'll probably never know.

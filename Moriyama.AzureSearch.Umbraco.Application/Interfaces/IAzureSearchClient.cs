﻿using System;
using System.Collections.Generic;

namespace Moriyama.AzureSearch.Umbraco.Application.Interfaces
{
    public interface IAzureSearchClient
    {
        IList<string> Filters { get; set; }

        ISearchResult Results();
        ISearchResult Results(int page);

        IAzureSearchClient Term(string query);
        IAzureSearchClient DocumentType(string typeAlias);
        IAzureSearchClient OrderBy(string fieldName);

        IAzureSearchClient Content();
        IAzureSearchClient Media();

        IAzureSearchClient PageSize(int pageSize);
        IAzureSearchClient PopulateContentProperties(bool populate);

        IAzureSearchClient Filter(string field, string value);
        IAzureSearchClient Filter(string field, string[] values);
        IAzureSearchClient Filter(string field, int value);
        IAzureSearchClient Filter(string field, bool value);
        IAzureSearchClient DateRange(string field, DateTime? start, DateTime? end);
        IAzureSearchClient Facet(string facet);
        IAzureSearchClient Contains(string field, string value);
        IAzureSearchClient Contains(string field, IEnumerable<string> values);
        IAzureSearchClient Contains(IEnumerable<string> fields, string value);
        IAzureSearchClient Contains(IEnumerable<string> fields, IEnumerable<string> values);
        IAzureSearchClient Any(string field);

    }
}

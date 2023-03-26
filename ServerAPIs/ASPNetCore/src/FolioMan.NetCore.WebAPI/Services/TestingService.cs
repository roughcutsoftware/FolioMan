using System.Reflection;
using System.Resources;

namespace FolioMan.NetCore.WebAPI.Services
{
    public class TestingService
    {
        public TestingService()
        {
            
        }
        public static string? GetStringResourceByName()
        {
            string? resourceValue = @"
{
    ""PortfolioGuidKeyId"": ""21c93acb-aac9-49e5-a1f1-1b08785089df"",
    ""Candidate"": {
        ""CandidateGuidKeyId"": ""00000000-0000-0000-0000-000000000000"",
        ""Name"": ""Katherine Roob"",
        ""Email"": ""Katherine_Roob22@hotmail.com"",
        ""City"": null,
        ""State"": null
    },
    ""PortfolioName"": """",
    ""PortfolioDescription"": """",
    ""WorkHistory"": [
        {
            ""WorkHistoryGuidKeyId"": ""12b508c9-41d1-4f9b-94e0-5884fe536af9"",
            ""JobTitle"": ""IT Professional"",
            ""Employer"": {
                ""EmployerGuidKeyId"": ""e4a0d598-98b4-4361-bf4e-efe9500d8bbc"",
                ""Name"": ""Quitzon, Effertz and Lebsack"",
                ""City"": ""East Mohammedstad"",
                ""State"": ""Maine""
            },
            ""WorkToFromRange"": null,
            ""WorkHighlights"": [
                {
                    ""WorkHighlightGuidKeyId"": ""306d05fc-de5c-49e4-a581-8b0f1c1c63ca"",
                    ""Highlight"": ""Modi minima sit excepturi nobis voluptates occaecati rem.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""206b729a-9f11-4282-9538-810a23b94339"",
                    ""Highlight"": ""Modi minima sit excepturi nobis voluptates occaecati rem.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""4ddd04b8-0097-49aa-9375-f4bf81293607"",
                    ""Highlight"": ""Modi minima sit excepturi nobis voluptates occaecati rem.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""0a9c9dd6-172a-4df1-a5dc-7af8fd7b734c"",
                    ""Highlight"": ""Modi minima sit excepturi nobis voluptates occaecati rem.""
                }
            ]
        },
        {
            ""WorkHistoryGuidKeyId"": ""19ae9818-8d43-4b07-958f-4cf94274515a"",
            ""JobTitle"": ""IT Professional"",
            ""Employer"": {
                ""EmployerGuidKeyId"": ""ddff941d-3e20-4850-b780-3a884021f17e"",
                ""Name"": ""Morar LLC"",
                ""City"": ""Kiarafort"",
                ""State"": ""Michigan""
            },
            ""WorkToFromRange"": null,
            ""WorkHighlights"": [
                {
                    ""WorkHighlightGuidKeyId"": ""cc18a62b-f10e-443f-b057-ca9dbb42a26c"",
                    ""Highlight"": ""Autem fugiat nobis incidunt vel et sed aut accusamus aut.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""678deb5a-e4b3-4b56-9607-e109b9d81264"",
                    ""Highlight"": ""Autem fugiat nobis incidunt vel et sed aut accusamus aut.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""8965b448-523e-464a-8f54-9a5472491cd8"",
                    ""Highlight"": ""Autem fugiat nobis incidunt vel et sed aut accusamus aut.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""4604ff48-132c-4096-983b-23fd171a8194"",
                    ""Highlight"": ""Autem fugiat nobis incidunt vel et sed aut accusamus aut.""
                }
            ]
        },
        {
            ""WorkHistoryGuidKeyId"": ""e63dcb76-9704-417a-945f-9e19a011b3a8"",
            ""JobTitle"": ""IT Professional"",
            ""Employer"": {
                ""EmployerGuidKeyId"": ""516bdfa7-40d8-4ac8-8a47-a9692c18b8e6"",
                ""Name"": ""Kling - Kutch"",
                ""City"": ""Amyhaven"",
                ""State"": ""New Mexico""
            },
            ""WorkToFromRange"": null,
            ""WorkHighlights"": [
                {
                    ""WorkHighlightGuidKeyId"": ""c19bc6ea-133e-421e-91fe-b1df545b377e"",
                    ""Highlight"": ""In molestiae aut consequatur explicabo ea deserunt alias ut.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""ee1f512c-a903-44fb-bce5-1ae78e9d8e62"",
                    ""Highlight"": ""In molestiae aut consequatur explicabo ea deserunt alias ut.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""308d0a4c-d76b-4d92-a20f-d52a02902abb"",
                    ""Highlight"": ""In molestiae aut consequatur explicabo ea deserunt alias ut.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""399aad5c-4190-4988-bfc0-4c2aab9e2437"",
                    ""Highlight"": ""In molestiae aut consequatur explicabo ea deserunt alias ut.""
                }
            ]
        },
        {
            ""WorkHistoryGuidKeyId"": ""96a31764-1f4d-4e19-9a69-a7d2d8742e12"",
            ""JobTitle"": ""IT Professional"",
            ""Employer"": {
                ""EmployerGuidKeyId"": ""0f546ae5-ef79-4a1c-9d5c-e5593b1b964b"",
                ""Name"": ""Zboncak - Bins"",
                ""City"": ""South Elena"",
                ""State"": ""California""
            },
            ""WorkToFromRange"": null,
            ""WorkHighlights"": [
                {
                    ""WorkHighlightGuidKeyId"": ""10979d84-ee8d-49d9-abc7-79741e0b995a"",
                    ""Highlight"": ""Eum totam et facere aut.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""10520946-0f33-4963-86b5-f2e3cd3eeaba"",
                    ""Highlight"": ""Eum totam et facere aut.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""807857aa-79fc-40d5-a7e9-d383f752f646"",
                    ""Highlight"": ""Eum totam et facere aut.""
                },
                {
                    ""WorkHighlightGuidKeyId"": ""b5ab6376-c2fc-4ede-874e-52ac5f8fa390"",
                    ""Highlight"": ""Eum totam et facere aut.""
                }
            ]
        }
    ]
}
";

            return resourceValue;

        }
    }
}

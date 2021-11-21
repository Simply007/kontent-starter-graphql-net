using System;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Execution;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Xunit;
using static GraphQLWebStarter.Models.Generated.KontentTypes;

namespace GraphQLWebStarter.Tests
{
    public class StronglyTypedResponse
    {
        private readonly GraphQLHttpClient client;

        public StronglyTypedResponse()
        {
            client = new GraphQLHttpClient("https://graphql.kontent.ai/ad25961e-f934-01dc-e1fa-f4dd41b84df2", new NewtonsoftJsonSerializer());
        }

        public class ResponseType
        {
            public Homepage? Homepage { get; set; }
        }

        [Fact]
        public async Task LoadHomePageAsync()
        {
            var homepageRequest = new GraphQLRequest
            {
                Query = @"
{
  homepage(codename: ""homepage"") {
    label
    mainMenu {
      label
      actions {
        items {
          label
        }
      }
    }
  }
}
"
            };
            var graphQLResponse = await client.SendQueryAsync<ResponseType>(homepageRequest);

            using (new AssertionScope())
            {
                graphQLResponse.Data.Homepage?.label.Should().Be("Home");
                graphQLResponse.Data.Homepage?.mainMenu.actions.items
                .Select(item => item.label)
                .Should()
                .BeEquivalentTo(new[] { "Features", "Blog", "Style Guide", "About Us", "Contact" });
            }

        }
    }
}

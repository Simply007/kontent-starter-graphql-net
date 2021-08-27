using System;
using System.Threading.Tasks;
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
            client = new GraphQLHttpClient("https://qa-graphql-deliver.global.ssl.fastly.net/graphql/ce50141b-c42b-01d8-c0b6-349de8c50622", new NewtonsoftJsonSerializer());
        }

        public class ResponseType
        {
            public Homepage Homepage { get; set; }
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
  }
}
"
            };
            var graphQLResponse = await client.SendQueryAsync<ResponseType>(homepageRequest);

            Assert.Equal("Home", graphQLResponse.Data.Homepage.label);


        }
    }
}

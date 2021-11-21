using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQLWebStarter.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLWebStarter.Controllers
{
    public class RichTextController : Controller
    {
        private IGraphQLClient _client;

        public RichTextController(IGraphQLClient client)
        {
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var simplePageRequest = new GraphQLRequest
            {
                Query = @"
{
  simplePage(codename: ""style_guide"") {
    title
    subtitle
    content {
      html
    }
  }
}
"
            };

            var graphQLResponse = await _client.SendQueryAsync<SimplePageViewModel>(simplePageRequest);

            return View(graphQLResponse.Data);
        }
    }
}
using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQLWebStarter.Models;
using GraphQLWebStarter.Models.Generated;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWebStarter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IGraphQLClient _client;
        public HomeController(ILogger<HomeController> logger, IGraphQLClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var homepageRequest = new GraphQLRequest
            {
                Query = @"
{
  homepage(codename: ""homepage"") {
    content {
      ... on LandingPage {
        sections {
          items {
            ... on HeroSection {
              title
              image {
                url
                description
                name
              }
              content {
                html
              }
            }
          }
        }
      }
    }
  }
}
"
            };


            var graphQLResponse = await _client.SendQueryAsync<object>(homepageRequest);

            dynamic heroSection = (graphQLResponse.Data as dynamic).homepage.content.sections.items[0];

            var model = new HomepageViewModel
            {
                Title = heroSection.title.Value,
                Content = heroSection.content.html.Value,
                ImageUrl = heroSection.image.url.Value,
                ImageDescription = heroSection.image.description.Value,
                ImageName = heroSection.image.name.Value,
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

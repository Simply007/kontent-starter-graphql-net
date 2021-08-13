using GraphQL;
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

        private readonly GraphQLHttpClient client;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            client = new GraphQLHttpClient("https://qa-graphql-deliver.global.ssl.fastly.net/graphql/ce50141b-c42b-01d8-c0b6-349de8c50622", new NewtonsoftJsonSerializer());
        }

        public async Task<IActionResult> Index()
        {
            var homepageRequest = new GraphQLRequest
            {
                Query = @"
{
  homepage(codename: ""homepage"") {
    content {
      items {
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
}
"
            };


            var graphQLResponse = await client.SendQueryAsync<object>(homepageRequest);

            dynamic heroSection = (graphQLResponse.Data as dynamic).homepage.content.items[0].sections.items[0];

            var model = new HomepageViewModel
            {
                Title = heroSection.title.Value,
                Content = heroSection.content.html.Value,
                ImageUrl = heroSection.image[0].url.Value,
                ImageDescription = heroSection.image[0].description.Value,
                ImageName = heroSection.image[0].name.Value,
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

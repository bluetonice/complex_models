using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;

namespace complex_models.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty, Required]
        public QueryMain QueryMain { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
        }

        public void OnPost()
        {


        }

        public PartialViewResult OnGetEmptyFilterPartial(int Id)
        {
            QueryMain query = new QueryMain();
            Query q = new Query();
            query.Queries.Add(q);

            QueryItem queryItem = new QueryItem();

            q.Items.Add(queryItem);


            return new PartialViewResult
            {
                ViewName = "_EmptyQueryItem",
                ViewData = new ViewDataDictionary<QueryMain>(ViewData, query)
            };
        }


        public void OnGet()
        {
            QueryMain user1 = new QueryMain();
            
            user1.Id = 1;
            
           Query order1 = new Query();
            order1.Id = 12;
           order1.AndOr = "AND";

            QueryItem orderItem1 = new QueryItem();
            orderItem1.Id = 12121;
            orderItem1.Price = 10;
            orderItem1.ProductName = "Elma";
            order1.Items.Add(orderItem1);


            QueryItem orderItem2 = new QueryItem();
            orderItem2.Id = 12122;
            orderItem2.Price = 15;
            orderItem2.ProductName = "Armut";
            order1.Items.Add(orderItem2);

            user1.Queries.Add(order1);


            this.QueryMain = user1;




        }
    }
}

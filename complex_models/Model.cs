using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace complex_models
{
    public class QueryMain
    {
        public QueryMain()
        {
            this.Queries = new List<Query>();
        }

        public int Id { get; set; }
        
        public List<Query> Queries { get; set; }
    }

    public class Query
    {
        public int Id { get; set; }
        public Query()
        {
            this.Items = new List<QueryItem>();
        }
        public string   AndOr { get; set; }


        public List<QueryItem> Items { get; set; }
    }

    public class QueryItem
    {

        public int Id { get; set; }


        public int Price { get; set; }

        public string ProductName { get; set; }
    }
}

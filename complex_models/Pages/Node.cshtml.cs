using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace complex_models.Pages
{
    public class NodeModel : PageModel
    {

        [BindProperty, Required]
        public Node Node { get; set; }
        public void OnGet()
        {

            this.Node = new Node() { Name = "Level1", Children = new List<Node>() };
            Node.Children.Add(new Node() { Children = null, Name = "Level2A" });
            Node.Children.Add(new Node()
            {
                Name = "Level2B",
                Children = new List<Node> {new Node{Name="Level3A", Children=null},
                                                                                 new Node{Name="Level3B", Children=null}}
            });
        }

        public void OnPost(Node Node)
        {
            //Keeps returning:
            // Node.Name is ok
            // Node.Children[0].Name is ok
            // Node.Children[1].Name is ok
            // Node.Children[1].Children = null (HERE LIES THE PROBLEM!)
            
        }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webshop.Pages
{
    public class ShopModel : PageModel
    {

        public String FsMsg { get; set; }
        public void OnGet()
        {
            FsMsg = "Framsida av shoppen där 3 olika producter kommer ligga";
        }
    }
}

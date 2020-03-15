using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BidvestWeb.Data;
using BidvestWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BidvestWeb.Controllers
{
    public class ProfilesController : Controller
    {
        string path = @"C:\Users\Public\Bidvest\";
        string fileName = "BDG_Output.json";
        public IActionResult Report()
        {
            try
            {
                Organisation organisation = new Organisation();
                var profiles = DataAccess.GetDataFromJsonFile(String.Concat(path,fileName));
                if (profiles != null && profiles.Count > 0)
                {
                    organisation.Profiles = profiles;
                    return View(organisation);
                }
                else
                {
                    return Content("Profiles not found, please check the content of your file");
                }
                
            }
            catch (Exception)
            {
                var errorResult = String.Format("Page not found, please check if path {0} exists", String.Concat(path, fileName));
                return NotFound(errorResult);
            }
            
        }
    }
}
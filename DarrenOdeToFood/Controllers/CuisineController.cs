﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace DarrenOdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        public IActionResult Search(string name = "unknown")
        {
            var message = HtmlEncoder.Default.Encode(name);

            return Content(message);
        }
    }
}
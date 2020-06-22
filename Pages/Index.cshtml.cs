using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DotNetCoreCurrencyInDocker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string CurrencyUK { get; set; }
        public string CurrencyUK2 { get; set; }
        public string Culture { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            decimal amount = 60.000000000000000000000000000000M;
            CurrencyUK = $"{amount:C}";
            CurrencyUK2 = string.Format("{0:C2}", amount, new CultureInfo("en-GB"));
            Culture = CultureInfo.CurrentCulture.DisplayName;
        }
    }
}

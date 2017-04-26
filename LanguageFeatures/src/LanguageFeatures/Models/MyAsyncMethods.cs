﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength(string site)
        {
            HttpClient client = new HttpClient();

            var httpMessage = await client.GetAsync(site);

            return httpMessage.Content.Headers.ContentLength;
        }
    }
}

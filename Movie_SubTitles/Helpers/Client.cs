using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unirest_net.http;

namespace Movie_SubTitles.Helpers
{
    public class SubMaxClient
    {

        public string BaseApiUrl { get; set; }
        public SubMaxClient(string url)
        {
            BaseApiUrl = url;
        }
        public async Task<string> GetSubtitleAsync(string movieName)
        {
            var result = await Unirest.get(string.Format("{0}{1}", BaseApiUrl, movieName)).asStringAsync();

            return result.Body;

        }

    }
}

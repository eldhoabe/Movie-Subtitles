using CookComputing.XmlRpc;
using Movie_SubTitles.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Movie_SubTitles.Core.SubtitleModels;

namespace Movie_SubTitles
{
    public interface IOpenSubtitles : IXmlRpcProxy
    {

        [XmlRpcMethod("LogIn")]
        Models.LoginStruct login(string username, string password, string language, string useragent);

        [XmlRpcMethod("SearchSubtitles")]
        Models.SearchResult SearchSubtitles(string token, Models.subtitleStuct[] stuctarray);



    }
}

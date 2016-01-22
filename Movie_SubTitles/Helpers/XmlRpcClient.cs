using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace Movie_SubTitles.Helpers
{
    public class XmlRpcClient
    {
        private IMath mathProxy;
        public XmlRpcClient()
        {

            mathProxy = XmlRpcProxyGen.Create<IMath>();

        }

        public object Login(string userAgent)
        {
            return mathProxy.login(string.Empty, string.Empty, string.Empty, userAgent);
        }
    }


    public interface IMath : IXmlRpcProxy
    {

        #region Dummy
        [XmlRpcMethod("math.Add")]
        int Add(int a, int b);

        [XmlRpcMethod("math.Subtract")]
        int Subtract(int a, int b);

        [XmlRpcMethod("math.Multiply")]
        int Multiply(int a, int b);

        [XmlRpcMethod("math.Divide")]
        int Divide(int a, int b);
        #endregion

        [XmlRpcMethod("LogIn")]
        object login(string username, string password, string language, string useragent);

        [XmlRpcMethod("SearchSubtitles")]
        object SearchSubtitles(string token, subtitleStucr[] stuctarray);


        
    }

    public struct subtitleStucr
    {
        public string sublanguageid;
        public string moviehash;
        public double moviebytesize;
    };
}

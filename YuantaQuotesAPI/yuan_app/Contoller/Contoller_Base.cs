using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yuan_app
{

    class Contoller_Base
    {
        public AxYuantaQuoteLib.AxYuantaQuote axYuanQt = null;

        public String UserId = String.Empty;
        public String Passwd = String.Empty;
        public String IP = String.Empty;
        public String Port = String.Empty;

        public String Status = String.Empty;


        // 登入
        public void Login(string uid, string pwd, string ip, string port)
        {
            try
            {
                UserId = uid;
                Passwd = pwd;
                IP = ip;
                Port = port;

                this.axYuanQt.SetMktLogon(UserId, Passwd, IP, Port);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
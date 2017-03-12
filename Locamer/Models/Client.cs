using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locamer.Models
{
    public class Client
    {

        private int _id;
        private String _name;

        public void Client(int id)
        {
            this._id = id;
        }
    }
}
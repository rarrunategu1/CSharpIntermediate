﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    //practice with indexers
    class HttpCookieIndexer
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiration { get; set; }
        public HttpCookieIndexer()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}

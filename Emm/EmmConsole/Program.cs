﻿using Emm;
using Emm.Classes;
using System;

namespace EmmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.bbc.com/";

            IEmmParser<IEmmLogger> parser = new EmmBaseLinkParser();
            var crawler = new EmmCrawler(url, parser);
            crawler.Execute();


            IEmmParser<IEmmLogger> parser2 = new EmmImageParser();
            var crawler2 = new EmmCrawler(url, parser);
            crawler.Execute();

            Console.ReadLine();

        }
    }
}

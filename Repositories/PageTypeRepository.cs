using CMS.DocumentEngine.Types.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KenticoMVC.Controllers
{
    public static class PageTypeRepository
    {
        public static IEnumerable<HomePageColorTile> GetAllTiles() => HomePageColorTileProvider.GetHomePageColorTiles();
    }
}
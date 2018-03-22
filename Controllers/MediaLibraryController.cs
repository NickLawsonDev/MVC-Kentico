using CMS.MediaLibrary;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KenticoMVC.Controllers
{
    public class MediaLibraryController : Controller
    {
        public IEnumerable<MediaFileInfo> GetMediaFiles()
        {
            var library = MediaLibraryInfoProvider.GetMediaLibraryInfo("Sample", SiteContext.CurrentSiteName);

            var files = MediaFileInfoProvider.GetMediaFiles()
                .WhereEquals("FileLibraryID", library.LibraryID)
                .WhereEquals("FileExtension", ".jpg");

            return files;
        }

        // GET: MediaLibrary
        public ActionResult Index()
        {
            GetMediaFiles();
            return View();
        }
    }
}
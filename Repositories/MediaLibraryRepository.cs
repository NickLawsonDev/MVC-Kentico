using CMS.MediaLibrary;
using CMS.SiteProvider;
using Kentico.MediaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KenticoMVC.Controllers
{
    public static class MediaLibraryRepository
    {
        public static IEnumerable<MediaFileInfo> GetMediaFiles()
        {
            var library = MediaLibraryInfoProvider.GetMediaLibraryInfo("DerbyDeals", SiteContext.CurrentSiteName);

            var files = MediaFileInfoProvider.GetMediaFiles()
                .WhereEquals("FileLibraryID", library.LibraryID)
                .WhereEquals("FileExtension", ".jpg");

            return files;
        }

        public static string GetMediaFile(string name , string ext = ".jpg")
        {
            var library = MediaLibraryInfoProvider.GetMediaLibraryInfo("DerbyDeals", SiteContext.CurrentSiteName);

            var file = MediaFileInfoProvider.GetMediaFiles()
                .WhereEquals("FileLibraryID", library.LibraryID)
                .WhereEquals("FileExtension", ext)
                .WhereEquals("FileName", name)
                .FirstObject;

            return $"http://{SiteContext.CurrentSite.DomainName}/getmedia/{file.FileGUID}/{file.FileName}";

            //Cannot use until I figure out port issue
            //return file.GetPermanentUrl();
        }
    }
}
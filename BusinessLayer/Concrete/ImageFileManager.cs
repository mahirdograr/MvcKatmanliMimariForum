using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImagesFileDal _imagefiledal;

        public ImageFileManager(IImagesFileDal imagefiledal)
        {
            _imagefiledal = imagefiledal;
        }

        public List<ImageFile> GetList()
        {
            return _imagefiledal.List();
        }
    }
}

namespace NPOI.XWPF.UserModel
{
    public enum PictureType
    {
        /** Extended windows meta file */
        EMF = 2,

        /** Windows Meta File */
        WMF = 3,

        /** Mac PICT format */
        PICT = 4,

        /** JPEG format */
        JPEG = 5,

        /** PNG format */
        PNG = 6,

        /** Device independent bitmap */
        DIB = 7,

        /** GIF image format */
        GIF = 8,
        /**
         * Tag Image File (.tiff)
         */
        TIFF = 9,

        /**
         * Encapsulated Postscript (.eps)
         */
        EPS = 10,


        /**
         * Windows Bitmap (.bmp)
         */
        BMP = 11,

        /**
         * WordPerfect graphics (.wpg)
         */
        WPG = 12,

        /**
         * Scalable Vector Graphics (.svg)
         */
        SVG = 13
    }
    public interface IDocument
    {
    }

}
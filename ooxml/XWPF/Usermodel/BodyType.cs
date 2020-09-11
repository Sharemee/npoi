using System;
namespace NPOI.XWPF.UserModel
{
    /// <summary>
    /// The different kinds of <see cref="IBody"/> that exist
    /// </summary>
    public enum BodyType
    {
        CONTENTCONTROL,
        DOCUMENT,
        HEADER,
        FOOTER,
        FOOTNOTE,
        TABLECELL
    }
}
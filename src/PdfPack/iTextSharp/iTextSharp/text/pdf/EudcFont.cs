using System;

namespace iTextSharp.text.pdf
{
    /// <summary>
    /// 外字フォント
    /// </summary>
    internal class EudcFont : TrueTypeFontUnicode
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="eudcFilePath">TTEのファイル名またはTTEのファイルパス</param>
        /// <param name="enc">エンコード</param>
        internal EudcFont(string eudcFilePath, string enc)
        {
            if (string.IsNullOrEmpty(eudcFilePath)) { throw new ArgumentNullException(nameof(eudcFilePath)); }
            if (string.IsNullOrEmpty(enc)) { throw new ArgumentNullException(nameof(enc)); }
            if (!eudcFilePath.EndsWith(".tte", StringComparison.InvariantCultureIgnoreCase))
            {
                throw new DocumentException(eudcFilePath + " is not a TTE font file.");
            }
            ttcIndex = "";
            encoding = enc;
            fileName = eudcFilePath;
            FontType = FONT_TYPE_TTUNI;
            embedded = true; //フォント埋込

            Process(null, false);
            if (os_2.fsType == 2) { throw new DocumentException($"{fileName} cannot be embedded due to licensing restrictions."); }

            // Sivan
            if ((cmap31 == null && !fontSpecific) || (cmap10 == null && fontSpecific)) { directTextToByte = true; }

            if (fontSpecific)
            {
                fontSpecific = false;
                String tempEncoding = encoding;
                encoding = "";
                CreateEncoding();
                encoding = tempEncoding;
                fontSpecific = true;
            }
            vertical = enc.EndsWith("V");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    public enum E_SyncSourceType
    {
        /// <summary>
        /// 未指定
        /// </summary>
        None = -1,
        /// <summary>
        /// SQL
        /// </summary>
        SQL = 0,
        /// <summary>
        /// Orcale
        /// </summary>
        Orcale = 1,
        /// <summary>
        /// Sybase
        /// </summary>
        Sybase = 2,
        /// <summary>
        /// Excel
        /// </summary>
        Excel = 3,
        /// <summary>
        /// XML
        /// </summary>
        Xml = 4,
        /// <summary>
        /// TXT文档
        /// </summary>
        TXT = 5,
        /// <summary>
        /// 新中新
        /// </summary>
        XZX = 6,
    }
}

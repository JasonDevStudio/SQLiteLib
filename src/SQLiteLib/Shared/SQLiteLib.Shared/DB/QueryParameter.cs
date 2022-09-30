﻿using SQLiteLib.Table.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteEFCore.Shared.DB
{
    public class QueryParameter
    {
        /// <summary>
        /// 数据列
        /// </summary>
        public IDataColumn DataColumn { get; set; }

        /// <summary>
        /// 一元运算逻辑
        /// </summary>
        public string Logic { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// 二元运算逻辑
        /// </summary>
        public string Binary { get; set; }
    }
}

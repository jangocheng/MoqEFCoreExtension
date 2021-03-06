﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamManageSample.Models.DataModels
{
    /// <summary>
    /// 班级操作接口
    /// </summary>
    public interface IClassRepository
    {
        /// <summary>
        /// 添加班级
        /// </summary>
        /// <param name="cls">班级</param>
        /// <returns></returns>
        bool AddClass(Classes cls);

        /// <summary>
        /// 删除班级
        /// </summary>
        /// <param name="id">班级ID</param>
        /// <returns></returns>
        bool RemoveClass(int id);
        /// <summary>
        /// 修改班级
        /// </summary>
        /// <param name="cls">班级</param>
        /// <returns></returns>
        bool ModifyClass(Classes cls);
        /// <summary>
        /// 查询班级
        /// </summary>
        /// <returns></returns>
        IList GetClasses();

    }
}

﻿/*----------------------------------------------------------------
// 文件名：StuCertificate.cs
// 功能描述：学生证书
// 创建者：sysmenu
// 创建时间：2019-4-14
//----------------------------------------------------------------*/
using System;
namespace HST.Art.Core
{
    /// <summary>
    /// StuCertificate
    /// </summary>
    [Serializable]
    public partial class StuCertificate
    {
        public StuCertificate()
        { }
        #region Model
        private int _id;
        private int _userid;
        private string _name;
        private Gender _gender;
        private string _number;
        private int _state = 0;
        private CertificateType _category;
        private string _province;
        private string _city;
        private string _county;
        private DateTime _createdate = DateTime.Now;
        private bool _isdeleted = false;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int UserId
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 性别 0：女，1：男
        /// </summary>
        public Gender Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Number
        {
            set { _number = value; }
            get { return _number; }
        }
        /// <summary>
        /// 0:下架
        /// 1:上架
        /// </summary>
        public int State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 类别：获奖证书、培训证书
        /// </summary>
        public CertificateType Category
        {
            set { _category = value; }
            get { return _category; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Province
        {
            set { _province = value; }
            get { return _province; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string City
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string County
        {
            set { _county = value; }
            get { return _county; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDeleted
        {
            set { _isdeleted = value; }
            get { return _isdeleted; }
        }
        #endregion Model

        public string HeadImg { get; set; }

    }
}


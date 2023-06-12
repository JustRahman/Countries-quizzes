using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    class visitors:XPCustomObject
    {
        #region properties
        decimal fuser_id;
        [Key]
        public decimal user_id
        {
            get { return fuser_id; }
            set { SetPropertyValue<decimal>(nameof(user_id), ref fuser_id, value); }
        }
        string fuser_nickname;
        [Size(50)]
        public string user_nickname
        {
            get { return fuser_nickname; }
            set { SetPropertyValue<string>(nameof(user_nickname), ref fuser_nickname, value); }
        }
        decimal fuser_password;
        public decimal user_password
        {
            get { return fuser_password; }
            set { SetPropertyValue<decimal>(nameof(user_password), ref fuser_password, value); }
        }
        string fuser_loggin;
        [Size(50)]
        public string user_loggin
        {
            get { return fuser_loggin; }
            set { SetPropertyValue<string>(nameof(user_loggin), ref fuser_loggin, value); }
        }
        decimal fuser_type_id;
        public decimal user_type_id
        {
            get { return fuser_type_id; }
            set { SetPropertyValue<decimal>(nameof(user_type_id), ref fuser_type_id, value); }
        }
        string fsecot_1;
        [Size(50)]
        public string secot_1
        {
            get { return fsecot_1; }
            set { SetPropertyValue<string>(nameof(secot_1), ref fsecot_1, value); }
        }
        string fsecot_2;
        [Size(50)]
        public string secot_2
        {
            get { return fsecot_2; }
            set { SetPropertyValue<string>(nameof(secot_2), ref fsecot_2, value); }
        }
        decimal fsecot_3;
        public decimal secot_3
        {
            get { return fsecot_3; }
            set { SetPropertyValue<decimal>(nameof(secot_3), ref fsecot_3, value); }
        }
        decimal fsecot_4;
        public decimal secot_4
        {
            get { return fsecot_4; }
            set { SetPropertyValue<decimal>(nameof(secot_4), ref fsecot_4, value); }
        }
        #endregion



        public visitors(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}

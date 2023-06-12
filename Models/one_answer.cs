using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    class one_answer: XPCustomObject
    {
        #region prop
        int fquestions_id;
        [Key]
        public int questions_id
        {
            get { return fquestions_id; }
            set { SetPropertyValue<int>(nameof(questions_id), ref fquestions_id, value); }
        }
        string fqustion;
        [Size(50)]
        public string qustion
        {
            get { return fqustion; }
            set { SetPropertyValue<string>(nameof(qustion), ref fqustion, value); }
        }
        string fquestion_theme;
        [Size(50)]
        public string question_theme
        {
            get { return fquestion_theme; }
            set { SetPropertyValue<string>(nameof(question_theme), ref fquestion_theme, value); }
        }
        string fquestion_description;
        [Size(50)]
        public string question_description
        {
            get { return fquestion_description; }
            set { SetPropertyValue<string>(nameof(question_description), ref fquestion_description, value); }
        }
        string fquestion_owner;
        [Size(50)]
        public string question_owner
        {
            get { return fquestion_owner; }
            set { SetPropertyValue<string>(nameof(question_owner), ref fquestion_owner, value); }
        }
        string fquestion_type;
        [Size(50)]
        public string question_type
        {
            get { return fquestion_type; }
            set { SetPropertyValue<string>(nameof(question_type), ref fquestion_type, value); }
        }
        string fcorrect_answer;
        [Size(50)]
        public string correct_answer
        {
            get { return fcorrect_answer; }
            set { SetPropertyValue<string>(nameof(correct_answer), ref fcorrect_answer, value); }
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

        public one_answer(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}

using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    class yurtlar : XPCustomObject
    {
        #region properties
        int fyurt_id;
        [Key(true)]
        public int yurt_id
        {
            get { return fyurt_id; }
            set { SetPropertyValue<int>(nameof(yurt_id), ref fyurt_id, value); }
        }
        string fyurt_name;
        [Size(50)]
        public string yurt_name
        {
            get { return fyurt_name; }
            set { SetPropertyValue<string>(nameof(yurt_name), ref fyurt_name, value); }
        }
        string fyurt_main_system;
        [Size(50)]
        public string yurt_main_system
        {
            get { return fyurt_main_system; }
            set { SetPropertyValue<string>(nameof(yurt_main_system), ref fyurt_main_system, value); }
        }
        string fyurt_big_cities;
        [Size(50)]
        public string yurt_big_cities
        {
            get { return fyurt_big_cities; }
            set { SetPropertyValue<string>(nameof(yurt_big_cities), ref fyurt_big_cities, value); }
        }
        string fyurt_currency;
        [Size(50)]
        public string yurt_currency
        {
            get { return fyurt_currency; }
            set { SetPropertyValue<string>(nameof(yurt_currency), ref fyurt_currency, value); }
        }
        string fyurt_main_city;
        [Size(50)]
        public string yurt_main_city
        {
            get { return fyurt_main_city; }
            set { SetPropertyValue<string>(nameof(yurt_main_city), ref fyurt_main_city, value); }
        }
        decimal fyurt_population;
        public decimal yurt_population
        {
            get { return fyurt_population; }
            set { SetPropertyValue<decimal>(nameof(yurt_population), ref fyurt_population, value); }
        }
        decimal fyurt_square;
        public decimal yurt_square
        {
            get { return fyurt_square; }
            set { SetPropertyValue<decimal>(nameof(yurt_square), ref fyurt_square, value); }
        }
        int fyurt_time;
        public int yurt_time
        {
            get { return fyurt_time; }
            set { SetPropertyValue<int>(nameof(yurt_time), ref fyurt_time, value); }
        }
        decimal fyurt_phone;
        public decimal yurt_phone
        {
            get { return fyurt_phone; }
            set { SetPropertyValue<decimal>(nameof(yurt_phone), ref fyurt_phone, value); }
        }
        int fyurt_year;
        public int yurt_year
        {
            get { return fyurt_year; }
            set { SetPropertyValue<int>(nameof(yurt_year), ref fyurt_year, value); }
        }
        string fyurt_first_path;
        [Size(50)]
        public string yurt_first_path
        {
            get { return fyurt_first_path; }
            set { SetPropertyValue<string>(nameof(yurt_first_path), ref fyurt_first_path, value); }
        }
        string fyurt_second_path;
        [Size(50)]
        public string yurt_second_path
        {
            get { return fyurt_second_path; }
            set { SetPropertyValue<string>(nameof(yurt_second_path), ref fyurt_second_path, value); }
        }
        string fyurt_third_path;
        [Size(50)]
        public string yurt_third_path
        {
            get { return fyurt_third_path; }
            set { SetPropertyValue<string>(nameof(yurt_third_path), ref fyurt_third_path, value); }
        }
        string fyurt_forth_pat;
        [Size(50)]
        public string yurt_forth_pat
        {
            get { return fyurt_forth_pat; }
            set { SetPropertyValue<string>(nameof(yurt_forth_pat), ref fyurt_forth_pat, value); }
        }
        string fyurt_fifth_pat;
        [Size(50)]
        public string yurt_fifth_pat
        {
            get { return fyurt_fifth_pat; }
            set { SetPropertyValue<string>(nameof(yurt_fifth_pat), ref fyurt_fifth_pat, value); }
        }
        int fyurt_number;
        public int yurt_number
        {
            get { return fyurt_number; }
            set { SetPropertyValue<int>(nameof(yurt_number), ref fyurt_number, value); }
        }
        #endregion
        #region procedures
        public yurtlar(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        #endregion
    }
}

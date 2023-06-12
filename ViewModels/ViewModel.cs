using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApp1.Models;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using System.IO;
using System.Data.SqlClient;
using WpfApp1.Views;
using System.Windows;
using Microsoft.Win32;


namespace WpfApp1.ViewModels
{
    class ViewModel : ViewModelBase
    {

        public static UnitOfWork uow;

        List<string> surat_url;
        List<string> added;

        int index = 1;
        int k ;
        int diploma;
        
        public INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        #region gerset

        private yurtlar _selected_object;
        public yurtlar selected_object
        {
            get
            {
                return _selected_object;
            }
            set
            {
                SetValue(ref _selected_object, value);
            }

        }

        private string _name_box;
        public string name_box
        {
            get
            {
                return _name_box;
            }
            set
            {
                SetValue(ref _name_box, value);
            }

        }

        private bool _first_rad;
        public bool first_rad
        {
            get
            {
                return _first_rad;
            }
            set
            {
                SetValue(ref _first_rad, value);
            }

        }
        private bool _second_rad;
        public bool second_rad
        {
            get
            {
                return _second_rad;
            }
            set
            {
                SetValue(ref _second_rad, value);
            }

        }
        private bool _third_rad;
        public bool third_rad
        {
            get
            {
                return _third_rad;
            }
            set
            {
                SetValue(ref _third_rad, value);
            }

        }
        private bool _forth_rad;
        public bool forth_rad
        {
            get
            {
                return _forth_rad;
            }
            set
            {
                SetValue(ref _forth_rad, value);
            }

        }

        private visitors _selected_visitors;
        public visitors selected_visitors
        {
            get
            {
                return _selected_visitors;
            }
            set
            {
                SetValue(ref _selected_visitors, value);
            }
        }

        private string _added_coun;
        public string added_coun
        {
            get
            {
                return _added_coun;
            }
            set
            {
                SetValue(ref _added_coun, value);
            }

        }

        private string _show_pic;
        public string show_pic
        {
            get
            {
                return _show_pic;
            }
            set
            {
                SetValue(ref _show_pic, value);
            }

        }

        private bool _selected_without;
        public bool selected_without
        {
            get
            {
                return _selected_without;
            }
            set
            {
                SetValue(ref _selected_without, value);
            }

        }

        private bool _selected_with;
        public bool selected_with
        {
            get
            {
                return _selected_with;
            }
            set
            {
                SetValue(ref _selected_with, value);
            }

        }

        private bool _selected_without2;
        public bool selected_without2
        {
            get
            {
                return _selected_without2;
            }
            set
            {
                SetValue(ref _selected_without2, value);
            }

        }

        private bool _person_checker;
        public bool person_checker
        {
            get
            {
                return _person_checker;
            }
            set
            {
                SetValue(ref _person_checker, value);
            }

        }

        private bool _selected_with2;
        public bool selected_with2
        {
            get
            {
                return _selected_with2;
            }
            set
            {
                SetValue(ref _selected_with2, value);
            }

        }

        private string _last_false_letter;
        public string last_false_letter
        {
            get
            {
                return _last_false_letter;
            }
            set
            {
                SetValue(ref _last_false_letter, value);
            }
        }

        private string _last_true_letter;
        public string last_true_letter
        {
            get
            {
                return _last_true_letter;
            }
            set
            {
                SetValue(ref _last_true_letter, value);
            }
        }

        private int _true_answers;
        public int true_answers
        {
            get
            {
                return _true_answers;
            }
            set
            {
                SetValue(ref _true_answers, value);
            }

        }

        private bool _false_counter;
        public bool false_counter
        {
            get
            {
                return _false_counter;
            }
            set
            {
                SetValue(ref _false_counter, value);
            }
        }
        private int _false_answers;
        public int false_answers
        {
            get
            {
                return _false_answers;
            }
            set
            {
                SetValue(ref _false_answers, value);
            }

        }

        private int _skipped;
        public int skipped
        {
            get
            {
                return _skipped;
            }
            set
            {
                SetValue(ref _skipped, value);
            }

        }

        private string _show_pic2;
        public string show_pic2
        {
            get
            {
                return _show_pic2;
            }
            set
            {
                SetValue(ref _show_pic2, value);
            }

        }

        private string _show_pic3;
        public string show_pic3
        {
            get
            {
                return _show_pic3;
            }
            set
            {
                SetValue(ref _show_pic3, value);
            }

        }

        private string _nickname_box;
        public string nickname_box
        {
            get
            {
                return _nickname_box;
            }
            set
            {
                SetValue(ref _nickname_box, value);
            }

        }

        private decimal _db_role;
        public decimal db_role
        {
            get
            {
                return _db_role;
            }
            set
            {
                SetValue(ref _db_role, value);
            }

        }


        private bool _teacher;
        public bool teacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                SetValue(ref _teacher, value);
            }

        }

        private bool _student;
        public bool student
        {
            get
            {
                return _student;
            }
            set
            {
                SetValue(ref _student, value);
            }

        }

        private int _user_type_id;
        public int user_type_id
        {
            get
            {
                return _user_type_id;
            }
            set
            {
                SetValue(ref _user_type_id, value);
            }

        }

        private one_answer _db_one;
        public one_answer db_one
        {
            get
            {
                return _db_one;
            }
            set
            {
                SetValue(ref _db_one , value);
            }
        }

        private string _password_box;
        public string password_box
        {
            get
            {
                return _password_box;
            }
            set
            {
                SetValue(ref _password_box, value);
            }

        }

        private one_answer _question_without;
        public one_answer question_without
        {
            get
            {
                return _question_without;
            }
            set
            {
                SetValue(ref _question_without, value);
            }

        }

        private string _question_checker;
        public string question_checker
        {
            get
            {
                return _question_checker;
            }
            set
            {
                SetValue(ref _question_checker, value);
            }

        }
        
        private string _item_sel2;
        public string item_sel2
        {
            get
            {
                return _item_sel2;
            }
            set
            {
                SetValue(ref _item_sel2, value);
            }

        }

        private string _item_sel;
        public string item_sel
        {
            get
            {
                return _item_sel;
            }
            set
            {
                SetValue(ref _item_sel, value);
            }

        }

        private float _list_name;
        public float list_name
        {
            get
            {
                return _list_name;
            }
            set
            {
                SetValue(ref _list_name, value);
            }

        }

        private bool _enabled;
        public bool enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                SetValue(ref _enabled, value);
            }

        }

        private bool _teacher2;
        public bool teacher2
        {
            get
            {
                return _teacher2;
            }
            set
            {
                SetValue(ref _teacher2, value);
            }

        }

        private bool _student2;
        public bool student2
        {
            get
            {
                return _student2;
            }
            set
            {
                SetValue(ref _student2, value);
            }

        }

        private bool _Butt_checked;
        public bool Butt_checked
        {
            get
            {
                return _Butt_checked;
            }
            set
            {
                SetValue(ref _Butt_checked, value);
            }

        }
        private bool _Butt_checked2;
        public bool Butt_checked2
        {
            get
            {
                return _Butt_checked2;
            }
            set
            {
                SetValue(ref _Butt_checked2, value);
            }

        }
        private bool _Butt_checked3;
        public bool Butt_checked3
        {
            get
            {
                return _Butt_checked3;
            }
            set
            {
                SetValue(ref _Butt_checked3, value);
            }

        }
        private bool _Butt_checked4;
        public bool Butt_checked4
        {
            get
            {
                return _Butt_checked4;
            }
            set
            {
                SetValue(ref _Butt_checked4, value);
            }

        }

        private XPCollection<yurtlar> _yurts_db;
        public XPCollection<yurtlar> Yurts_db
        {
            get
            {
                return _yurts_db;
            }
            set
            {
                SetValue(ref _yurts_db, value);
            }
        }

        private ObservableCollection<yurt> _yurts;
        public ObservableCollection<yurt> Yurts
        {
            get
            {
                return _yurts;
            }
            set
            {
                SetValue(ref _yurts, value);
            }
        }
        private XPCollection<yurtlar> _countries;
        public XPCollection<yurtlar> Countries
        {
            get
            {
                return _countries;
            }
            set
            {
                SetValue(ref _countries, value);
            }
        }

        private string _items_sel;
        public string items_sel
        {
            get
            {
                return _items_sel;
            }
            set
            {
                SetValue(ref _items_sel , value);
            }
        }

       

        public XPCollection<one_answer> one_questions { get; set; }

        public XPCollection<four_answer> four_questions { get; set; }

        public ObservableCollection<string> items_xpo { get; set; }


        private XPCollection<visitors> _people;
        public XPCollection<visitors> people
        {
            get
            {
                return _people;
            }
            set
            {
                SetValue(ref _people, value);
            }
        }

        private four_answer _four_Answer;
        public four_answer four_Answer
        {
            get
            {
                return _four_Answer;
            }
            set
            {
                SetValue(ref _four_Answer , value);
            }
        }

        private string _first_answer;
        public string first_answer
        {
            get
            {
                return _first_answer;
            }
            set
            {
                SetValue(ref _first_answer, value);
            }
        }

        private string _second_answer;
        public string second_answer
        {
            get
            {
                return _second_answer;
            }
            set
            {
                SetValue(ref _second_answer, value);
            }
        } 

        private string _third_answer;
        public string third_answer
        {
            get
            {
                return _third_answer;
            }
            set
            {
                SetValue(ref _third_answer, value);
            }
        }

        private string _forth_answer;
        public string forth_answer
        {
            get
            {
                return _forth_answer;
            }
            set
            {
                SetValue(ref _forth_answer, value);
            }
        }

        private string _db_password;
        public string db_password
        {
            get
            {
                return _db_password;
            }
            set
            {
                SetValue(ref _db_password, value);
            }
        }

        private string _db_nickname;
        public string db_nickname
        {
            get
            {
                return _db_nickname;
            }
            set
            {
                SetValue(ref _db_nickname, value);
            }
        }

        private string _question_with;
        public string question_with
        {
            get
            {
                return _question_with;
            }
            set
            {
                SetValue(ref _question_with, value);
            }
        }

        private string _db_name;
        public string db_name
        {
            get
            {
                return _db_name;
            }
            set
            {
                SetValue(ref _db_name, value);
            }
        }

        private yurtlar _selected_yurt;
        public yurtlar selected_yurt
        {
            get
            {
                return _selected_yurt;
            }
            set
            {
                SetValue(ref _selected_yurt, value);
            }
        }

        private four_answer _db_four;
        public four_answer db_four
        {
            get
            {
                return _db_four;
            }
            set
            {
                SetValue(ref _db_four, value);
            }
        }

        #endregion

        #region delegatecommand

        public DelegateCommand with_option { get; set; }

        public DelegateCommand without_option { get; set; } 

        public DelegateCommand go_back { get; set; } 

        public DelegateCommand OnViewLoadedCommand { get; set; }

        public DelegateCommand save_one { get; set; }

        public DelegateCommand browse_btn { get; set; }

        public DelegateCommand browse_btn2 { get; set; }

        public DelegateCommand browse_btn3 { get; set; }

        public DelegateCommand role_checker { get; set; }

        public DelegateCommand Selection_changed_cmd { get; set; }

        public DelegateCommand skip { get; set; }

        public DelegateCommand update { get; set; }

        public DelegateCommand delete { get; set; }

        public DelegateCommand save_cmd { get; set; }

        public DelegateCommand right_cmd { get; set; }
         
        public DelegateCommand left_cmd { get; set; }

        public DelegateCommand save_four { get; set; }

        #endregion

        ///public INavigationService Service { get { return this.GetService<INavigationService>(); } }

        public ViewModel()
        {
          //  INavigationService 
            uow = new UnitOfWork();

            items_xpo = new ObservableCollection<string>();
            Yurts = new ObservableCollection<yurt>();

            one_questions = new XPCollection<one_answer>(uow);
            four_questions = new XPCollection<four_answer>(uow);
            Yurts_db = new XPCollection<yurtlar>(uow);
            Countries = new XPCollection<yurtlar>(uow);
            people = new XPCollection<visitors>(uow);

            uow.CommitChanges();
            enabled = ulanyjy.is_enabled;

            save_four = new DelegateCommand(()=> save_four_cmd());
            save_one = new DelegateCommand(()=> save_one_cmd());
            update = new DelegateCommand(() => update_method());
            delete = new DelegateCommand(() => delete_method());
            save_cmd = new DelegateCommand(() => save_method());
            left_cmd = new DelegateCommand(() => left_method());
            with_option = new DelegateCommand(()=>with_option_cmd());
            right_cmd = new DelegateCommand(() => right_method());
            browse_btn = new DelegateCommand(()=> browse_btn_method());
            OnViewLoadedCommand = new DelegateCommand(()=> OnViewLoaded());
            browse_btn2 = new DelegateCommand(() => browse_btn_method2());
            browse_btn3 = new DelegateCommand(() => browse_btn_method3());
            role_checker = new DelegateCommand(() => role_checker_cmd());  
            without_option = new DelegateCommand(() => without_option_cmd()); 
            go_back = new DelegateCommand(() => go_back_cmd());
            skip = new DelegateCommand(()=> skip_cmd());
            Selection_changed_cmd = new DelegateCommand(() => Selection_changed());

          //  uow.CommitChanges();
            surat_url = new List<string>(); 
            added = new List<string>(); 
            db_four = new four_answer(uow);

            //  uow.CommitChanges();


            items_xpo.Add("Answer without options");
            items_xpo.Add("Answer with options");
            items_xpo.Add("Add without options");
            items_xpo.Add("Add with options");

            k = 0;
            true_answers = 0;
            false_answers = 0;
            skipped = 0;
            false_counter = false;
          //  uow.CommitChanges();
        }

        private void save_four_cmd()
        {
            // uow.CommitChanges();


            if (db_four.question == null || db_four.question_type == null || db_four.question_theme == null || db_four.question_owner == null || db_four.answer_1 == null || db_four.answer_2 == null || db_four.answer_3 == null || db_four.answer_4 == null)
            {
                uow.DropChanges();
                MessageBox.Show("Please try fill all textblocks");
                

            }
            else
            {
                if (first_rad == true)
                {
                    db_four.correct_answer = db_four.answer_1;
                }
                else if (second_rad == true)
                {
                    db_four.correct_answer = db_four.answer_2;
                }
                else if (third_rad == true)
                {
                    db_four.correct_answer = db_four.answer_3;
                }
                else if (forth_rad == true)
                {
                    db_four.correct_answer = db_four.answer_4;
                }

                //uow.DropChanges();
                db_four.Save();
                uow.CommitChanges();
                db_four = new four_answer(uow);
                //db_four.questions_id++;
            }
        }

        private void save_one_cmd()
        {
            db_one = new one_answer(uow);

            if (db_one.qustion == null || db_one.question_type == null || db_one.question_theme == null || db_one.question_owner == null)
            {
                MessageBox.Show("Please try fill all textblocks");
                 
            }
            else
            {
                try
                {
                   // uow.DropChanges();
                    db_one.Save();
                    uow.CommitChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
              
            }
            
        }
        
        private void skip_cmd()
        {

            
            if (item_sel == "Answer without options" && k == one_questions.Count - 1)
            {
                diploma = k;
                question_without = one_questions[k];
                k = -1;
                 

            }
            else if (item_sel == "Answer with options" && k == four_questions.Count - 1)
            {
                diploma = k;
                four_Answer = four_questions[k];
                k = -1;
              

            }

            k++;
            if (false_counter == false)
            {
                skipped++;
                
            }
            false_counter = false;

            if (item_sel == "Answer without options")
            {
                question_checker = " ";
                question_without = one_questions[k];
            }
            else if (item_sel == "Answer with options")
            {
                four_Answer = four_questions[k];
            }

             
           

          
            
            

            if (item_sel == "Answer without options" && diploma == one_questions.Count - 1)
            {
                MessageBox.Show($"There are {one_questions.Count} questions. You make {true_answers} true answer{last_true_letter} and {false_answers} false answer{last_false_letter}. You skipped {skipped} times");
                skipped = 0;
                diploma = 0;
                true_answers = 0;
                false_answers = 0;

            }
            else if (item_sel == "Answer with options" && diploma == four_questions.Count - 1)
            {
                MessageBox.Show($"There are {four_questions.Count} questions. You make {true_answers} true answer{last_true_letter} and {false_answers} false answer{last_false_letter}. You skipped {skipped} times");
                skipped = 0;
                diploma = 0;
                true_answers = 0;
                false_answers = 0;
                
            }

        }

        private void with_option_cmd()
        {

            if (true_answers > 1 || true_answers > 0)
            {
                last_true_letter = "s";
            }
            else if (true_answers == 1 || true_answers == 0)
            {
                last_true_letter = " ";
            }
            else if (false_answers > 1 || false_answers > 0)
            {
                last_false_letter = "s";
            }
            else if (false_answers == 1 || false_answers == 0)
            {
                last_false_letter = " ";
            }

            if (k == four_questions.Count - 1)
            {
                diploma = k;
                k = -1;
            }




            
            
            if (Butt_checked == true && four_Answer.answer_1 == four_Answer.correct_answer)
            {
                MessageBox.Show("Excellent");
                k++;
                four_Answer = four_questions[k];
                Butt_checked = false;
                if (false_counter == false)
                {
                    true_answers++;
                }
                false_counter = false;
                

            }
            else if (Butt_checked2 == true && four_Answer.answer_2 == four_Answer.correct_answer)
            {
                MessageBox.Show("Excellent");
                k++;
                four_Answer = four_questions[k];
                Butt_checked2 = false; 
                if (false_counter == false)
                {
                    true_answers++;
                }
                false_counter = false;
            }
            else if (Butt_checked3 == true && four_Answer.answer_3 == four_Answer.correct_answer)
            {
                MessageBox.Show("Excellent");
                k++;
                four_Answer = four_questions[k];
                Butt_checked3 = false; 
                if (false_counter == false)
                {
                    true_answers++;
                }
                false_counter = false;
            }
            else if (Butt_checked4 == true && four_Answer.answer_4 == four_Answer.correct_answer)
            {
                MessageBox.Show("Excellent");
                k++;
                four_Answer = four_questions[k];
                Butt_checked4 = false; 
                if (false_counter == false)
                {
                    true_answers++;
                }
                false_counter = false;
            }
            else
            {
                MessageBox.Show("Try again");
                if (false_counter == false)
                {
                    false_answers++;
                    false_counter = true;
                }
            }


            if (diploma == four_questions.Count - 1 && false_counter == false)
            {
                MessageBox.Show($"There are {four_questions.Count} questions. You make {true_answers} true answer{last_true_letter} and {false_answers} false answer{last_false_letter}. You skipped {skipped} times");
                skipped = 0;
                diploma = 0;
                true_answers = 0;
                false_answers = 0;

            }



        }

        private void Selection_changed()
        {

            if (item_sel == "Answer without options")
            {
                ulanyjy.question_type = 1;

                question_without = one_questions[k];


                

                NavigationService.Navigate("View4", null, this);

            }
            else if (item_sel == "Answer with options")
            {
                ulanyjy.question_type = 0;

                four_Answer = four_questions[k]; 


                NavigationService.Navigate("View5", null, this);
            }
            else if (item_sel == "Add without options")
            {
                ulanyjy.question_type = 2;

                NavigationService.Navigate("View6" , null , this);
            }
            else if (item_sel == "Add with options")
            {
                ulanyjy.question_type = 3;

                NavigationService.Navigate("View7", null, this);
            }
            else
            {
                ulanyjy.question_type = 4;
            }
        }

        private void go_back_cmd()
        {

            try
            {
                item_sel = " ";
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void without_option_cmd()
        {

            int counter = 0;
            bool sense = false;
            string test_str = question_checker.ToLower().Trim(' ');


            if (true_answers > 1 || true_answers > 0)
            {
                last_true_letter = "s";
            }
            else if (true_answers == 1 || true_answers == 0)
            {
                last_true_letter = " ";
            }
            else if (false_answers > 1 || false_answers > 0)
            {
                last_false_letter = "s";
            }
            else if (false_answers == 1 || false_answers == 0)
            {
                last_false_letter = " ";
            }


            if (k == one_questions.Count - 1)
            {
                diploma = k;
                k = -1;
            }

            if (question_checker.Trim(' ') == "")
            {
                MessageBox.Show("You forget to write your answer");
            }
            else if (test_str== question_without.correct_answer.ToLower().Trim(' '))
            {
                MessageBox.Show("Excellent");
                if (false_counter == false)
                {
                    true_answers++;
                }
                false_counter = false;
                k++;
                question_checker = " ";
                question_without = one_questions[k]; 

            }
            else
            {
                for (int i = 0; i < question_without.correct_answer.Length; i++)
                {
                    if (question_checker[i].ToString().ToLower() == question_without.correct_answer[i].ToString().ToLower())
                    {
                        continue;
                    }
                    else
                    {
                        counter++;
                    }

                    if (counter > 3)
                    {
                        MessageBox.Show("There is more than 3 mistakes in your answer. Check it!!");
                        sense = true;
                        break;
                    }
                }
                if (sense == true)
                {
                    MessageBox.Show("Try again");
                    if (false_counter == false)
                    {
                        false_answers++;
                        false_counter = true;
                    }

                }
                else
                {
                    MessageBox.Show($"There are {counter} mistakes , but we understand that you give right answer. Not bad!!!");
                    k++;
                    question_checker = " ";
                    question_without = one_questions[k];
                    if (false_counter == false)
                    {
                        true_answers++;
                    }
                    false_counter = false;
                }


            }


            if (diploma == one_questions.Count - 1 && false_counter == false)
            {
                MessageBox.Show($"There are {one_questions.Count} questions. You make {true_answers} true answer{last_true_letter} and {false_answers} false answer{last_false_letter}. You skipped {skipped} times");
                skipped = 0;
                diploma = 0;
                true_answers = 0;
                false_answers = 0;

            }




             
        }


        public void OnViewLoaded()
        {
           NavigationService.Navigate("View2", null, this);
        }

        private void role_checker_cmd()
        {
          //  selected_visitors = new visitors(uow);

            if (_teacher2 == true)
            {
                _user_type_id = 1;
            }
            else if (_student2 == true)
            {
                _user_type_id = 0;
            }
            else
            {
                _user_type_id = 2;
                
            }

            if (_password_box == "" || _nickname_box == "" || _name_box == "" || _user_type_id == 2)
            {
                MessageBox.Show("Enter your password or nickname or role , please");
            }
            else
            {
                foreach (var item in people)
                {
                    if (int.Parse(_password_box) == item.user_password && _nickname_box == item.user_nickname && _name_box == item.user_loggin && _user_type_id == item.user_type_id)
                    {
                        ulanyjy.user_loggin = _name_box;
                        ulanyjy.user_nickname = _nickname_box;
                        

                        if (user_type_id == 1)
                        {
                            ulanyjy.is_enabled = true;
                        }
                        else if (user_type_id == 0)
                        {
                            ulanyjy.is_enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Uuups, you forget to choose your role");
                        }

                        MessageBox.Show($"You in your {_name_box} account");

                        NavigationService.Navigate("View1", null, this);

                        break;
                    }
                    else
                    {
                        MessageBox.Show("You made a mistake?");
                    }



                    uow.CommitChanges();
                }
                

            }
        }
         
        private void browse_btn_method3()
        {
         
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                string path2 = System.AppDomain.CurrentDomain.BaseDirectory;
                if (selected_yurt.yurt_name == "")
                {
                    MessageBox.Show("You don't enter name of your country.Please , enter .It will be easy to identify your photo");
                }
                else
                {
                    if (!Directory.Exists(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}"))
                    {
                        Directory.CreateDirectory(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}");
                        File.Copy(openFile.FileName, Path.Combine(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}", $"{selected_yurt.yurt_name}_surat{3}.jpg"));
                    }
                    else
                    {
                        File.Delete(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}\\{selected_yurt.yurt_name}_surat{3}.jpg");
                        File.Copy(openFile.FileName, Path.Combine(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}", $"{selected_yurt.yurt_name}_surat{3}.jpg"));
                    }
                }
                _selected_yurt.yurt_third_path = path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}\\{selected_yurt.yurt_name}_surat{3}.jpg";

            }
            surat_url.Add(openFile.FileName);



        }

        private void browse_btn_method2()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                string path2 = System.AppDomain.CurrentDomain.BaseDirectory;
                if (selected_yurt.yurt_name == "")
                {
                    MessageBox.Show("You don't enter name of your country.Please , enter .It will be easy to identify your photo");
                }
                else
                {
                    if (!Directory.Exists(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}"))
                    {
                        Directory.CreateDirectory(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}");
                        File.Copy(openFile.FileName, Path.Combine(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}", $"{selected_yurt.yurt_name}_surat{2}.jpg"));
                    }
                    else
                    {
                        File.Delete(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}\\{selected_yurt.yurt_name}_surat{2}.jpg");
                        File.Copy(openFile.FileName, Path.Combine(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}", $"{selected_yurt.yurt_name}_surat{2}.jpg"));
                    }
                }
                _selected_yurt.yurt_second_path = path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}\\{selected_yurt.yurt_name}_surat{2}.jpg";

            }
            surat_url.Add(openFile.FileName);
        }

        private void browse_btn_method()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                
                string path2 = System.AppDomain.CurrentDomain.BaseDirectory;
                if (selected_yurt.yurt_name == "")
                {
                    MessageBox.Show("You don't enter name of your country.Please , enter .It will be easy to identify your photo");
                }
                else
                {
                    if (!Directory.Exists(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}"))
                    {
                        Directory.CreateDirectory(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}");
                        File.Copy(openFile.FileName, Path.Combine(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}", $"{selected_yurt.yurt_name}_surat{1}.jpg"));
                    }
                    else
                    {
                        File.Delete(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}\\{selected_yurt.yurt_name}_surat{1}.jpg");
                        File.Copy(openFile.FileName, Path.Combine(path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}", $"{selected_yurt.yurt_name}_surat{1}.jpg"));
                    }
                }
                _selected_yurt.yurt_first_path = path2 + $"\\Suratlar2\\{selected_yurt.yurt_name}\\{selected_yurt.yurt_name}_surat{1}.jpg";

            }
            surat_url.Add(openFile.FileName);
        }

        private void right_method()
        {
            if (index == added.Count)
            {
                index = 0;
            }
            _added_coun = added[index];
            index++;
        }

        private void left_method()
        {
            index = index - 1;
            if (-1 == index)
            {
                index = added.Count - 1;
            }
            _added_coun = added[index];
        }

        private void save_method()
        {
            selected_yurt = new yurtlar(uow);

            int counter = 0;
            bool yurt_check = added.Contains(selected_yurt.yurt_name);
            if (!yurt_check)
            {
                foreach (string url_place in surat_url)
                {
                    string[] spliter = url_place.Split('\\');
                    string path = spliter[spliter.Length - 1] + spliter[spliter.Length - 2] + spliter[spliter.Length - 3];
                    if (counter == 0)
                    {
                        _selected_yurt.yurt_first_path = path;
                    }
                    else if (counter == 1)
                    {
                        _selected_yurt.yurt_second_path = path;
                    }
                    else if (counter == 2)
                    {
                        _selected_yurt.yurt_third_path = path;
                    }
                    counter++;


                }

                selected_yurt.Save();
                uow.CommitChanges();
                 





            }
            else
            {
                MessageBox.Show("This country had been added before. Chose another", "Wrong");
            }
        }

        private void delete_method()
        {
            try
            {

                selected_yurt.Delete();
                uow.CommitChanges();
                 



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void update_method()
        {
            #region upgrade

            try
            {
                try
                {
                    selected_yurt.Save();
                    uow.CommitChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

            #endregion
        }

        

    }
}
 
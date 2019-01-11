using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace thyroid.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="نام کاربری را وارد کنید")]
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }

        [Required(ErrorMessage = "کلمه عبور را وارد کنید")]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

    }
    public class demographic
    {
        [Required(ErrorMessage = "کد ملی را وارد کنید")]
        [Display(Name = "کد ملی")]
        public string melicode { get; set; }

        [Required(ErrorMessage = "نام شخص را وارد کنید")]
        [Display(Name = "نام")]
        public string fname { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "فامیلی")]
        public string family { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "ن پدر")]
        public string father { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "ت تولد")]
        public string birth { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]        
        [Display(Name = "سن")]
        public string age { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "جنسیت")]
        public string sex { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "نژاد")]
        public string ethnicity { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "ت همراه")]
        public string mob { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "ت ثابت")]
        public string tel { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "دانشگاه")]
        public string univ { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "شهرستان")]
        public string city { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "آدرس")]
        public string address { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "ش پرونده")]
        public string clinic_no { get; set; }
    }

    public class initdata
    {
        [Required(ErrorMessage = "وزن هنگام تولد را وارد کنید")]
        [Display(Name = "وزن هنگام تولد")]
        public string birth_weight { get; set; }

        [Required(ErrorMessage = "نام شخص را وارد کنید")]
        [Display(Name = "قد هنگام تولد")]
        public string birth_height { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "دور سر هنگام تولد")]
        public string birth_head { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "زمان اولین نمونه گیری")]
        public string frst_sample { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "سن نوزاد در زمان شروع")]
        public string init_age { get; set; }
    }

    public class evaldata
    {
        [Required(ErrorMessage = "وزن هنگام تولد را وارد کنید")]
        [Display(Name = "تست تایید تشخیص سرمی")]
        public string serom_diag { get; set; }

        [Required(ErrorMessage = "نام شخص را وارد کنید")]
        [Display(Name = "تاریخ ارجاع به پزشک فوکال")]
        public string focal_phys_date { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "اولین دوز داروی تجویزی(لووتیروکسین)")]
        public string frst_lotiroxin { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "دوز داروی لووتیروکسین در دوره های بعدی")]
        public string nxt_lotiroxin { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "تاریخ پیگیری و مراقبت های بعدی")]
        public string nxt_care_date { get; set; }
    }

    public class riskfactor
    {
        [Required(ErrorMessage = "وزن هنگام تولد را وارد کنید")]
        [Display(Name = "جنسیت نوزاد")]
        public string child_sex { get; set; }

        [Required(ErrorMessage = "نام شخص را وارد کنید")]
        [Display(Name = "بیماری تیروئید مادر(پرکاری-کم کاری)")]
        public string mother_disease { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "سن مادر در زمان بارداری")]
        public string pregnancy_m_age { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "مدت زمان حاملگی(هفته)")]
        public string pregnancy_duration { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "وزن نوزاد")]
        public string child_weight { get; set; }

        [Required(ErrorMessage = "وزن هنگام تولد را وارد کنید")]
        [Display(Name = "کمبود ید در منطقه")]
        public string iod_shortage { get; set; }

        [Required(ErrorMessage = "نام شخص را وارد کنید")]
        [Display(Name = "وراثت (ازدواج فامیلی)")]
        public string family_marriage { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "نوبت (رتبه) بارداری")]
        public string pregnancy_no { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "زردی نوزاد")]
        public string child_yellow { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "دو یا چند قلوئی")]
        public string twin_child { get; set; }

        [Required(ErrorMessage = "وزن هنگام تولد را وارد کنید")]
        [Display(Name = "فصل تولد")]
        public string birth_season { get; set; }

        [Required(ErrorMessage = "نام شخص را وارد کنید")]
        [Display(Name = "مصرف داروهای خاص")]
        public string spec_drug { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "بهبود روشهای تشخیص آزمایشگاهی")]
        public string lab_method_improve { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "سندروم داون")]
        public string down_sandrome { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "همانژیوم بزرگ کبدی")]
        public string liver_hemangiom { get; set; }

        [Required(ErrorMessage = "وزن هنگام تولد را وارد کنید")]
        [Display(Name = "دیابت حاملگی مادر")]
        public string pregnancy_diabet { get; set; }

        [Required(ErrorMessage = "نام شخص را وارد کنید")]
        [Display(Name = "نوع زایمان")]
        public string child_birth_type { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "سابقه دریافت یا تعویض خون نوزاد")]
        public string child_blood_rec { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "مصرف داروهای ضدتیروئیدی در مادر")]
        public string anty_thyr_drug { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "سابقه مصرف بتادین")]
        public string betadin_usage { get; set; }

        [Required(ErrorMessage = "وزن هنگام تولد را وارد کنید")]
        [Display(Name = "مصرف سبزیجات و میوه جات حاوی گواتروژن هادر در مادر")]
        public string guatrogen_subs { get; set; }

        [Required(ErrorMessage = "نام شخص را وارد کنید")]
        [Display(Name = "مادر در معرض ید بالا")]
        public string high_iod { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "مصرف داروهای آمیودارون،سیتوکین ها ،دوپامین ،آگونیست ها،در مادر")]
        public string amio_drug_use { get; set; }
       
    }

    public class etiology
    {     

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "اختلال در تکامل غده تیروئید سونو تیرویید ")]
        public string evolotion_disorder { get; set; }
    }

    public class labdata
    {
        [Required(ErrorMessage = "نام شخص را وارد کنید")]
        [Display(Name = "سطح TSH در کاغذ فیلتر")]
        public float tsh_filter { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "سطح سرمی T3RU")]
        public float t3ru_serom { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "آزمایش تایید تشخیص سرمی TSH")]
        public string tsh_seromdiag { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "آزمایش تایید تشخیص سرمی T4")]
        public string t4_seromdiag { get; set; }

        [Required(ErrorMessage = "وزن هنگام تولد را وارد کنید")]
        [Display(Name = "سطح سرمی FreeT4")]
        public string fteet4_serom { get; set; }

        [Required(ErrorMessage = "نام شخص را وارد کنید")]
        [Display(Name = "سطح TSH در مراقبت های مختلف( از اول تا هفدهم )")]
        public string tsh_level { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "سطح T4یاfreeT4در مراقبت های مختلف (از اول تا هفدهم )")]
        public string t4_freet4 { get; set; }
    }

    public class imagedata
    {

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Thyroid ultrasound ")]
        public string ultrasound { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "scintigraphyThyroid ")]
        public string scintigraphy { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "گرافی زانو ")]
        public string zanugraphy { get; set; }
    }

    public class diag
    {
        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Development delay")]
        public string develop_delay { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Mental retardation  ")]
        public string mental_retard { get; set; }        

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Infantile cerebral palsy ")]
        public string infantil { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Umbilical hernia ")]
        public string umbilical { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Constipation ")]
        public string constipation { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Short stature ")]
        public string short_stat { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Jaundice ")]
        public string jaundice { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Abdominal distension ")]
        public string abdominal_dis { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Hypotonia ")]
        public string hypotonia { get; set; }
    }

    public class follow
    {
        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "قطع درمان")]
        public bool treat_cut { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "در حال درمان")]
        public bool treating { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "ارجاع به مراکز دیگر")]
        public bool divert_to { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "مهاجرت از استان")]
        public bool migration { get; set; }
    }

    public class anomaly
    {
        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Developmental retardation")]
        public bool develop_retard { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Mental retardation")]
        public bool mental_retard { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Language retardation")]
        public bool lang_retard { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Congenital heart defects")]
        public bool congenitial { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Atrial septum defect(ASD)")]
        public bool artial { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Ventricular septum defect(VSD)")]
        public bool ventricular { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Persistent foramen ovale(PFO)")]
        public bool ovale { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Persistent ductus arteriosus(PDA)")]
        public bool ductus { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Aortic isthmus stenosis")]
        public bool aortic { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Pulmonary stenosis")]
        public bool pulmonary { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Microsomia")]
        public bool microsomia { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Hearing impairment")]
        public bool hearing { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Congenital anomaly of digestive-system")]
        public bool congenital { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Genito-urethral malformations")]
        public bool genito { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "Anomaly kidney")]
        public bool kidney { get; set; }

        [Required(ErrorMessage = "نام خانوادگی شخص را وارد کنید")]
        [Display(Name = "other")]
        public bool other { get; set; }
    }
    public class Person
    {
       public demographic person_demog { get; set; }
       public initdata person_init{get;set;}
       public evaldata person_eval { get; set; }
       public riskfactor person_risk { get; set; }
       public etiology person_etiology { get; set; }
       public labdata person_labdata { get; set; }
       public imagedata person_image { get; set; }
       public diag person_diag { get; set; }
       public follow person_follow { get; set; }
       public anomaly person_anomaly { get; set; }
    }
}
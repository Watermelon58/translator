using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TranslatorUI.Windows;

namespace TranslatorUI.Pages
{
    /// <summary>
    /// CommunityPage.xaml 的交互逻辑
    /// </summary>
    public partial class CommunityPage : Page
    {
        public List<Question> QuestionList { get; set; }
        public List<Answer> AnswerList { get; set; }
        public CommunityPage()
        {
            InitializeComponent();
            QuestionList = new List<Question>()
            {
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
            };
            AnswerList = new List<Answer>()
            {
                new Answer(),
                new Answer(),
                new Answer(),
                new Answer(),
                new Answer(),
                new Answer(),
                new Answer(),
                new Answer(),
                new Answer(),
                new Answer(),
                new Answer(),
                new Answer(),
                new Answer(),
                new Answer(),

            };
            this.QuesItem.ItemsSource = QuestionList;
            this.AnsItem.ItemsSource = AnswerList;
            this.ques_info.DataContext = QuestionList[0];
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow login = new LogInWindow();
            login.ShowDialog();
        }
    }

    public class Question
    {
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public int Reward { get; set; }
        public DateTime CreateTime { get; set; }
        public int AnswerId { get; set; }
        public bool IsAdopt { get; set; }
        public string IsAdoptToString { get; set; }
        public string UserId { get; set; }
        public List<Answer> Answers { get; set; }
        public Question()
        {
            QuestionId = 1;
            Content = "xx今天复习了吗？复习了吗？复习了吗？复习了吗？";
            Reward = 3;
            CreateTime = DateTime.Now;
            AnswerId = 1;
            IsAdopt = true;
            UserId = "2";
            Answers = new List<Answer>();
            Answers.Add(new Answer());
        }
    }
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsAdopted { get; set; }
        public string UserId { get; set; }
        public int QuestionId { get; set; }
        public bool IsMine { get; set; }
        public Answer()
        {
            AnswerId = 100;
            Content = "快了快了我马上！";
            CreateTime = DateTime.Now;
            IsAdopted = true;
            IsMine = true;
            UserId = "200";
            QuestionId = 1;
        }
    }
}

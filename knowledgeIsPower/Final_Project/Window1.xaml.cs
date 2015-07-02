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
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Threading;

namespace Final_Project
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    /// 

    public partial class Window1 : Window
    {

        //private Question question;
        private int _round=3;
        private int _score = 0;
        private int _money = 0;
        private int _level;
        private int _stake;
        private int _time;
        private int _ans;
        private int _index;
        private int _combo=0;
        private string[] question_array = { "下列何者不是香港四天王?", "12+88=?", "政大遭人詬病的一項設施是什麼?", "下列哪位老師教視窗程式?", "下列哪項桌遊源自電影?", "下列哪個樂器最大?", "下列何者不是apple的產品?", "誰臥薪嘗膽？", "袋龍進化是？", "愛因斯坦因為什麼拿到諾貝爾獎？", "韓國在哪裏？", "詩鬼是？", "光的三原色是？", "下列何文明不再亞洲？", "哪個字筆畫較多？", "何者不是陶吉吉的歌？", "摩托車考直線前進幾秒？", "滯留峰會帶來？", "「廿」怎麼念？", "水的化學式是？", "it's a peace of cake指？" };
        private string[] one_array = { "張學友", "101", "搖擺哥", "張景堯", "蹦!", "木箱鼓", "iTouch", "勾踐", "皮卡丘", "安培定律", "中國以北", "李白", "紅黑黃", "蘇美人", "龔", "想你的夜", "2", "颱風", "ㄦˋ", "H2SO4", "事情簡單" };
        private string[] two_array = { "黎明", "1000", "羅馬廣場", "張宏慶", "富饒之城", "薩克斯風", "iPhone", "西施", "鐵甲暴龍", "莫非定律", "中國以南", "李商隱", "紅白藍", "馬雅人", "龜", "普通朋友", "20", "海嘯", "ㄋ一ㄢˋ", "O2", "很好吃" };
        private string[] three_array = { "黃昏", "100", "四維堂", "唐揆", "矮人礦工", "低音提琴", "iWatch", "項羽", "超袋龍", "光電效應", "中國以西", "李賀", "紅藍綠", "仰韶人", "多", "二十二", "22", "梅雨", "ㄍㄢ", "CH3COOH", "很軟" };
        private string[] four_array = { "劉德華", "110", "水岸電梯", "陳恭", "風聲", "三角鐵", "iQuit", "劉邦", "沒有進化", "相對論", "中國以東南", "杜牧", "紅藍黃", "河姆渡人", "筆", "沙灘", "7", "傳染病", "ㄕㄨㄞˋ", "H2O", "去他的" };
        private int[] answer_array = { 3, 3, 4, 1, 4, 3, 4, 1, 4, 3, 1, 3, 3, 2, 2, 1, 4, 3, 2, 4, 1 };
        internal DispatcherTimer timer;
        public Window1(int level, int stake, int round, int time)
        {
            InitializeComponent();
            _level = level;
            _stake = stake;
            _round = round;
            _time = time;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer1_Tick;
            Reset();
            timer.Start();          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //每一秒在計時Label內顯示秒數            
            lblTimer.Content = (Int32.Parse(lblTimer.Content.ToString()) - 1).ToString("000");
            if ((Int32.Parse(lblTimer.Content.ToString())).ToString("000") == "002")
            {
                System.Media.SystemSounds.Asterisk.Play();
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                //player.SoundLocation = @"C:\Users\Public\Music\Sample Music\KinectAudio.wave";
                //try
                //{
                //    player.Load();
                //    //player.Play();
                    
                //}
                //catch (System.IO.FileNotFoundException err)
                //{
                //    MessageBox.Show("找不到音效檔" + err.FileName);
                //}
                //catch (InvalidOperationException err)
                //{
                //    MessageBox.Show("播放發生錯誤：" + err.Message);
                //}
            }
            if ((Int32.Parse(lblTimer.Content.ToString())).ToString("000") == "-001")
            {
                Reset();
                timer.Start();
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            _ans = 1;
            calculate();
           Reset();
           timer.Start();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            _ans = 2;
            calculate();
            Reset();
            timer.Start();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            _ans = 3;
            calculate();
            Reset();
            timer.Start();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            _ans = 4;
            calculate();
            Reset();
            timer.Start();
        }
        private void calculate()
        {
            if (_ans == answer_array[_index])
            {
                System.Media.SystemSounds.Asterisk.Play();
                _combo++;
                _score+=5+_combo;
            }
            else 
            {
                if (_ans == 1)
                {
                    ans_one.Background = System.Windows.Media.Brushes.Red;
                }
                if (_ans == 2)
                {
                    ans_two.Background = System.Windows.Media.Brushes.Red;
                }
                if (_ans == 3)
                {
                    ans_three.Background = System.Windows.Media.Brushes.Red;
                }
                if (_ans == 4)
                {
                    ans_four.Background = System.Windows.Media.Brushes.Red;
                }
                _combo = 0;
            }
        }
        void Reset()
        {
            ans_one.Background = System.Windows.Media.Brushes.LightGray;
            ans_two.Background = System.Windows.Media.Brushes.LightGray;
            ans_three.Background = System.Windows.Media.Brushes.LightGray;
            ans_four.Background = System.Windows.Media.Brushes.LightGray;
            //關閉計時器
            timer.Stop();
            //所有label歸零
            lblTimer.Content = _time.ToString("000");

            for (int i = 3; i >= 1; i--)
            {
                Random rnd = new Random();
                _index = rnd.Next(question_array.Length);
                Question.Content = question_array[_index];
                ans_one.Content = one_array[_index];
                ans_two.Content = two_array[_index];
                ans_three.Content = three_array[_index];
                ans_four.Content = four_array[_index];
                
            }
            if (_round == 0)
            {
                _money = _stake * _score;
                Window2 w2 = new Window2(_score,_money);
                this.Content = w2.Content;
                w2.Close();
            }
            _round--;
        }
    }
}

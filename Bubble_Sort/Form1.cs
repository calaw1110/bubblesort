using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int n =5; //增加彈性  
        TextBox[] tbox1, tbox2;
        int[] Ran = new int[n];
        bool TF =false;//判斷tbox是否建立了
        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if (TF == false)
                Create_Tbox();//呼叫function 來生成textbox物件

            if (TF == true) { 
                Random ran = new Random();//生成一個亂數產生器
                for (int i = 0; i < n; i++)
                {
                    Ran[i] = ran.Next(0, 151);//將亂數放入陣列中
                    tbox1[i].Text = Convert.ToString(Ran[i]);//依照i值 依序將亂數填入textbox中
                }
            }
        }
        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            int i, j, k;//做bubble_sort 存放用
            for ( i = 0; i<n;i++)
            {
                for ( j = i+1;j<n;j++)
                {
                    if (Ran[i] < Ran[j])
                    {//降冪排列
                        k = Ran[i];
                        Ran[i] = Ran[j];
                        Ran[j] = k;
                    }
                }
            }
            for (i = 0; i < n; i++)//將排序後的陣列傳進textbox2顯示
                tbox2[i].Text = Convert.ToString(Ran[i]);
        }

        private void Btn_Clean_Click(object sender, EventArgs e)
        { 
            for (int i = 0; i < tbox1.Length; i++)
            { 
             tbox1[i].Dispose();//物件釋放
             tbox2[i].Dispose();
                
            }
            TF = false;
        }
   
        private void Create_Tbox()
        {
            tbox1 = new TextBox[n];
            tbox2 = new TextBox[n];
            for (int i = 0; i < tbox1.Length; i++)
            {
                tbox1[i] = new TextBox();
                tbox1[i].Name = string.Format("tbRandom{0}", i);
                tbox1[i].SetBounds(80, 50 + 40 * i, 40, 20);
                tbox1[i].BackColor = Color.FromArgb(200, 200, 200);
                this.Controls.Add(tbox1[i]);

                //bubble_sort use 
                tbox2[i] = new TextBox();
                tbox2[i].Name = string.Format("tbRandom{0}", i);
                tbox2[i].SetBounds(280, 50 + 40 * i, 40, 20);
                tbox2[i].BackColor = Color.FromArgb(200, 200, 200);
                this.Controls.Add(tbox2[i]);
                TF = true;
            }
        }
    }
}

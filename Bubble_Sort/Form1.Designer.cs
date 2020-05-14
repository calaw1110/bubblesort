namespace Bubble_Sort
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Sort = new System.Windows.Forms.Button();
            this.Btn_Clean = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(62, 320);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(75, 23);
            this.Btn_Create.TabIndex = 0;
            this.Btn_Create.Text = "產生亂數";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // Btn_Sort
            // 
            this.Btn_Sort.Location = new System.Drawing.Point(261, 320);
            this.Btn_Sort.Name = "Btn_Sort";
            this.Btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sort.TabIndex = 1;
            this.Btn_Sort.Text = "Bubble_Sort";
            this.Btn_Sort.UseVisualStyleBackColor = true;
            this.Btn_Sort.Click += new System.EventHandler(this.Btn_Sort_Click);
            // 
            // Btn_Clean
            // 
            this.Btn_Clean.Location = new System.Drawing.Point(473, 320);
            this.Btn_Clean.Name = "Btn_Clean";
            this.Btn_Clean.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clean.TabIndex = 2;
            this.Btn_Clean.Text = "清除畫面";
            this.Btn_Clean.UseVisualStyleBackColor = true;
            this.Btn_Clean.Click += new System.EventHandler(this.Btn_Clean_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 140);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "本範例示範：\r\n\r\n1. 自訂方法\r\n\r\n2. 動態產生物件(TextBox)陣列\r\n\r\n3. 產生亂數1~150\r\n\r\n4. 排序－泡沫排序(Bubble So" +
    "rt) \r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 366);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Clean);
            this.Controls.Add(this.Btn_Sort);
            this.Controls.Add(this.Btn_Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Sort;
        private System.Windows.Forms.Button Btn_Clean;
        private System.Windows.Forms.TextBox textBox1;
    }
}


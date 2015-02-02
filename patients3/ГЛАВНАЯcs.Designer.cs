namespace patients3
{
    partial class ГЛАВНАЯcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.пОИМЕНИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пОШИФРУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(933, 236);
            this.button1.TabIndex = 0;
            this.button1.Text = "ПОИСК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(0, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(933, 228);
            this.button2.TabIndex = 1;
            this.button2.Text = "РЕГИСТРАЦИЯ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пОИМЕНИToolStripMenuItem,
            this.пОШИФРУToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // пОИМЕНИToolStripMenuItem
            // 
            this.пОИМЕНИToolStripMenuItem.Name = "пОИМЕНИToolStripMenuItem";
            this.пОИМЕНИToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пОИМЕНИToolStripMenuItem.Text = "ПО ИМЕНИ";
            this.пОИМЕНИToolStripMenuItem.Click += new System.EventHandler(this.пОИМЕНИToolStripMenuItem_Click);
            // 
            // пОШИФРУToolStripMenuItem
            // 
            this.пОШИФРУToolStripMenuItem.Name = "пОШИФРУToolStripMenuItem";
            this.пОШИФРУToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пОШИФРУToolStripMenuItem.Text = "ПО ШИФРУ";
            this.пОШИФРУToolStripMenuItem.Click += new System.EventHandler(this.пОШИФРУToolStripMenuItem_Click);
            // 
            // ГЛАВНАЯcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ГЛАВНАЯcs";
            this.Text = "ГЛАВНАЯcs";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пОИМЕНИToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пОШИФРУToolStripMenuItem;
    }
}
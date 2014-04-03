namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.first_Node = new System.Windows.Forms.TextBox();
            this.second_Node = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.add_node = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.node = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.heu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_heu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Please  Choose The First File ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Second File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "Please Choose The Second File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "First File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(327, 20);
            this.textBox2.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 26);
            this.button3.TabIndex = 9;
            this.button3.Text = "Compute";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(7, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 92);
            this.panel1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "File";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // first_Node
            // 
            this.first_Node.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.first_Node.Location = new System.Drawing.Point(74, 21);
            this.first_Node.Name = "first_Node";
            this.first_Node.Size = new System.Drawing.Size(42, 20);
            this.first_Node.TabIndex = 12;
            // 
            // second_Node
            // 
            this.second_Node.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.second_Node.Location = new System.Drawing.Point(207, 21);
            this.second_Node.Name = "second_Node";
            this.second_Node.Size = new System.Drawing.Size(49, 20);
            this.second_Node.TabIndex = 13;
            // 
            // cost
            // 
            this.cost.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cost.Location = new System.Drawing.Point(302, 21);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(52, 20);
            this.cost.TabIndex = 14;
            // 
            // add_node
            // 
            this.add_node.Location = new System.Drawing.Point(368, 17);
            this.add_node.Name = "add_node";
            this.add_node.Size = new System.Drawing.Size(107, 29);
            this.add_node.TabIndex = 15;
            this.add_node.Text = "Add Node";
            this.add_node.UseVisualStyleBackColor = true;
            this.add_node.Click += new System.EventHandler(this.add_node_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "First Node :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Second Node :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cost :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.first_Node);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.second_Node);
            this.groupBox1.Controls.Add(this.cost);
            this.groupBox1.Controls.Add(this.add_node);
            this.groupBox1.Location = new System.Drawing.Point(3, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 50);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Node";
            // 
            // node
            // 
            this.node.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.node.Location = new System.Drawing.Point(72, 22);
            this.node.Name = "node";
            this.node.Size = new System.Drawing.Size(42, 20);
            this.node.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Node :";
            // 
            // heu
            // 
            this.heu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.heu.Location = new System.Drawing.Point(205, 22);
            this.heu.Name = "heu";
            this.heu.Size = new System.Drawing.Size(49, 20);
            this.heu.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Heuristic : ";
            // 
            // add_heu
            // 
            this.add_heu.Location = new System.Drawing.Point(367, 18);
            this.add_heu.Name = "add_heu";
            this.add_heu.Size = new System.Drawing.Size(107, 29);
            this.add_heu.TabIndex = 24;
            this.add_heu.Text = "Add Heu.";
            this.add_heu.UseVisualStyleBackColor = true;
            this.add_heu.Click += new System.EventHandler(this.add_heu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.add_heu);
            this.groupBox2.Controls.Add(this.node);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.heu);
            this.groupBox2.Location = new System.Drawing.Point(3, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 52);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Heuristic";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(7, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 136);
            this.panel2.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(4, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "That project created for CPE 415  Artificial Intelligence Course.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 320);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "CPE 415 ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox first_Node;
        private System.Windows.Forms.TextBox second_Node;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Button add_node;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox node;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox heu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_heu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}


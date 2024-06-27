namespace TankClientUI
{
    partial class ClientScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientScreen));
            Console = new TabControl();
            tpConsole = new TabPage();
            tbConsole = new TextBox();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            btConnect = new Button();
            tbEndpoint = new TextBox();
            pbLogo = new PictureBox();
            treeViewNodes = new TreeView();
            Console.SuspendLayout();
            tpConsole.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // Console
            // 
            Console.Controls.Add(tpConsole);
            Console.Controls.Add(tabPage2);
            Console.Location = new Point(12, 336);
            Console.Name = "Console";
            Console.SelectedIndex = 0;
            Console.Size = new Size(921, 152);
            Console.TabIndex = 0;
            // 
            // tpConsole
            // 
            tpConsole.Controls.Add(tbConsole);
            tpConsole.Location = new Point(4, 24);
            tpConsole.Name = "tpConsole";
            tpConsole.Padding = new Padding(3);
            tpConsole.Size = new Size(913, 124);
            tpConsole.TabIndex = 0;
            tpConsole.Text = "tabPage1";
            tpConsole.UseVisualStyleBackColor = true;
            // 
            // tbConsole
            // 
            tbConsole.Dock = DockStyle.Fill;
            tbConsole.Location = new Point(3, 3);
            tbConsole.Multiline = true;
            tbConsole.Name = "tbConsole";
            tbConsole.ReadOnly = true;
            tbConsole.ScrollBars = ScrollBars.Vertical;
            tbConsole.Size = new Size(907, 118);
            tbConsole.TabIndex = 0;
            tbConsole.Leave += tbConsole_Leave;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(913, 124);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btConnect);
            groupBox1.Controls.Add(tbEndpoint);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 50);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Server Endpoint";
            // 
            // btConnect
            // 
            btConnect.Location = new Point(433, 17);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(75, 23);
            btConnect.TabIndex = 1;
            btConnect.Text = "Conectar";
            btConnect.UseVisualStyleBackColor = true;
            btConnect.Click += btConnect_Click;
            // 
            // tbEndpoint
            // 
            tbEndpoint.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbEndpoint.Location = new Point(6, 17);
            tbEndpoint.Name = "tbEndpoint";
            tbEndpoint.Size = new Size(341, 23);
            tbEndpoint.TabIndex = 0;
            tbEndpoint.Text = "opc.tcp://localhost:4880/TankLevel/server";
            // 
            // pbLogo
            // 
            pbLogo.ImageLocation = "assets/mu.jpeg";
            pbLogo.InitialImage = (Image)resources.GetObject("pbLogo.InitialImage");
            pbLogo.Location = new Point(783, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(150, 125);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // treeViewNodes
            // 
            treeViewNodes.Location = new Point(12, 68);
            treeViewNodes.Name = "treeViewNodes";
            treeViewNodes.Size = new Size(514, 262);
            treeViewNodes.TabIndex = 3;
            treeViewNodes.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            // 
            // ClientScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 500);
            Controls.Add(treeViewNodes);
            Controls.Add(pbLogo);
            Controls.Add(groupBox1);
            Controls.Add(Console);
            Name = "ClientScreen";
            Text = "ClientScreen";
            Load += ClientScreen_Load;
            Console.ResumeLayout(false);
            tpConsole.ResumeLayout(false);
            tpConsole.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Console;
        private TabPage tpConsole;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Button btConnect;
        private TextBox tbEndpoint;
        private TextBox tbConsole;
        private PictureBox pbLogo;
        private TreeView treeViewNodes;
    }
}
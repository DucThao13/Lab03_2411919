namespace ChuDe3_ThaoTacTapTin.Forms
{
    partial class frmDemoThucHanh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabDemo = new System.Windows.Forms.TabControl();
            this.tabText = new System.Windows.Forms.TabPage();
            this.txtLogText = new System.Windows.Forms.TextBox();
            this.btnGhiDocText = new System.Windows.Forms.Button();
            this.tabJSON = new System.Windows.Forms.TabPage();
            this.txtLogJSON = new System.Windows.Forms.TextBox();
            this.btnReadJSON = new System.Windows.Forms.Button();
            this.tabXML = new System.Windows.Forms.TabPage();
            this.txtLogXML = new System.Windows.Forms.TextBox();
            this.pnlXMLButtons = new System.Windows.Forms.Panel();
            this.btnXmlSerializer = new System.Windows.Forms.Button();
            this.btnGhiXmlWriter = new System.Windows.Forms.Button();
            this.btnDocXmlDoc = new System.Windows.Forms.Button();
            this.tabDemo.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabJSON.SuspendLayout();
            this.tabXML.SuspendLayout();
            this.pnlXMLButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDemo
            // 
            this.tabDemo.Controls.Add(this.tabText);
            this.tabDemo.Controls.Add(this.tabJSON);
            this.tabDemo.Controls.Add(this.tabXML);
            this.tabDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDemo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDemo.Location = new System.Drawing.Point(0, 0);
            this.tabDemo.Name = "tabDemo";
            this.tabDemo.SelectedIndex = 0;
            this.tabDemo.Size = new System.Drawing.Size(782, 453);
            this.tabDemo.TabIndex = 0;
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.txtLogText);
            this.tabText.Controls.Add(this.btnGhiDocText);
            this.tabText.Location = new System.Drawing.Point(4, 29);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(10);
            this.tabText.Size = new System.Drawing.Size(774, 420);
            this.tabText.TabIndex = 0;
            this.tabText.Text = "1. Thao tác File Text (Trang 51)";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // txtLogText
            // 
            this.txtLogText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogText.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogText.Location = new System.Drawing.Point(10, 50);
            this.txtLogText.Multiline = true;
            this.txtLogText.Name = "txtLogText";
            this.txtLogText.ReadOnly = true;
            this.txtLogText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogText.Size = new System.Drawing.Size(754, 360);
            this.txtLogText.TabIndex = 1;
            // 
            // btnGhiDocText
            // 
            this.btnGhiDocText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGhiDocText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiDocText.Location = new System.Drawing.Point(10, 10);
            this.btnGhiDocText.Name = "btnGhiDocText";
            this.btnGhiDocText.Size = new System.Drawing.Size(754, 40);
            this.btnGhiDocText.TabIndex = 0;
            this.btnGhiDocText.Text = "Thực hiện Ghi và Đọc Text File (File.WriteAllLines & File.ReadAllLines)";
            this.btnGhiDocText.UseVisualStyleBackColor = true;
            this.btnGhiDocText.Click += new System.EventHandler(this.btnGhiDocText_Click);
            // 
            // tabJSON
            // 
            this.tabJSON.Controls.Add(this.txtLogJSON);
            this.tabJSON.Controls.Add(this.btnReadJSON);
            this.tabJSON.Location = new System.Drawing.Point(4, 29);
            this.tabJSON.Name = "tabJSON";
            this.tabJSON.Padding = new System.Windows.Forms.Padding(10);
            this.tabJSON.Size = new System.Drawing.Size(774, 420);
            this.tabJSON.TabIndex = 1;
            this.tabJSON.Text = "2. Đọc tập tin JSON (Trang 52-54)";
            this.tabJSON.UseVisualStyleBackColor = true;
            // 
            // txtLogJSON
            // 
            this.txtLogJSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogJSON.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogJSON.Location = new System.Drawing.Point(10, 50);
            this.txtLogJSON.Multiline = true;
            this.txtLogJSON.Name = "txtLogJSON";
            this.txtLogJSON.ReadOnly = true;
            this.txtLogJSON.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogJSON.Size = new System.Drawing.Size(754, 360);
            this.txtLogJSON.TabIndex = 1;
            // 
            // btnReadJSON
            // 
            this.btnReadJSON.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReadJSON.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadJSON.Location = new System.Drawing.Point(10, 10);
            this.btnReadJSON.Name = "btnReadJSON";
            this.btnReadJSON.Size = new System.Drawing.Size(754, 40);
            this.btnReadJSON.TabIndex = 0;
            this.btnReadJSON.Text = "Đọc tập tin JSON (students.json) và hiển thị thông báo";
            this.btnReadJSON.UseVisualStyleBackColor = true;
            this.btnReadJSON.Click += new System.EventHandler(this.btnReadJSON_Click);
            // 
            // tabXML
            // 
            this.tabXML.Controls.Add(this.txtLogXML);
            this.tabXML.Controls.Add(this.pnlXMLButtons);
            this.tabXML.Location = new System.Drawing.Point(4, 29);
            this.tabXML.Name = "tabXML";
            this.tabXML.Padding = new System.Windows.Forms.Padding(10);
            this.tabXML.Size = new System.Drawing.Size(774, 420);
            this.tabXML.TabIndex = 2;
            this.tabXML.Text = "3. Thao tác XML (Trang 54-58)";
            this.tabXML.UseVisualStyleBackColor = true;
            // 
            // txtLogXML
            // 
            this.txtLogXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogXML.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogXML.Location = new System.Drawing.Point(10, 60);
            this.txtLogXML.Multiline = true;
            this.txtLogXML.Name = "txtLogXML";
            this.txtLogXML.ReadOnly = true;
            this.txtLogXML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogXML.Size = new System.Drawing.Size(754, 350);
            this.txtLogXML.TabIndex = 1;
            // 
            // pnlXMLButtons
            // 
            this.pnlXMLButtons.Controls.Add(this.btnXmlSerializer);
            this.pnlXMLButtons.Controls.Add(this.btnGhiXmlWriter);
            this.pnlXMLButtons.Controls.Add(this.btnDocXmlDoc);
            this.pnlXMLButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXMLButtons.Location = new System.Drawing.Point(10, 10);
            this.pnlXMLButtons.Name = "pnlXMLButtons";
            this.pnlXMLButtons.Size = new System.Drawing.Size(754, 50);
            this.pnlXMLButtons.TabIndex = 0;
            // 
            // btnXmlSerializer
            // 
            this.btnXmlSerializer.Location = new System.Drawing.Point(490, 5);
            this.btnXmlSerializer.Name = "btnXmlSerializer";
            this.btnXmlSerializer.Size = new System.Drawing.Size(240, 38);
            this.btnXmlSerializer.TabIndex = 2;
            this.btnXmlSerializer.Text = "3. XmlSerializer (Trang 57-58)";
            this.btnXmlSerializer.UseVisualStyleBackColor = true;
            this.btnXmlSerializer.Click += new System.EventHandler(this.btnXmlSerializer_Click);
            // 
            // btnGhiXmlWriter
            // 
            this.btnGhiXmlWriter.Location = new System.Drawing.Point(245, 5);
            this.btnGhiXmlWriter.Name = "btnGhiXmlWriter";
            this.btnGhiXmlWriter.Size = new System.Drawing.Size(235, 38);
            this.btnGhiXmlWriter.TabIndex = 1;
            this.btnGhiXmlWriter.Text = "2. XmlWriter (Trang 56-57)";
            this.btnGhiXmlWriter.UseVisualStyleBackColor = true;
            this.btnGhiXmlWriter.Click += new System.EventHandler(this.btnGhiXmlWriter_Click);
            // 
            // btnDocXmlDoc
            // 
            this.btnDocXmlDoc.Location = new System.Drawing.Point(5, 5);
            this.btnDocXmlDoc.Name = "btnDocXmlDoc";
            this.btnDocXmlDoc.Size = new System.Drawing.Size(230, 38);
            this.btnDocXmlDoc.TabIndex = 0;
            this.btnDocXmlDoc.Text = "1. XmlDocument XPath (Trang 55)";
            this.btnDocXmlDoc.UseVisualStyleBackColor = true;
            this.btnDocXmlDoc.Click += new System.EventHandler(this.btnDocXmlDoc_Click);
            // 
            // frmDemoThucHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.tabDemo);
            this.Name = "frmDemoThucHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hướng dẫn thực hành Chủ đề 3 (Trang 51 - 58)";
            this.tabDemo.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.tabJSON.ResumeLayout(false);
            this.tabJSON.PerformLayout();
            this.tabXML.ResumeLayout(false);
            this.tabXML.PerformLayout();
            this.pnlXMLButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDemo;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.TextBox txtLogText;
        private System.Windows.Forms.Button btnGhiDocText;
        private System.Windows.Forms.TabPage tabJSON;
        private System.Windows.Forms.TextBox txtLogJSON;
        private System.Windows.Forms.Button btnReadJSON;
        private System.Windows.Forms.TabPage tabXML;
        private System.Windows.Forms.TextBox txtLogXML;
        private System.Windows.Forms.Panel pnlXMLButtons;
        private System.Windows.Forms.Button btnXmlSerializer;
        private System.Windows.Forms.Button btnGhiXmlWriter;
        private System.Windows.Forms.Button btnDocXmlDoc;
    }
}
